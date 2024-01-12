using System;
namespace UrbanStyleApp.DataModel
{
    public class UrbanUsersModel
    {
       public int id { get; set; }
        public string imageUrl { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string contactNumber { get; set; }
        public int age { get; set; }
        public string dob { get; set; }
        public double salary { get; set; }
        public string address { get; set; }

        public UrbanUsersModel()
        {
        }
    }
}