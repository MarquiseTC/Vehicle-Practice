namespace Garage
{
   
//    : represents the inheritence method
    public class Tesla : Vehicle 
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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