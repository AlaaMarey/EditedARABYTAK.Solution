﻿using System.ComponentModel.DataAnnotations;

namespace ARABYTAK.APIS.DTOs
{
    public class loginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
