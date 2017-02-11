using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleNote.Models
{
    public class Note
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        // relationships 
        // each note has a user Id
        public Guid UserId { get; set; }
    }
}