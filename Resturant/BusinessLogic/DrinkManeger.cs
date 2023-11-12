
using Domin;

namespace BusinessLogic
{
    public interface IDrinkManeger
    {
        void AddDrink(Drink Drink);
        void RemoveDrink(int DrinkID);
        void UpdateDrink(Drink Drink, int DrinID);
    }
    public class DrinkManeger: IDrinkManeger 
    {
        TheMenue menue;
        private Dictionary<int, Drink> Drinks;  // DrinkID , Drink 

        public DrinkManeger() 
        {
            menue = new TheMenue();
            Drinks = menue.GetDrinkList();
        }
        public void AddDrink(Drink Drink) 
        {
            Drinks.Add(menue.IDDrink++, Drink);
        }

        public void RemoveDrink(int DrinkID)
        {
            Drinks.Remove(DrinkID);
        }

        public void UpdateDrink(Drink drink,int DrinkID)
        {
            Drinks[DrinkID] = drink;
        }

       
    }
}


