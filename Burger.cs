enum BurgerType {
    MINI, STANDART, MAXI
}

enum Location 
{ 
  DEFAULT, USA, INDIA 
}

abstract class Burger{
    Burger(BurgerType type, Location location) 
    { 
        this.type = type; 
        this.location = location; 
    } 
    abstract void constructor();

    BurgerType type = null; 
    Location location = null; 

    BurgerType getType() 
    { 
        return type; 
    } 
   
    void setType(BurgerType type) 
    { 
        this.type = type; 
    } 
   
    Location getLocation() 
    { 
        return location; 
    } 
   
    void setLocation(Location location) 
    { 
        this.location = location; 
    } 

    @Override
    public String toString() 
    { 
        return "BurgerType - "+type + " located in "+location; 
    } 
}