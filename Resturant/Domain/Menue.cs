namespace Domin

{
    public interface IMenue
    {
        public void SeeDrinkList();
        public void SeeFoodList();
        public void OrderDrink(string drinkName = "", int drinkQuantity = 0);
        public void OrderFood(string foodName = "", int foodQuantity = 0);
        public Dictionary<int, Drink> GetDrinkList();
        public Dictionary<int, Food> GetFoodList();

    }
    //Fix issue with Bransh 
    public class TheMenue : IMenue
    {
        private static int IdDrink = 0;
        private static int IdFood = 0;

        private Dictionary<int, Drink> Drinks;  // DrinkID , Drink 
        private Dictionary<int, Food> Foods;  // DrinkID , Food 

        private static string[] DrinkList = { "Cola", "Water", "Juice", "Coffe", "Tea" };
        private static double[] DrinkPrice = { 5.5, 3.0, 6.5, 8.0, 11.0 };
        private static int[] DrinkQuantity = { 8, 9, 15, 7, 6 };

        private static string[] FoodList = { "Pizza", "Eges", "KFC", "Shawerma", "Burger" };
        private static double[] FoodPrice = { 25.0, 15.5, 65.0, 18.0, 30.0 };
        private static int[] FoodQuantity = { 7, 15, 20, 17, 56 };

        public int IDDrink 
        { 
            get { return IdDrink; } 
            set { IdDrink = value; }
        }
        public int IDFood
        {
            get { return IdFood; }
            set { IdFood = value; }
        }
        public TheMenue()
        {
            /* var drinkLists = new List<Drink>() 
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

             };*/
            Drinks = new Dictionary<int, Drink>();   // DrinkID  , Drink
            Foods = new Dictionary<int, Food>();    // FoodID   , Food
            InsertDrinks(ref Drinks);
            InsertFoods(ref Foods);
        }
        private void InsertDrinks(ref Dictionary<int, Drink> Drinks)
        {
            for (int i = 0; i < DrinkList.Length; i++)
            {
                Drink drink = new Drink();
                drink.DrinkName = DrinkList[i];
                drink.DrinkPrice = DrinkPrice[i];
                drink.DrinkQuantity = DrinkQuantity[i];
                Drinks.Add(TheMenue.IdDrink++, drink);
            }
        }
        private void InsertFoods(ref Dictionary<int, Food> Foods)
        {
            for (int i = 0; i < FoodList.Length; i++)
            {
                Food food = new Food();
                food.FoodName = FoodList[i];
                food.FoodPrice = FoodPrice[i];
                food.FoodQuantity = FoodQuantity[i];
                Foods.Add(TheMenue.IdFood++, food);
            }
        }
        public void SeeDrinkList()
        {
            for (int i = 0; i < Drinks.Count; i++)
            {
                Console.WriteLine($"Drink Name: {Drinks[i].DrinkName} , Drink Price: {Drinks[i].DrinkPrice}");
            }
        }
        public void SeeFoodList()
        {
            for (int i = 0; i < Foods.Count; i++)
            {
                Console.WriteLine($"Food Name: {Foods[i].FoodName} , Food Price: {Foods[i].FoodPrice}");
            }
        }
        public void OrderDrink(string drinkName = "", int drinkQuantity = 0)
        {
            for (int i = 0; i < Drinks.Count; i++)
            {
                if (drinkQuantity <= 0)
                {
                    Console.WriteLine("The Quantity you Entered is not Valid");
                    break;
                }
                // compare the drink string with the drink in Dictionary
                if (string.Equals(Drinks[i].DrinkName, drinkName, StringComparison.OrdinalIgnoreCase))
                {
                    if (Drinks[i].DrinkQuantity >= drinkQuantity)
                    {
                        Console.WriteLine("The Drink is available with the Quantity you want, The order will reach you");
                        Drinks[i].DrinkQuantity = Drinks[i].DrinkQuantity - drinkQuantity;
                    }
                    else  // here the the Quantity of the Drink in the Resturant is less than the Client needs
                    {
                        Console.WriteLine($"The Quantity for the ({Drinks[i].DrinkName}) in our Resturant is: {Drinks[i].DrinkQuantity}, Please Enter The Quantity Suitable with Quantity in our Resturant");
                        string newQuantity = Console.ReadLine();
                        int newQuan = Int32.Parse(newQuantity);
                        if (newQuan > 0 && newQuan <= Drinks[i].DrinkQuantity)
                        {
                            OrderDrink(drinkName, newQuan);
                        }
                        else
                        {
                            Console.WriteLine("The Drink Order is OFF");
                        }
                    }
                }
                /*  else
                  {
                      Console.WriteLine("The Drink you entered not exist");
                  }*/
            }
        }

        public void OrderFood(string foodName = "", int foodQuantity = 0)
        {

            for (int i = 0; i < Foods.Count; i++)
            {
                if (foodQuantity <= 0)
                {
                    Console.WriteLine("The Quantity you Entered is not Valid");
                    break;
                }
                // compare the food string with the food in Dictionary
                if (string.Equals(Foods[i].FoodName, foodName, StringComparison.OrdinalIgnoreCase))
                {
                    if (Foods[i].FoodQuantity >= foodQuantity)
                    {
                        Console.WriteLine("The Food is available with the Quantity you want, The order will reach you");
                        Foods[i].FoodQuantity = Foods[i].FoodQuantity - foodQuantity;
                    }
                    else  // here the the Quantity of the Food in the Resturant is less than the Client needs
                    {
                        Console.WriteLine($"The Quantity for the ({Foods[i].FoodName}) in our Resturant is: {Foods[i].FoodQuantity}, Please Enter The Quantity Suitable with Quantity in our Resturant");
                        string newQuantity = Console.ReadLine();
                        int newQuan = Int32.Parse(newQuantity);
                        if (newQuan > 0 && newQuan <= Foods[i].FoodQuantity)
                        {
                            OrderFood(foodName, newQuan);
                        }
                        else
                        {
                            Console.WriteLine("The Food Order is OFF");
                        }
                    }
                }           
            }
        }

        public Dictionary<int, Drink> GetDrinkList()
        {
            return Drinks;
        }
        public Dictionary<int, Food> GetFoodList()
        {
            return Foods;
        }

    }
}




