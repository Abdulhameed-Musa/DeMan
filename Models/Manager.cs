using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AircraftManagementApp.Models
{
    public class Manager
    {
        public int Id;
        public string UserEmail;
        public string StaffNumber;
        public double Wallet;

        public Manager(int id, string userEmail, string staffNumber ,double wallet)
        {
            Id = id;
            UserEmail = userEmail;
            StaffNumber = staffNumber;
            Wallet = wallet;
        }
    }
}