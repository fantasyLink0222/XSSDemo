using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XSSDemo.ViewModels
{
    public class FeedbackVM
    {

        [StringLength(250, ErrorMessage = "The comment cannot exceed 250 characters.")]
        public string Comment { get; set; }
    }
}