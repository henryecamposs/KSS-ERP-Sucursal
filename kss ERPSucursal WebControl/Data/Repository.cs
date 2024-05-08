using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kss_ERPSucursal_WebControl.Models;

namespace kss_ERPSucursal_WebControl.Data
{
    public interface IPaisesRepository
    {
        IQueryable<kss_ERPSucursal_WebControl.Models.world_Paises> GetPaises();
    }

    public class PaisesRepository : IPaisesRepository
    {
        private kssERPSucursaldbEntities context;

        public PaisesRepository(kssERPSucursaldbEntities context)
        {
            this.context = context;
        }
 
        public IQueryable<world_Paises> GetPaises()
        {
            return context.world_Paises;
        }
    }
}