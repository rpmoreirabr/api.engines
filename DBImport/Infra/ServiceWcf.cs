using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Api.Engines.Venda.Infra
{
    /// <summary>
    /// Classe responsável por gerenciar a criação e liberação de canais WCF
    /// </summary>
    /// <typeparam name="TServiceInterface"></typeparam>
    public static class ServiceWcf<TServiceInterface>
    {
        private static object _syncRoot = new object();
        private static readonly Dictionary<string, ChannelFactory<TServiceInterface>> _channelFactory = new Dictionary<string, ChannelFactory<TServiceInterface>>();

        /// <summary>
        /// Cria fábrica de canais WCF
        /// Lança exceção caso o endpoint encapsulado não esteja com a nomenclatura correta
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="credentials"></param>
        /// <returns></returns>
        private static ChannelFactory<TServiceInterface> CreateChannelFactory(string serviceName, ClientCredentials credentials = null)
        {
            ChannelFactory<TServiceInterface> factory;

            try
            {
                factory = new WcfChannelFactoryBuilder<TServiceInterface>()
                    .ComServico(serviceName)
                    .Build();
            }
            catch (Exception)
            {
                throw;
            }

            AddCredentials(credentials, factory);

            return factory;
        }

        private static void AddCredentials(ClientCredentials credentials, ChannelFactory<TServiceInterface> factory)
        {
            if (credentials != null)
            {
                // step one - find and remove default endpoint behavior 
                var defaultCredentials = factory.Endpoint.Behaviors.Find<ClientCredentials>();
                factory.Endpoint.Behaviors.Remove(defaultCredentials);

                // step two - set that as new endpoint behavior on factory
                factory.Endpoint.Behaviors.Add(credentials); //add required ones
            }
        }

        /// <summary>
        /// Recupera a fábrica de canais WCF para determinado serviço.
        /// Cria a fábrica de canais, caso não exista.
        /// </summary>
        /// <param name="serviceName">nome padronizado do endpoint do serviço encapsulado</param>
        /// <param name="credentials">credenciais de acesso ao serviço, caso possua</param>
        /// <returns></returns>
        private static ChannelFactory<TServiceInterface> ChannelFactory(string serviceName, ClientCredentials credentials = null)
        {
            lock (_syncRoot)
            {
                if (!_channelFactory.ContainsKey(serviceName))
                    _channelFactory.Add(serviceName, CreateChannelFactory(serviceName, credentials));
            }

            return _channelFactory[serviceName];
        }

        /// <summary>
        /// Faz a chamada ao serviço encapsulando uma Action (método sem retorno)
        /// </summary>
        /// <param name="action">action</param>
        /// <param name="credentials">credenciais de acesso ao serviço, caso possua</param>
        public static void UseSync(Action<TServiceInterface> action, ClientCredentials credentials = null)
        {
            ActionCaller<TServiceInterface>.CallAction(action, (IClientChannel)ChannelFactory(typeof(TServiceInterface).FullName, credentials).CreateChannel());
        }

        /// <summary>
        /// Faz a chamada ao serviço encapsulando uma Function (método com retorno)
        /// </summary>
        /// <typeparam name="TResultType">tipo de retorno da function</typeparam>
        /// <param name="func">function</param>
        /// <param name="credentials">credenciais de acesso ao serviço, caso possua</param>
        /// <returns></returns>
        public static TResultType UseSync<TResultType>(Func<TServiceInterface, TResultType> func, ClientCredentials credentials = null)
        {
            return FuncCaller<TServiceInterface, TResultType>.CallFunc(func, (IClientChannel)ChannelFactory(typeof(TServiceInterface).Name, credentials).CreateChannel());
        }
    }
}
