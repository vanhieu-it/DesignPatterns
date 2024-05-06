public class Waiter
{
    public void TakeOrder() => Console.WriteLine("Waiter takes order");  
}
public class Chef
{
    public void Cook() => Console.WriteLine("Chef cooks the meal"); 
}
public class Cashier
{
    public void BillCustomer() => Console.WriteLine("Cashier bills the customer");
}
public class RestaurantFacade
{
    private Waiter _waiter;
    private Chef _chef;
    private Cashier _cashier;

    public RestaurantFacade()
    {
        _waiter = new Waiter();
        _chef = new Chef();
        _cashier = new Cashier();
    }
    public void CompleteOrder()
    {
        _waiter.TakeOrder();
        _chef.Cook();
        _cashier.BillCustomer();
    }
}
class Program
{
    static void Main(string[] args)
    {
        RestaurantFacade facade = new RestaurantFacade();
        facade.CompleteOrder();
    }
}