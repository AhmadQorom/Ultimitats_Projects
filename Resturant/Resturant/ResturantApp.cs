using AutoMapper;
using Contracts.Dtos.DrinksDtos;
using Contracts.Dtos.FoodsDtos;
using Domin;


Console.WriteLine("Welcome in our resturant , you can see all the Drinks and the Foods we have:\n");
    Console.WriteLine("Drinks: ");
    TheMenue Menue = new TheMenue();
    Menue.SeeDrinkList();

    Console.WriteLine("\n*********************************************************************\n");
    Console.WriteLine("Foods: ");
    Menue.SeeFoodList();
    Console.WriteLine("\n*********************************************************************\n");

Drink:
    Console.WriteLine("Enter The Name of the Drink if you want, and if you won't to drink anything, enter -1: ");
    string orderDrinkName = Console.ReadLine();
    if (orderDrinkName == "-1")
       goto Food;
    Console.WriteLine("Enter the Quantity of the Drink you Selected: ");
    int quantityDrink = Int32.Parse(Console.ReadLine());
    Menue.OrderDrink(orderDrinkName, quantityDrink);
   
Food:
    Console.WriteLine("Enter The Name of the Food if you want, and if you won't to eat anything, enter -1: ");
    string orderFoodName = Console.ReadLine();
    if (orderFoodName == "-1")
       goto End;
    Console.WriteLine("Enter the Quantity of the Food you Selected: ");
    int quantityFood = Int32.Parse(Console.ReadLine());
    Menue.OrderFood(orderFoodName, quantityFood);

End:
    Console.WriteLine("Meneu Closed, Welcome in our Resturant");