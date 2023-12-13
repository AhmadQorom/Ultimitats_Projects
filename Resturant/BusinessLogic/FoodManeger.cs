using AutoMapper;
using Contracts.Dtos.DrinksDtos;
using Contracts.Dtos.FoodsDtos;
using Contracts.Interfaces;
using Domin;

namespace BusinessLogic
{
    public class FoodManeger: IFoodService
    {
        // Food Manager
        private static List<Food> _FoodLists = new List<Food>();
        private readonly IMapper _mapper;

        public FoodManeger(IMapper mapper)
        {
            _FoodLists = GetFoodsFirstTime();
            _mapper = mapper;
        }

        public List<FoodDto> GetFoods()
        {
            var mapping = _mapper.Map<List<Food>, List<FoodDto>>(_FoodLists);
            return mapping;
        }

        public void AddFood(CreateFoodDto inputFromUser)
        {
            var mapping = _mapper.Map<CreateFoodDto, Food>(inputFromUser);
            _FoodLists.Add(mapping);
        }

        public void RemoveProduct(int FoodID)
        {
            for (int i = 0; i < _FoodLists.Count; i++)
            {
                if (i == FoodID)
                {
                    _FoodLists.Remove(_FoodLists[i]);
                }
            }
        }

        private static List<Food> GetFoodsFirstTime()
            {
                var list = new List<Food>()
                {
                    new Food()
                    {
                      FoodName = "Pizza",
                      FoodPrice = 15.5,
                      FoodQuantity = 28,
                    },
                    new Food()
                    {
                      FoodName = "HumBurger",
                      FoodPrice = 36.0,
                      FoodQuantity = 120,
                    }
                };
                return list;
            }

        public void UpdateFood(UpdateFoodsDtos inputFromUser)
        {
            var mapping = _mapper.Map<UpdateFoodsDtos, Food>(inputFromUser);
            var resultFromDataBase = _FoodLists.FirstOrDefault(s => s.Id == inputFromUser.Id);
            if (resultFromDataBase == null)
            {
                Console.WriteLine($"This Product: {mapping.FoodName} was not founded in the DataBase");
            }
            resultFromDataBase = mapping;
        }
    }

    
}
// 
/*  public void RemoveProduct(int FoodID)
      {
          Foods.Remove(FoodID);
      }*/

/*    public void AddProduct(Object Food)
       {
           Foods.Add(menue.IDDrink++, (Food)Food);
       }*/


/*
public void UpdateProduct(Object Food, int FoodID)
{
    Foods[FoodID] = (Food)Food;
}*/

//commit new line








