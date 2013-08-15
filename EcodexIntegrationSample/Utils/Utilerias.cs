using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using EcodexIntegrationSample.View;

namespace EcodexIntegrationSample.Utils
{
    class Utilerias
    {
        /// <summary>
        /// This id can come from a database or be hard coded 
        /// by each service integrator or service reseller.
        /// </summary>
        //public String INTEGRATOR_ID = "2b3a8764-d586-4543-9b7e-82834443f219";

        public String INTEGRATOR_ID = "a44c9d23-5c35-487b-9857-8afc2128485c";

        //public string RFC = "AAA010101AAA";
        public string RFC = "SUL010720JN8";

        private IInterface _view;
        public Utilerias()
        {
            _view = null;
        }
        public Utilerias(IInterface Inter)
        {
            _view = Inter;
        }
        public string CreateToken(string RFC, Int64 transactionID, ref string token)
        {
            string result = string.Empty;
            try
            {
                #region Build Token
                using (var securitySrv = new SrvSecurity.SeguridadClient())
                {
                    var serviceToken = securitySrv.ObtenerToken(RFC, ref transactionID);
                    var toHash = String.Format("{0}|{1}", INTEGRATOR_ID, serviceToken);
                    token = Security.Hash(toHash);
                }
                #endregion
            }
            #region Security service exceptions
            catch (FaultException<SrvSecurity.FallaServicio> serviceFault)
            {
                using (var errorForm = new Forms.Error(TranslateFault.ToServiceError(serviceFault.Detail)))
                {
                    errorForm.ShowDialog();
                }
            }
            catch (FaultException<SrvSecurity.FallaSesion> sessionFauld)
            {
                _view.ShowSessionError(TranslateFault.ToSessionError(sessionFauld.Detail));
                result = TranslateFault.ToSessionError(sessionFauld.Detail).Description;
            }
            #endregion
            catch (Exception ex)
            {
                _view.ShowUnknownError(ex.Message);
                result = ex.Message;
            }
            return result;
        }
    }
}
