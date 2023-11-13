using Contracts.Dtos.DrinksDtos;
using Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ResturantApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DrinkController : ControllerBase
    {      
        private readonly IDrinkService _drinkService;

        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }
        
        [HttpGet(Name = "Get All Drinks")]
        public List<DrinkDto> GetDrink()
        {
            var result = _drinkService.GetDrinks();
            return result;
        }

        [HttpPost(Name = "Creating new Drink")]
        public List<DrinkDto> CreateDrink(CreateDrinkDto inputFromUser)
        {
            _drinkService.AddDrink(inputFromUser);
            return GetDrink();
        }

        [HttpPut(Name = "Update Drink")]
        public List<DrinkDto> UpdateDrink(UpdateDrinksDtos inputFromUser)
        {
            _drinkService.UpdateDrink(inputFromUser);
            return GetDrink();
        }

        [HttpDelete(Name = "Delete Drink")]
        public List<DrinkDto> DeleteDrink(int productID)
        {
            _drinkService.RemoveProduct(productID);
            return GetDrink();
        }
    }
}
