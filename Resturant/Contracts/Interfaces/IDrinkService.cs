using Contracts.Dtos.DrinksDtos;

namespace Contracts.Interfaces
{
    public interface IDrinkService : IBaseService
    {
        public void AddDrink(CreateDrinkDto inputFromUser);
        public List<DrinkDto> GetDrinks();
        public void UpdateDrink(UpdateDrinksDtos inputFromUser);
    }
}
