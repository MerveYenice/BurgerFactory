
class USABurgerFactory { 
    static Burger makeBurger(BurgerType type) 
        { 
            Burger burger = null; 
            switch (type) 
            { 
                case MINI: 
                    burger = new MiniBurger(Location.USA); 
                    break; 

                case STANDART: 
                    burger = new StandartBurger(Location.USA); 
                    break; 

                case MAXI: 
                    burger = new MaxiBurger(Location.USA); 
                    break; 

                    default: 
                    break; 

            } 
            return burger; 
        } 
}