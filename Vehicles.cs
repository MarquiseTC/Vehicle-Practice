namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Turn(){
            Console.WriteLine("Right turn");
        }
        public virtual void Stop(){
            Console.WriteLine("The vehicle stops");
        }
        
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}