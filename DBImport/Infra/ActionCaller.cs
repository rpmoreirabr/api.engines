using System;
using System.ServiceModel;

namespace Api.Engines.Venda.Infra
{
    public static class ActionCaller<TActionType>
    {
        public static void CallAction(Action<TActionType> action, IClientChannel proxy)
        {
            try
            {
                action((TActionType)proxy);
            }
            catch (CommunicationException ex)
            {
                proxy.Abort();
                throw ex;
            }
            catch (TimeoutException ex)
            {
                proxy.Abort();
                throw ex;
            }
            catch (Exception ex)
            {
                proxy.Abort();
                throw ex;
            }
            finally
            {
                if (proxy.State == CommunicationState.Opened)
                    proxy.Close();
            }
        }
    }
}
