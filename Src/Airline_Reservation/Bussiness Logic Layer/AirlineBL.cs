using DataAccess_Layer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace Bussiness_Logic_Layer
{
    public class AirlineBL
    {

        public int AirlineID { get; set; }

        [Required(ErrorMessage ="Please enter Airline Name")]
        public string AirlineName { get; set; }

        [Required(ErrorMessage = "Choose an Image")]
        public IFormFile Image { get; set; }
        public string ImagePath { get; set; }
        public string CreatedBy { get; set; }

        [Required(ErrorMessage = "Select Status")]
        public int Status { get; set; }

        public int Save(AirlineBL obj)
        {
            int result = 0;
            SqlParameter[] prm = new SqlParameter[6];
            prm[0] = new SqlParameter("@AirlineID", obj.AirlineID);
            prm[1] = new SqlParameter("@Airline_Name", obj.AirlineName);
            string filePath = ImageUploadAsync(obj).GetAwaiter().GetResult();
            prm[2] = new SqlParameter("@Image", filePath);
            prm[3] = new SqlParameter("@Status", obj.Status);
            prm[4] = new SqlParameter("@CreatedBy", obj.CreatedBy);
            prm[5] = new SqlParameter("@Type", obj.AirlineID > 0 ? 2 : 1);
            result = DataAccess.ExecuteQuery("SP_Airline", prm);
            return result;
        }
        public List<AirlineBL> GetAllAirlines()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 4);
            DataTable dt = DataAccess.GetDataTable("SP_Airline", prm);
            List<AirlineBL> list = new List<AirlineBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AirlineBL obj = new AirlineBL();
                obj.AirlineID = Convert.ToInt32(dt.Rows[i]["AirlineID"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);
                obj.CreatedBy = Convert.ToString(dt.Rows[i]["CreatedBy"]);
                obj.ImagePath = Convert.ToString(dt.Rows[i]["Image"]);
                obj.Status = Convert.ToInt32(dt.Rows[i]["Status"]);

                list.Add(obj);
            }
            return list;
        }

        public List<AirlineBL> GetById(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@AirlineID", id);
            prm[1] = new SqlParameter("@Type", 5);
            DataTable dt = DataAccess.GetDataTable("SP_Airline", prm);
            List<AirlineBL> list = new List<AirlineBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AirlineBL obj = new AirlineBL();
                obj.AirlineID = Convert.ToInt32(dt.Rows[i]["AirlineID"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);
                obj.CreatedBy = Convert.ToString(dt.Rows[i]["CreatedBy"]);
                obj.ImagePath = Convert.ToString(dt.Rows[i]["Image"]);
                obj.Status = Convert.ToInt32(dt.Rows[i]["Status"]);

                list.Add(obj);
            }
            return list;
        }
        public void Delete(int AirlineID)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@AirlineID", AirlineID);
            prm[1] = new SqlParameter("@Type", 3);
            DataAccess.ExecuteQuery("SP_Airline", prm);
        }


        public List<AirlineBL> GetForDropDown()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@Type", 6);
            DataTable dt = DataAccess.GetDataTable("SP_Airline", prm);
            List<AirlineBL> list = new List<AirlineBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                AirlineBL obj = new AirlineBL();
                obj.AirlineID = Convert.ToInt32(dt.Rows[i]["AirlineID"]);
                obj.AirlineName = Convert.ToString(dt.Rows[i]["Airline_Name"]);

                list.Add(obj);
            }
            return list;
        }
        public async Task<string> ImageUploadAsync(AirlineBL obj)
        {
            try
            {
                if (obj.Image != null)
                {

                        var fileName = Path.GetFileName(obj.Image.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/assets/imgs", fileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await obj.Image.CopyToAsync(fileStream);
                        }

                    return @"~/assets/imgs/" + fileName;
                }
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
