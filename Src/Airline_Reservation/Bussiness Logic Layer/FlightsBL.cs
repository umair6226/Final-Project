using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Bussiness_Logic_Layer
{
    public class FlightsBL
    {
        public int FlightNo { get; set; }

        [Required(ErrorMessage = "Enter Flight Name")]
        public string FlightName { get; set; }
        public string AirlineName { get; set; }
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Enter Time")]
        public DateTime DepartureTime { get; set; }
        public double TravelDuration { get; set; }

        [Required(ErrorMessage = "Select any Source")]
        public string Source { get; set; }

        [Required(ErrorMessage = "Select any Destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Provide Distance")]
        public string Distance { get; set; }

        [Required(ErrorMessage = "Enter No of Seats")]
        public string SeatAvalaible { get; set; }

        [Required(ErrorMessage = "Select Airline")]
        public int AirlineID { get; set; }
        public string CreatedBy { get; set; }

        [Required(ErrorMessage = "Select Status")]
        public int Status { get; set; }
        public int FlightTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public int Save(FlightsBL obj)
        {
            int result = 0;
            SqlParameter[] prm = new SqlParameter[12];
            prm[0] = new SqlParameter("@Flight_No", obj.FlightNo);
            prm[1] = new SqlParameter("@Flight_Name", obj.FlightName);
            prm[2] = new SqlParameter("@Departure_Time", obj.DepartureTime);
            prm[3] = new SqlParameter("@Travel_Duration", obj.TravelDuration);
            prm[4] = new SqlParameter("@Source", obj.Source);
            prm[5] = new SqlParameter("@Destination", obj.Destination);
            prm[6] = new SqlParameter("@Seat_Avalaible", obj.SeatAvalaible);
            prm[7] = new SqlParameter("@Distance", obj.Distance);
            prm[8] = new SqlParameter("@AirlineID", obj.AirlineID);
            prm[9] = new SqlParameter("@Status", obj.Status);
            prm[10] = new SqlParameter("@CreatedBy", obj.CreatedBy);
            prm[11] = new SqlParameter("@Type", obj.FlightNo > 0 ? 2 : 1);
            result = DataAccess.ExecuteQuery("SP_Flights", prm);
            return result;
        }

        public List<FlightsBL> GetAllFlights(int? Id=null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Flight_No", Id);
            prm[1] = new SqlParameter("@Type", 4);
            DataTable dt = DataAccess.GetDataTable("SP_Flights", prm);
            List<FlightsBL> list = new List<FlightsBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FlightsBL obj = new FlightsBL();
                obj.ImagePath = Convert.ToString(dt.Rows[i]["Image"]);
                obj.FlightNo = Convert.ToInt32(dt.Rows[i]["Flight_No"]);
                obj.FlightName = Convert.ToString(dt.Rows[i]["Flight_Name"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);
                obj.TravelDuration = Convert.ToDouble(dt.Rows[i]["Travel_Duration"]);
                obj.Source = Convert.ToString(dt.Rows[i]["Source"]);
                obj.Destination = Convert.ToString(dt.Rows[i]["Destination"]);
                obj.Distance = Convert.ToString(dt.Rows[i]["Distance"]);
                obj.DepartureTime = Convert.ToDateTime(dt.Rows[i]["Departure_Time"]);
                obj.ArrivalTime = obj.DepartureTime;
                obj.ArrivalTime=obj.DepartureTime.AddHours(obj.TravelDuration);

                list.Add(obj);
            }
            return list;
        }

        public FlightsBL GetSpecific(int Id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Flight_No", Id);
            prm[1] = new SqlParameter("@Type", 4);
            DataTable dt = DataAccess.GetDataTable("SP_Flights", prm);
            FlightsBL obj = new FlightsBL();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                obj.ImagePath = Convert.ToString(dt.Rows[i]["Image"]);
                obj.FlightNo = Convert.ToInt32(dt.Rows[i]["Flight_No"]);
                obj.FlightName = Convert.ToString(dt.Rows[i]["Flight_Name"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);
                obj.TravelDuration = Convert.ToDouble(dt.Rows[i]["Travel_Duration"]);
                obj.Source = Convert.ToString(dt.Rows[i]["Source"]);
                obj.Destination = Convert.ToString(dt.Rows[i]["Destination"]);
                obj.Distance = Convert.ToString(dt.Rows[i]["Distance"]);
                obj.DepartureTime = Convert.ToDateTime(dt.Rows[i]["Departure_Time"]);
                obj.ArrivalTime = obj.DepartureTime;
                obj.ArrivalTime = obj.DepartureTime.AddHours(obj.TravelDuration);

            }
            return obj;
        }

        public void Delete(int ID)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Flight_No", ID);
            prm[1] = new SqlParameter("@Type", 3);
            DataAccess.ExecuteQuery("SP_Flights", prm);
        }
    }
}
