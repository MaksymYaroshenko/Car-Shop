using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Input the Name")]
        [StringLength(5)]
        [Required(ErrorMessage = "The field shouldn't be emty")]
        public string Name { get; set; }

        [Display(Name = "Input the Surname")]
        [StringLength(25)]
        [Required(ErrorMessage = "The field shouldn't be emty")]
        public string Surname { get; set; }

        [Display(Name = "Input the Adress")]
        [StringLength(50)]
        [Required(ErrorMessage = "The field shouldn't be emty")]
        public string Adress { get; set; }

        [Display(Name = "Input the phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        [Required(ErrorMessage = "The field shouldn't be emty")]
        public string Phone { get; set; }

        [Display(Name = "Input the E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "The field shouldn't be emty")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderList { get; set; }
    }
}
