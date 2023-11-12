using Domin;

namespace BusinessLogic
{
    public interface IFoodManeger
    {
        void AddFood(Food Food);
        void RemoveFood(int FoodID);
        void UpdateFood(Food Food, int FoodID);
    }
    public class FoodManeger: IFoodManeger 
    {
        TheMenue menue;
        private Dictionary<int, Food> Foods;  // FoodID , Food

        public FoodManeger()
        {
            menue = new TheMenue();
            Foods = menue.GetFoodList();
        }
        public void AddFood(Food Food)
        {
            Foods.Add(menue.IDFood++, Food);
        }

        public void RemoveFood(int FoodID)
        {
            Foods.Remove(FoodID);
        }

        public void UpdateFood(Food Food, int FoodID)
        {
            Foods[FoodID] = Food;
        }

    }
}
