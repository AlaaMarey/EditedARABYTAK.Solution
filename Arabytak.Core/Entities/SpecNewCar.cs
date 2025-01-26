﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabytak.Core.Entities
{
    public class SpecNewCar:BaseEntity
    {
      //  public decimal EngineCapacity { get; set; }
        public int Gears { get; set; }
        public int Year { get; set; }
        //public int Horsepower { get; set; }
        public decimal FuelEfficiency { get; set; }
        public int TopSpeed { get; set; }
        public string OriginCountry { get; set; }
        public string AssemblyCountry { get; set; }
        public decimal Acceleration { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal GroundClearance { get; set; }
        public decimal Wheelbase { get; set; }
        public decimal TrunkSize { get; set; }
        public int Seats { get; set; }
        public string Drivetrain { get; set; }

        public string Fuel { get; set; }
        public int HorsePower { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        
       
    }
}
