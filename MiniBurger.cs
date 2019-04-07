
class MiniBurger extends Burger{
    MiniBurger(Location location) 
    { 
        super(BurgerType.MINI, location); 
        construct(); 
    } 
    @Override
    protected void construct() 
    { 
        Console.Writeln("Connecting to Mini Burger"); 
    } 
}