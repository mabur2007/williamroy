﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.application.Interfaces;
//using Tracker.persistence.Repositories;
//using Tracker.application.Interfaces;
using Tracker.domain.Entities;

namespace Tracker.application.Services
{

    public class VehicleService
    {
        private readonly IVehicleRepository _repo;
        //private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
        {
            return (IEnumerable<Vehicle>)await _repo.GetAllAsync();
            //return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

    }
}