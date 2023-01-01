namespace ParkingLotApp;

public class ParkingSpace
{
    public int ParkingSpaceId {get;set;}
    public int ParkingLotId { get; set; }
    public int ParkingLevel { get; set; }
    public int VehicleId { get; set; }
    public bool Occupied { get; set; }
    public int MyProperty { get; set; }
}
