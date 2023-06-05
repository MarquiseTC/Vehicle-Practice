namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram cx30 = new Ram();
            Zero t456 = new Zero();

            fxs.Drive();
            fxs.Turn();
            
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();


            mx410.Drive();
            mx410.Turn();
            mx410.Stop();


            cx30.Drive(); 
            cx30.Turn();
            cx30.Stop();

            t456.Drive();
            t456.Turn();
            t456.Stop();
            
        }
    }
}