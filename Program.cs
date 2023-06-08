namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectric ev in electricVehicles)
            if(ev.CurrentChargePercentage == 100)
            {
                Console.WriteLine("The battery is charged you're ready to go!");
                // This should completely refuel the gas tank
                
            }

            else {
                ev.ChargeBattery();
            }

            foreach(IElectric ev in electricVehicles)
            if(ev.CurrentChargePercentage == 100)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }
            else {
                ev.FullCharge();
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            { 
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGas gv in gasVehicles)
            if(gv.CurrentTankPercentage == 100)
            {
                Console.WriteLine("The tank if full you're ready to go!");
                // This should completely refuel the gas tank
                
            }

            else {
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            if(gv.CurrentTankPercentage == 100)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            else{
                gv.FullTank();
            }
        }
    }
}