class BurgerFactory{
    private BurgerFactory(){

    }
    public static Burger makeBurger(BurgerType type){
        Burger burger = null;

        Location location = Location.INDIA;
        switch(location){ 
            case USA: 
                burger = USABurgerFactory.makeBurger(type); 
                break; 
                  
            case INDIA: 
                burger = IndiaBurgerFactory.makeBurger(type); 
                break; 
                      
            default: 
                burger = DefaultBurgerFactory.makeBurger(type); 
  
        } 
        return burger;

    }
}