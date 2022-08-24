﻿using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Students.Services.ViewModels
{
    [NotMapped]
    public class UpdatableStudentVM
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Email]
        public string? Email { get; set; }

    }
}
