﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
    }
}