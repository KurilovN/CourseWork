using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseWork.Models
{
    public class MarkWaterMeter
    {
        //ФИО клиента в формате Фамилия И.О.
        [Key, Column(Order = 1)]
        public int MarkId { get; set; }

        [Display(Name = "Марка счетчика")]
        public string NameMark { get; set; }
        public ICollection<WaterMeter> WaterMeters { get; set; }
        public MarkWaterMeter()
        {
            WaterMeters = new List<WaterMeter>();
        }
    }
}