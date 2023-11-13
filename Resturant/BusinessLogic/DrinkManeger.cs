using AutoMapper;
using Contracts.Dtos.DrinksDtos;
using Contracts.Interfaces;
using Domin;

namespace BusinessLogic
{

    public class DrinkManeger : IDrinkService
    {
        private static List<Drink> _DrinkLists;

        private readonly IMapper _mapper;

        public DrinkManeger(IMapper mapper)
        {
            _DrinkLists = GetDrinksFirstTime();
            _mapper = mapper;
        }

        public List<DrinkDto> GetDrinks()
        {
            var mapping = _mapper.Map<List<Drink>, List<DrinkDto>>(_DrinkLists);
            return mapping;
        }

        public void AddDrink(CreateDrinkDto inputFromUser)
        {
            var mapping = _mapper.Map<CreateDrinkDto, Drink>(inputFromUser);
            _DrinkLists.Add(mapping);
        }

        public void RemoveProduct(int drinkID)
        {
            for (int i = 0; i < _DrinkLists.Count; i++)
            {
                if (i == drinkID)
                {
                    _DrinkLists.Remove(_DrinkLists[i]);
                    break;
                }
            }
        }

        public void UpdateDrink(UpdateDrinksDtos inputFromUser)
        {
            var mapping = _mapper.Map<UpdateDrinksDtos, Drink>(inputFromUser);
            var resultFromDataBase = _DrinkLists.FirstOrDefault(s => s.Id == inputFromUser.Id);
            if (resultFromDataBase == null)
            {
                Console.WriteLine($"This Product: {mapping.DrinkName} is not in the DataBase");
            }
            resultFromDataBase = mapping;
        }

        private static List<Drink> GetDrinksFirstTime()
        {
            var list = new List<Drink>()
            {
                new Drink()
                {
                  DrinkName = "Cola",
                  DrinkPrice = 5.5,
                  DrinkQuantity = 8,
                },
                new Drink()
                {
                  DrinkName = "Water",
                  DrinkPrice = 3.0,
                  DrinkQuantity =  9 ,
                }
            };
            return list;
        }
    }
}






/*    public void AddProduct(Object Drink) 
      {
          Drinks.Add(menue.IDDrink++, (Drink)Drink);
      }
  */

/*
       public void UpdateProduct(Object drink,int DrinkID)
       {
           Drinks[DrinkID] = (Drink)drink;
       }
   */

/*
 private static string[] DrinkList = { "Cola", "Water", "Juice", "Coffe", "Tea" };
        private static double[] DrinkPrice = { 5.5, 3.0, 6.5, 8.0, 11.0 };
        private static int[] DrinkQuantity = { 8, 9, 15, 7, 6 };

 */