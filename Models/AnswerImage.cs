using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class AnswerImage
    {
        public int AnswerImageID
        {
            get;
            set;
        }

        [Required]
        [Display(Name = "File Name")]
        public string FileName
        {
            get;
            set;
        }


        [Required]
        [Url]
        public string Url
        {
            get;
            set;
        }
    }
}
