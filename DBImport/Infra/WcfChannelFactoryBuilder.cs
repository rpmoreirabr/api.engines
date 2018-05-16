using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Api.Engines.Venda.Infra
{
    public class WcfChannelFactoryBuilder<TServiceInterface>
    {       
        private EndpointAddress address;
        private string serviceName;
        public WcfChannelFactoryBuilder<TServiceInterface> ComServico(string name)
        {
            WcfBindingBuilder builder = new WcfBindingBuilder();
            
            //switch (name)
            //{
            //    case "IPessoaService":                    
            //        break;
            //    default:
            //        throw new NotSupportedException($"Serviço {name} não suportado.");
            //}
            serviceName = name;
            var endpoint = Environment.GetEnvironmentVariable($"{name}.Address", EnvironmentVariableTarget.Process);
            if (endpoint == null)
                throw new ArgumentNullException($"Não foi encontrado o AppSetting {name}.Address");
            address = new EndpointAddress(endpoint);
            return this;
        }

        public ChannelFactory<TServiceInterface> Build()
        {
            if (this.address == null)
                throw new ArgumentNullException("Não foi fornecido um endereço para o serviço");

            ChannelFactory<TServiceInterface> channel;
            Binding binding;
            EndpointAddress address = this.address;
            
            switch (serviceName)
            {
                //case "IPessoaService":
                //    binding = new WcfBindingBuilder().ComBinding("basicHttpBinding").Build();
                //    break;
                default:
                    binding = new WcfBindingBuilder().ComBinding("basicHttpBinding").Build();
                    break;
            }

            channel = new ChannelFactory<TServiceInterface>(binding, address);

            return channel;
        }
    }
}
