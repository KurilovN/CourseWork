using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace CourseWork.Models
{
    public class Filter
    {
        public string Email { get; set; }
        [Display(Name = "Серийный номер счетчика")]
        public string WaterMeterNumber { get; set; }

        [Display(Name = "Лицевой счет")]

        public string PersonalAccount { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        [Display(Name = "Дата снятия показания")]
        public DateTime TransmissionDate { get; set; }
        [Display(Name = "Комментарий")]
        public string Comment { get; set; }
        [Display(Name = "Показание счетчика")]
        public string Value { get; set; }
        public SelectList Years { get; set; }
        public SelectList Months { get; set; }
        public ICollection<Transmission> Transmissions { get; set; }
    }
}