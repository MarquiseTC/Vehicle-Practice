namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        
        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive(){
        Console.WriteLine("The midnightblack Ram goes kuppowowowowowo");
   }
   public override void Turn(){
            Console.WriteLine("The vehicle makes a teeny tiny right turn");
        }
       
       public override void Stop(){
        Console.WriteLine("The midnight black Ram obeys the traffic laws and comes to a complete stop.");
       }
    }
}