using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AircraftManagementApp.Data;
using AircraftManagementApp.Enums;
using AircraftManagementApp.Managers.Interfaces;
using AircraftManagementApp.Models;

namespace AircraftManagementApp.Managers.Implementations
{
    public class PassengerManager : IPassengerInterface
    {
        List<Passenger> passengerDb = Database.PassengerDb;
        public bool Delete(string email)
        {
            var passenger = Get(email);
            if (passenger != null)
            {
                passengerDb.Remove(passenger);
                return true;
            }
            return false;
        }

        public Passenger Get(string email)
        {
            foreach (var passenger in passengerDb)
            {
                if (passenger.UserEmail == email)
                {
                    return passenger;
                }
            }
            return null;
        }

        public List<Passenger> GetAll()
        {
            return passengerDb;
        }

        public Passenger Register(string name, string userEmail, string password, string address, string phoneNumber, Gender gender)
        {
            throw new NotImplementedException();
        }

        public Passenger Update(string email)
        {
            throw new NotImplementedException();
        }

        private bool Check(string email)
        {
            foreach (var passenger in passengerDb)
            {
                if (passenger.UserEmail == email)
                {
                    return false;
                }
            }
            return true;
        }
    }
}