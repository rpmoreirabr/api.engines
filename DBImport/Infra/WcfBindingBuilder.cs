using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;

namespace Api.Engines.Venda.Infra
{
    public class WcfBindingBuilder
    {
        private Binding binding;
        private SecurityMode securityMode = SecurityMode.None;

        public WcfBindingBuilder ComSecurityMode(string securityMode)
        {           
            switch (securityMode)
            {
                case "Message":
                    this.securityMode = SecurityMode.Message;
                    break;
                case "Transport":
                    this.securityMode = SecurityMode.Transport;
                    break;
                case "TransportWithMessageCredentials":
                    this.securityMode = SecurityMode.TransportWithMessageCredential;
                    break;
                default:
                    this.securityMode = SecurityMode.None;
                    break;
            }
            return this;
        }

        public WcfBindingBuilder ComBinding(string name)
        {
            switch (name)
            {
                case "basicHttpBinding":
                    binding = new BasicHttpBinding();
                    break;
                case "wsHttpBinding":
                    binding = new WSHttpBinding();                   
                    break;
                default:
                    throw new NotSupportedException("Bindings permitidos: WsHttpBinding and BasicHttpBinding");                    
            }
            return this;
        }   

        public Binding Build()
        {
            if(this.binding == null)
            {
                throw new ArgumentNullException("É necessário informar um binding antes do Build.");
            }
            var readerQuotas = new XmlDictionaryReaderQuotas();
            readerQuotas.MaxArrayLength = int.MaxValue;
            readerQuotas.MaxBytesPerRead = int.MaxValue;
            readerQuotas.MaxDepth = int.MaxValue;
            readerQuotas.MaxNameTableCharCount = int.MaxValue;
            readerQuotas.MaxStringContentLength = int.MaxValue;

            binding.CloseTimeout = new TimeSpan(0, 10, 0);
            binding.OpenTimeout = new TimeSpan(0, 10, 0);
            binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
            binding.SendTimeout = new TimeSpan(0, 10, 0);            

            if (binding is WSHttpBinding)
            {
                var wsBinding = binding as WSHttpBinding;
                wsBinding.Security.Mode = this.securityMode;
                if(securityMode == SecurityMode.TransportWithMessageCredential)
                {
                    wsBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
                    wsBinding.Security.Message.ClientCredentialType = MessageCredentialType.UserName;
                    wsBinding.Security.Message.EstablishSecurityContext = false;
                    wsBinding.ReaderQuotas = readerQuotas;
                    wsBinding.MaxBufferPoolSize = int.MaxValue;
                    wsBinding.MaxReceivedMessageSize = int.MaxValue;               
                }
            }
            else
            {
                var basicBinding = binding as BasicHttpBinding;
                basicBinding.ReaderQuotas = readerQuotas;
                basicBinding.MaxBufferPoolSize = int.MaxValue;
                basicBinding.MaxBufferSize = int.MaxValue;
                basicBinding.MaxReceivedMessageSize = int.MaxValue;
            }

            return binding;
        }
         
    }
}
