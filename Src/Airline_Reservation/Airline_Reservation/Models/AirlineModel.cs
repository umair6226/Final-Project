namespace Airline_Reservation.Models
{
    public class AirlineModel
    {
        public int AirlineID { get; set; }

        public string AirlineName { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }

        public int Status { get; set; }
    }
}
