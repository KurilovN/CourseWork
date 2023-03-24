using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseWork.Models
{
    public class TransmissionView
    {
        [Required(ErrorMessage = "Укажите файл.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Только фотографии.")]
        public HttpPostedFileBase PostedFile { get; set; }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Серийный номер счетчика")]
        public string WaterMeterNumber { get; set; }

        [Display(Name = "Лицевой счет")]
        public string  PersonalAccount { get; set; }

        [Display(Name = "Дата снятия показания")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        public DateTime TransmissionDate { get; set; }

        [Display(Name = "Адрес")]
        [Range(150, 250)]
        public string Adress { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-M-yyyy}")]
        [Display(Name = "Дата истекания действия счетчика")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Название марки счетчика")]
        public string NameMark { get; set; }
        [Display(Name = "Тип счетчика")]

        public string NameType { get; set; }
        [Display(Name = "Комментарий")]

        public string Comment { get; set; }
        [Display(Name = "Показание")]

        public string Value { get; set; }
    }
}