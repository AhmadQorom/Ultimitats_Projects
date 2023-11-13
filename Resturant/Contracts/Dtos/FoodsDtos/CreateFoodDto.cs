using Contracts.Dtos.DrinksDtos;

namespace Contracts.Dtos.FoodsDtos
{
    public class CreateFoodDto
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int FoodQuantity { get; set; }
    }
}