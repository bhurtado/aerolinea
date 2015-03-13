﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aerolinea.Models.Domain.Business
{
    public class VueloMgr
    {
        private IRepository _repository;

        public VueloMgr()
        {
            _repository = new Repository();
        }

        public VueloMgr(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<VueloView> BusquedaVuelos()
        {
            var list = _repository.BusquedaVuelos();
            return list;
        
        }

    }
}