using System;
using System.ServiceModel;

namespace Api.Engines.Venda.Infra
{
    public static class FuncCaller<TFuncType, TResultType>
    {
        public static TResultType CallFunc(Func<TFuncType, TResultType> func, IClientChannel proxy)
        {
            try
            {
                return func((TFuncType)proxy);
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
