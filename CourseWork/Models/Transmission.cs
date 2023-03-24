using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CourseWork.Models
{
    public class Transmission
    {
        [Key, Column(Order = 1)]
        public string Email { get; set; }
        [Display(Name = "Серийный номер счетчика")]
        [Key, Column(Order = 2)]
        public string WaterMeterNumber { get; set; }

        [Display(Name = "Лицевой счет")]
        [Key, Column(Order = 3)]

        public string PersonalAccount { get; set; }
        [Key, Column(Order = 4)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        [Display(Name = "Дата снятия показания")]
        public DateTime TransmissionDate { get; set; }
        [Display(Name = "Комментарий")]
        public string Comment { get; set; }
        [Display(Name = "Показание счетчика")]
        public string Value { get; set; }
        
    }
}