
class StandartBurger extends Burger{
    StandartBurger(Location location) 
    { 
        super(BurgerType.STANDART, location); 
        construct(); 
    } 
    @Override
    protected void construct() 
    { 
        Console.Writeln("Connecting to Standart Burger"); 
    } 
}