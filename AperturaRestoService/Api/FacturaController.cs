using AperturaRestoService.Dto;
using System;
using System.Web.Http;

namespace AperturaRestoService.Api
{
    public class FacturaController : BaseController
    {
        public IHttpActionResult AfterInsert(FacturaDto data)
        {
            try
            {
                Log.Debug("FacturaController.AfterSend: Inicio");
                // Desarrollo de lógica de apertura
                //LogData(data);
                // Fin de lógica de apertura
                Log.Debug("FacturaController.AfterSend: Fin");
                return Ok();
            }
            catch (Exception e)
            {
                Log.Fatal("FacturaController.AfterSend", e);
                return InternalServerError();
            };
        }
    }
}
