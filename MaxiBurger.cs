
class MaxiBurger extends Burger{
    MaxiBurger(Location location) 
    { 
        super(BurgerType.MAXI, location); 
        construct(); 
    } 
    @Override
    protected void construct() 
    { 
        Console.Writeln("Connecting to Maxi Burger"); 
    } 
}