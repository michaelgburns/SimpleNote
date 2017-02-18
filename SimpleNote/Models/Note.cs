using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleNote.Models
{
    public class Note
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        [UIHint("Body")]
        public string Body { get; set; }

        [Display(Name = "Created date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Updated date")]
        public DateTime? UpdatedDate { get; set; }

        // relationships 
        // each note has a user Id
        public Guid UserId { get; set; }
    }
}