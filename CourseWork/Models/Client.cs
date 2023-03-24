using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CourseWork.Models
{
    public class Client
    {
        //ФИО клиента в формате Фамилия И.О.

        [Key, Column(Order = 1)]
        [Display(Name = "Лицевой счет")]
        public string PersonalAccount { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Display(Name = "ФИО")]
        public string FIO { get; set; }
    }
}