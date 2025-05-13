using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBook.Application.Inrfefaces.CarInterfaces;
using CarBook.Application.Inrfefaces;
using CarBook.Application.Interfaces.BlogInterfaces;
using CarBook.Application.Interfaces.CarDescriptionInterfaces;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Application.Interfaces.CarRewievInterfaces;
using CarBook.Application.Interfaces.CommnetInterfaces;
using CarBook.Application.Interfaces.RentACarInterfaces;
using CarBook.Application.Interfaces.StatisticInterfaces;
using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Persistance.Context;
using CarBook.Persistance.Repositories.BlogRepository;
using CarBook.Persistance.Repositories.CarDescriptionRepositories;
using CarBook.Persistance.Repositories.CarFeatureRepostories;
using CarBook.Persistance.Repositories.CarPricingRepository;
using CarBook.Persistance.Repositories.CarRepository;
using CarBook.Persistance.Repositories.CarReviewRepositories;
using CarBook.Persistance.Repositories.CommentRepositories;
using CarBook.Persistance.Repositories.RentACarRepositories;
using CarBook.Persistance.Repositories.StatisticRepositories;
using CarBook.Persistance.Repositories.TagCloudRepositories;
using CarBook.Persistance.Repositories;
using CarBook.Application.Tools;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CarBook.WebApi.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            // DbContext
            services.AddScoped<CarBookContext>();

            // Repositories
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICarPricingRepository, CarPricingRepository>();
            services.AddScoped<ITagCloudRepository, TagCloudRepository>();
            services.AddScoped<IStatisticRepository, StatisticRepository>();
            services.AddScoped<IRentACarInterface, RentACarRepository>();
            services.AddScoped<ICommentInterface, CommnetRepository>();
            services.AddScoped<ICarFeatureInterface, CarFeatureRepository>();
            services.AddScoped<ICarDescriptionInterface, CarDescriptionRepository>();
            services.AddScoped<ICarReviewInterface, CarReviewRepository>();

            // Handlers - About
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();

            // Handlers - Banner
            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<CreateBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();

            // Handlers - Brand
            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();

            // Handlers - Car
            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<CreateCarCommandHandler>();
            services.AddScoped<UpdateCarCommandHandler>();
            services.AddScoped<RemoveCarCommandHandler>();
            services.AddScoped<GetCarWithBrandQueryHandler>();
            services.AddScoped<GetLast5CarsWithBrandQueryHandler>();
            services.AddScoped<GetCarByIdWithBrandQueryHandler>();

            // Handlers - Category
            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();

            // Handlers - Contact
            services.AddScoped<GetContactQueryHandler>();
            services.AddScoped<GetContactByIdQueryHandler>();
            services.AddScoped<CreateContactCommandHandler>();
            services.AddScoped<UpdateContactCommandHandler>();
            services.AddScoped<RemoveContactCommandHandler>();

            // HttpClient
            services.AddHttpClient();

            // CORS
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .SetIsOriginAllowed(_ => true)
                           .AllowCredentials();
                });
            });

            // SignalR
            services.AddSignalR();

            // JWT Authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(opt =>
                    {
                        opt.RequireHttpsMetadata = false;
                        opt.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidAudience = JwtTokenDefaults.ValidAudience,
                            ValidIssuer = JwtTokenDefaults.ValidIssuer,
                            ClockSkew = TimeSpan.Zero,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
                            ValidateLifetime = true,
                            ValidateIssuerSigningKey = true
                        };
                    });

            return services;
        }
    }
}
