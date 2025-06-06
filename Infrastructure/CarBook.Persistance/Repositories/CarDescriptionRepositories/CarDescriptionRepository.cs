﻿using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionInterface
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        public CarDescription GetByCarId(int id)
        {
            var value = _context.CarDescriptions.FirstOrDefault(x => x.CarDescriptionCarId == id);
            return value;
        }
    }
}
