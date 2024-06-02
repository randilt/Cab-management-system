using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CabManagementGUI
{
    internal class Car
    {
        // Private fields
        private int _carId;
        private string _model;
        private string _plateNumber;
        private bool _availability;

        // Public properties with encapsulation
        public int CarId
        {
            get { return _carId; }
            set { _carId = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string PlateNumber
        {
            get { return _plateNumber; }
            set { _plateNumber = value; }
        }

        public bool Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }

        // Constructor
        public Car(string model, string plateNumber, bool availability)
        {
            _model = model;
            _plateNumber = plateNumber;
            _availability = availability;
        }

        // Method to get car details
        public string GetDetails()
        {
            return $"Model: {Model}\nPlate Number: {PlateNumber}\nAvailability: {Availability}";
        }

       
        
    }
}
