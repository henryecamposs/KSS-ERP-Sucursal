using kss_ERPSucursal_WebControl.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace kss_ERPSucursal_WebControl.Controllers
{
    public class demoPaisesApiController : ApiController
    {
        private IPaisesRepository PaisesRepository;

        public demoPaisesApiController()
        {
            this.PaisesRepository = new PaisesRepository(new Models.kssERPSucursaldbEntities());
        }

        [HttpGet]
        [Route("Api/demoPaisesApi")]
        public List< kss_ERPSucursal_WebControl.Models.world_Paises> GetProductsApi()
        {
            return PaisesRepository.GetPaises().ToList();
             
        }

        [HttpGet]
        [Route("demoPaisesApi")]
        public Models.Datatables.DataTableResponse GetPaises()
        {
            var products = PaisesRepository.GetPaises();

            return new Models.Datatables.DataTableResponse
            {
                recordsTotal = products.Count(),
                recordsFiltered = 10,
                data = products.Take(10).ToArray()
            };
        }
    }
}
