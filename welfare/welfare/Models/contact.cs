﻿using System.ComponentModel.DataAnnotations;

namespace welfare.Models
{
    public class contact
    {
        [Key]   
           public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
