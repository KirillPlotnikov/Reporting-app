using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SemestralkaDataControl.Models
{
    public class Question
    {

        [Key]
        public int Id { get; set; }
        [Required, MaxLength(500)]
        public string Text { get; set; }
        public DateTime DateTimeOfCreation { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
#nullable enable
        public string? FileName { get; set; }
        [NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile? File { get; set; }
#nullable disable
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Answer Answer { get; set; }
    }
}
