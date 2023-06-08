namespace Garage
{
   
//    : represents the inheritence method
    public class Tesla : Vehicle, IElectric
    {
        public double BatteryKWh { get; set; } = 100;

        public void ChargeBattery()
        {
            double difference = BatteryKWh - CurrentChargePercentage;
            double charge = CurrentChargePercentage + difference;
            Console.WriteLine($"You need a little more fuel {difference}. Let's fill up!");
        }

    public double CurrentChargePercentage{get; set;} = 49;

    public void FullCharge(){
            double difference = BatteryKWh - CurrentChargePercentage;
            double charge = CurrentChargePercentage + difference;
           Console.WriteLine($"{charge}");
        }
    public override void Drive(){
    Console.WriteLine("The tangerine Tesla goes wsowowowowowowowoowowowowowowo");
   }
   public override void Turn(){
            Console.WriteLine("The vehicle makes a quick right turn");
        }
       
       public override void Stop(){
        Console.WriteLine("The tangerine zero slowly stops");
       }
    }
}