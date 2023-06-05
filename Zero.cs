namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
       

        public void ChargeBattery()
        {
            // method definition omitted
        }
   public override void Drive(){
    Console.WriteLine("The aquamarine Zero goes alkshidfoahosihfoihfs");
   }
        public override void Turn(){
            Console.WriteLine("The vehicle makes a quick right turn");
        }
       
       public override void Stop(){
        Console.WriteLine("The aquamarine zero rolls to a stop");
       }
        
    }
}