﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Add this if overloading
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] //by adding this in here you are overwriting the defaults for the column below
        [StringLength(255)]

        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }


        [Display(Name="Membership Type")]
        public MembershipType MembershipType { get; set; } //navigation property

        public byte GenereId{ get; set; } //This is the foreign key

        //You can prefix a column with
        //[Display(Name="What ever you want it to display as")]
        public DateTime? BirthDate { get; set; }
    }
}