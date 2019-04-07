
class DefaultBurgerFactory { 
    static Burger makeBurger(BurgerType type) 
        { 
            Burger burger = null; 
            switch (type) 
            { 
                case MINI: 
                    burger = new MiniBurger(Location.DEFAULT); 
                    break; 

                case STANDART: 
                    burger = new StandartBurger(Location.DEFAULT); 
                    break; 

                case MAXI: 
                    burger = new MaxiBurger(Location.DEFAULT); 
                    break; 

                    default: 
                    break; 

            } 
            return burger; 
        } 
}