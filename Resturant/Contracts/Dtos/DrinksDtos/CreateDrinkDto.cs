namespace Contracts.Dtos.DrinksDtos
{
    public class CreateDrinkDto
    {
        public int Id { get; set; }
        public string DrinkName { get; set; }
        public double DrinkPrice { get; set; }
        public int DrinkQuantity { get; set; }
    }
}
