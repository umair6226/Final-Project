using DataAccess_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Airline_Reservation.Controllers
{
    public class ClassBL
    {
        public int ClassID { get; set; }

        [Required(ErrorMessage ="Please Enter Fare for this class")]
        public double Fare { get; set; }

        [Required(ErrorMessage = "Enter Class Type")]

        public string Class_Type { get; set; }

        [Required(ErrorMessage = "Select Status")]

        public int Status { get; set; }

        [Required(ErrorMessage = "Select Airline")]
        public int AirlineID { get; set; }
        public int CreatedBy { get; set; }
        public string AirlineName { get; set; }
        public string Image { get; set; }

        public int Save(ClassBL obj)
        {
            int result = 0;
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@ClassID", obj.ClassID);
            prm[1] = new SqlParameter("@Class_Type", obj.Class_Type);
            prm[2] = new SqlParameter("@AirlineID", obj.AirlineID);
            prm[3] = new SqlParameter("@Fare", obj.Fare);
            prm[4] = new SqlParameter("@Status", obj.Status);
            prm[5] = new SqlParameter("@CreatedBy", obj.CreatedBy);
            prm[6] = new SqlParameter("@Type", obj.ClassID > 0 ? 2 : 1);
            result = DataAccess.ExecuteQuery("SP_Class", prm);
            return result;
        }

        public List<ClassBL> GetAllClasses(int? Id = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@ClassID", Id);
            prm[1] = new SqlParameter("@Type", 4);
            DataTable dt = DataAccess.GetDataTable("SP_Class", prm);
            List<ClassBL> list = new List<ClassBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClassBL obj = new ClassBL();
                obj.ClassID = Convert.ToInt32(dt.Rows[i]["ClassID"]);
                obj.Fare = Convert.ToInt32(dt.Rows[i]["Fare"]);
                obj.Class_Type = Convert.ToString(dt.Rows[i]["Class_Type"]);
                obj.Status = Convert.ToInt32(dt.Rows[i]["Status"]);
                obj.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);
                obj.Image = Convert.ToString(dt.Rows[i]["Image"]);
                list.Add(obj);
            }
            return list;
        }

    }
}
