
class IndiaBurgerFactory { 
    static Burger makeBurger(BurgerType type) 
        { 
            Burger burger = null; 
            switch (type) 
            { 
                case MINI: 
                    burger = new MiniBurger(Location.INDIA); 
                    break; 

                case STANDART: 
                    burger = new StandartBurger(Location.INDIA); 
                    break; 

                case MAXI: 
                    burger = new MaxiBurger(Location.INDIA); 
                    break; 

                    default: 
                    break; 

            } 
            return burger; 
        } 
}