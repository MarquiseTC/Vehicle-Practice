public interface IGas{
void RefuelTank();
double FuelCapacity{get;set;}

double CurrentTankPercentage{get;set;}

void FullTank();
}

public interface IElectric{
    void ChargeBattery();
    double BatteryKWh{get;set;}

    double CurrentChargePercentage{get;set;}

    void FullCharge();
}