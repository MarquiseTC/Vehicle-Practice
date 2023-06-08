namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; } = 100;

        public void RefuelTank()
        {
            double difference = FuelCapacity - CurrentTankPercentage;
            double refuel = CurrentTankPercentage + difference;
            Console.WriteLine($"You need a little more fuel {difference}. Let's fill up!");
        }

        public double CurrentTankPercentage {get; set;} = 75;
        public void FullTank(){
            double difference = FuelCapacity - CurrentTankPercentage;
            double refuel = CurrentTankPercentage + difference;
           Console.WriteLine($"{refuel}");
        }
        
        public override void Drive()
        {
            Console.WriteLine("The purple Cesna goes Zoooooom!");
        }
        public override void Turn(){
            Console.WriteLine("The vehicle makes a real fast right turn");
        }
       
       public override void Stop(){
        Console.WriteLine("The purple Cesna zooms past every car to get to the stop sign first");
       }
    }
}