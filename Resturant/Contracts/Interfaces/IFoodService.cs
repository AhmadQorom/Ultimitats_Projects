using Contracts.Dtos.DrinksDtos;
using Contracts.Dtos.FoodsDtos;

namespace Contracts.Interfaces
{
    public interface IFoodService : IBaseService
    {
        public void AddFood(CreateFoodDto InputFromUser);
        public List<FoodDto> GetFoods();
        public void UpdateFood(UpdateFoodsDtos InputFromUser);
    }
}
