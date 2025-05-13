using CarBook.Application.Features.CQRS.Comments.BrandCommands;
using CarBook.Application.Inrfefaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public CreateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(CreateBrandCommand command)
        {
            await _brandRepository.CreateAsync(new Brand
            {
                BrandName = command.BrandName
            });
        }
    }
}

