class Program{
    static void Main(string[] args)
    {
        Console.WriteLine(BurgerFactory.makeBurger(BurgerType.MINI)); 
        Console.WriteLine(BurgerFactory.makeBurger(BurgerType.STANDART)); 
        Console.WriteLine(BurgerFactory.makeBurger(BurgerType.MAXI)); 
    }
}