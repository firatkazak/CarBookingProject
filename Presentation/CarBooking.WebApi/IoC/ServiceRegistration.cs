using CarBooking.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBooking.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBooking.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBooking.Application.Features.CQRS.Handlers.CarHandlers;
using CarBooking.Application.Interfaces.CarInterfaces;
using CarBooking.Application.Interfaces;
using CarBooking.Persistence.Context;
using CarBooking.Persistence.Repositories;
using CarBooking.Persistence.Repositories.CarRepositories;
using CarBooking.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBooking.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBooking.Application.Interfaces.BlogInterfaces;
using CarBooking.Persistence.Repositories.BlogRepositories;
using CarBooking.Application.Interfaces.CarPricingInterfaces;
using CarBooking.Persistence.Repositories.CarPricingRepositories;
using CarBooking.Application.Interfaces.TagCloudInterfaces;
using CarBooking.Persistence.Repositories.TagCloudRepositories;
using CarBooking.Application.Features.RepositoryPattern;
using CarBooking.Persistence.Repositories.CommentRepositories;
using CarBooking.Application.Interfaces.StatisticInterfaces;
using CarBooking.Persistence.Repositories.StatisticRepositories;
using CarBooking.Application.Interfaces.RentACarInterfaces;
using CarBooking.Persistence.Repositories.RentACarRepositories;
using CarBooking.Application.Interfaces.CarFeatureInterfaces;
using CarBooking.Persistence.Repositories.CarFeatureRepositories;
using CarBooking.Application.Interfaces.CarDescriptionInterfaces;
using CarBooking.Persistence.Repositories.CarDescriptionRepositories;
using CarBooking.Application.Interfaces.ReviewInterfaces;
using CarBooking.Persistence.Repositories.ReviewRepositories;

namespace CarBooking.WebApi.IoC;

public static class ServiceRegistration
{
	public static void AddAPIServices(this IServiceCollection services)
	{
		//Database
		services.AddScoped<CarBookingContext>();
		//Repository Interface'leri
		services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
		services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
		services.AddScoped(typeof(IStatisticRepository), typeof(StatisticRepository));
		services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
		services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
		services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
		services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
		services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
		services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
		services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
		services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
		//About
		services.AddScoped<GetAboutQueryHandler>();
		services.AddScoped<GetAboutByIdQueryHandler>();
		services.AddScoped<CreateAboutCommandHandler>();
		services.AddScoped<UpdateAboutCommandHandler>();
		services.AddScoped<RemoveAboutCommandHandler>();
		//Banner
		services.AddScoped<GetBannerQueryHandler>();
		services.AddScoped<GetBannerByIdQueryHandler>();
		services.AddScoped<CreateBannerCommandHandler>();
		services.AddScoped<UpdateBannerCommandHandler>();
		services.AddScoped<RemoveBannerCommandHandler>();
		//Brand
		services.AddScoped<GetBrandQueryHandler>();
		services.AddScoped<GetBrandByIdQueryHandler>();
		services.AddScoped<CreateBrandCommandHandler>();
		services.AddScoped<UpdateBrandCommandHandler>();
		services.AddScoped<RemoveBrandCommandHandler>();
		//Car
		services.AddScoped<GetCarQueryHandler>();
		services.AddScoped<GetCarByIdQueryHandler>();
		services.AddScoped<CreateCarCommandHandler>();
		services.AddScoped<UpdateCarCommandHandler>();
		services.AddScoped<RemoveCarCommandHandler>();
		services.AddScoped<GetCarWithBrandQueryHandler>();//Car'a eklediğimiz Brand sorgusu
		services.AddScoped<GetLast5CarWithBrandQueryHandler>();//Car'a eklediğimiz Son 5 Brand sorgusu
        //Category
		services.AddScoped<GetCategoryQueryHandler>();
		services.AddScoped<GetCategoryByIdQueryHandler>();
		services.AddScoped<CreateCategoryCommandHandler>();
		services.AddScoped<UpdateCategoryCommandHandler>();
		services.AddScoped<RemoveCategoryCommandHandler>();
		//Contact
		services.AddScoped<GetContactQueryHandler>();
		services.AddScoped<GetContactByIdQueryHandler>();
		services.AddScoped<CreateContactCommandHandler>();
		services.AddScoped<UpdateContactCommandHandler>();
		services.AddScoped<RemoveContactCommandHandler>();
	}
}
