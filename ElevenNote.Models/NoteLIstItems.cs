﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElevenNote.WebMVC.Models
{
    public class NoteListItems
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        [UIHint("Starred")]
        [Display(Name = "Important")]
        public bool IsStarred { get; set; }
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}