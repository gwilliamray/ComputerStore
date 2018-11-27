using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompStore.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string  Description { get; set; }
        public decimal Cost { get; set; }
        public decimal ListPrice { get; set; }
        public string PartImage { get; set; }


    }
}