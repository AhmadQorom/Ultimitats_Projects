using AutoMapper;
using Contracts.Dtos.DrinksDtos;
using Contracts.Dtos.FoodsDtos;
using Domin;

namespace BusinessLogic
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Drink, DrinkDto>().ReverseMap();
            CreateMap<Drink, CreateDrinkDto>().ReverseMap();
            CreateMap<Drink, UpdateDrinksDtos>().ReverseMap();

            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Food, CreateFoodDto>().ReverseMap();
            CreateMap<Food, UpdateFoodsDtos>().ReverseMap();
        }
    }
}
