﻿using DataAccess_Layer;
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

        [Required(ErrorMessage = "Select Class Type")]

        public string Class_Type { get; set; }

        [Required(ErrorMessage = "Select Status")]

        public int Status { get; set; }
        public int CreatedBy { get; set; }

        public int Save(ClassBL obj)
        {
            int result = 0;
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@ClassID", obj.ClassID);
            prm[1] = new SqlParameter("@Fare", obj.Fare);
            prm[2] = new SqlParameter("@Status", obj.Status);
            prm[3] = new SqlParameter("@CreatedBy", obj.CreatedBy);
            prm[4] = new SqlParameter("@Type", obj.ClassID > 0 ? 2 : 1);
            result = DataAccess.ExecuteQuery("SP_Class", prm);
            return result;
        }

        public List<ClassBL> GetAllClasses(int? Id = null)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@Flight_No", Id);
            prm[1] = new SqlParameter("@Type", 4);
            DataTable dt = DataAccess.GetDataTable("SP_Flights", prm);
            List<ClassBL> list = new List<ClassBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ClassBL obj = new ClassBL();
                obj.ClassID = Convert.ToInt32(dt.Rows[i]["ClassID"]);
                obj.Fare = Convert.ToInt32(dt.Rows[i]["Fare"]);
                obj.Class_Type = Convert.ToString(dt.Rows[i]["Class_Type"]);
                obj.Status = Convert.ToInt32(dt.Rows[i]["Status"]);
                obj.CreatedBy = Convert.ToInt32(dt.Rows[i]["CreatedBy"]);
                list.Add(obj);
            }
            return list;
        }

    }
}