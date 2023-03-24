using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseWork.Models
{
    public class TypesWaterMeters
    {

        [Key, Column(Order = 1)]
        public int TypeId { get; set; }
        [Display(Name = "Тип счетчика")]
        public string NameType { get; set; }

        public ICollection<WaterMeter> WaterMeters { get; set; }
        public TypesWaterMeters()
        {
            WaterMeters = new List<WaterMeter>();
        }
    }
}