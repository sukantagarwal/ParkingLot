namespace ParkingLotApp
{
    public class ParkingLevel
    {
        public int ParkingLevelId { get; set; }
        public int ParkingLevelNumber {get;set;}
        public List<ParkingSpace> ParkingSpaces {get;set;}
    }
}