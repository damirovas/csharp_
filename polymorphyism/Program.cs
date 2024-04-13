namespace polymorphyism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car(100);

            Vehicle Bike= new Bike(100);
                
           
           car.Move();
        }
    }
}
