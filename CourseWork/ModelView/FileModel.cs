using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.IO;

namespace CourseWork.Models
{
    public class FileModel
    {
        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase PostedFile { get; set; }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Серийный номер счетчика")]
        public int? WaterMeterNumber { get; set; }

        [Display(Name = "Лицевой счет")]
        public int? PersonalAccount { get; set; }

        [Display(Name = "Дата снятия показания")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        public DateTime TransmissionDate { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        [Display(Name = "Дата начала действия счетчика")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Название марки счетчика")]
        public string NameMark { get; set; }
        [Display(Name = "Тип счетчика")]

        public string NameType { get; set; }
        [Display(Name = "Комментарий")]

        public string Comment { get; set; }
        [Display(Name = "Показание")]

        public int? Value { get; set; }
    }
}