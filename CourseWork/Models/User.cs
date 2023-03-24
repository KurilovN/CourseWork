using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;
namespace CourseWork.Models
{
    public class User : IdentityUser
    {
        //ФИО клиента в формате Фамилия И.О.
        [Display(Name = "ФИО")]
        public string Name { get; set; }
        

    }
}