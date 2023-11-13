using Contracts.Dtos.FoodsDtos;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ResturantApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet(Name = "Get All Foods")]
        public List<FoodDto> GetFood()
        {
            var result = _foodService.GetFoods();
            return result;
        }

        [HttpPost(Name = "Creating new Food")]
        public List<FoodDto> CreateFood(CreateFoodDto inputFromUser)
        {
            _foodService.AddFood(inputFromUser);
            return GetFood();
        }

        [HttpPut(Name = "Update Food")]
        public List<FoodDto> UpdateFood(UpdateFoodsDtos inputFromUser)
        {
            _foodService.UpdateFood(inputFromUser);
            return GetFood();
        }

        [HttpDelete(Name = "Delete Food")]
        public List<FoodDto> DeleteFood(int productID)
        {
            _foodService.RemoveProduct(productID);
            return GetFood();
        }
    }
}
