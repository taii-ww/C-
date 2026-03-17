// See https://aka.ms/new-console-template for more information


using BT_UNIT1._2_1;

MenuItem[] menu = new MenuItem[7];

menu[0] = new Beverage("Coffee", 1.5, 2.0, 2.5);
menu[1] = new Beverage("Tea", 1.2, 1.7, 2.2);
menu[2] = new Beverage("Milk", 1.3, 1.8, 2.3);
menu[3] = new Beverage("Juice", 1.4, 1.9, 2.4);

menu[4] = new Snack("Cake", 2.5);
menu[5] = new Snack("Cookie", 1.8);
menu[6] = new Snack("Sandwich", 3.0);

Console.WriteLine("----- MENU -----");

foreach (MenuItem item in menu)
{
    item.printToScreen();
}
