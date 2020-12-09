using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_API_Project.Models
{
    public class Car
    {
        [Key]      // Key Attribute for Primary key of the table

        public int Car_ID { get; set; }         // Inteager datatype for Car ID
        public string Car_Name { get; set; }    //String datatype for Car Name 
        public string Car_Make { get; set; }    // String For Car Make
        public int Car_Date { get; set; }       // Inteager For car Date 
        public string Car_Price { get; set; }   // String for Car Price
    }
}
