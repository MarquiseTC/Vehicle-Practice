namespace Garage
{
    public class Ram : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } = 100;
        
        public void RefuelTank()
        {
            
            double difference = FuelCapacity - CurrentTankPercentage;
            double refuel = CurrentTankPercentage + difference;
            Console.WriteLine($"You need a little more fuel {difference}. Let's fill up!");
        }

        public double CurrentTankPercentage {get; set;} = 49;

        public void FullTank(){
            double difference = FuelCapacity - CurrentTankPercentage;
            double refuel = CurrentTankPercentage + difference;
           Console.WriteLine($"{refuel}");
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