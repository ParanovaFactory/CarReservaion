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
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Brand> _brandRepository;

        public UpdateBrandCommandHandler(IRepository<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task Handle(UpdateBrandCommand command)
        {
            var brand = await _brandRepository.GetByIdAsync(command.BrandId);
            brand.BrandName = command.BrandName;
            await _brandRepository.UpdateAsync(brand);
        }
    }
}
