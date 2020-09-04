using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SemestralkaDataControl.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(500)]
        public string Text { get; set; }
        public DateTime DateTimeOfCreation { get; set; }
#nullable enable
        public string? FileName { get; set; }
        [NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile? File { get; set; }
#nullable disable
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
