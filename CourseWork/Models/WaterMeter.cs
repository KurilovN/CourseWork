using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
namespace CourseWork.Models
{
    public class WaterMeter
    { //Id отзыва о тренажерном зале
        [Key, Column(Order = 1)]
        public string WaterMeterNumber { get; set; }
        [Key, Column(Order = 2)]
        public int MarkId { get; set; }

        [Key, Column(Order = 3)]
        public int TypeId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        [Display(Name = "Дата начала действия счетчика")]
        public DateTime StartDate { get; set; }

    }
}