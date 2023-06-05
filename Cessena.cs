namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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