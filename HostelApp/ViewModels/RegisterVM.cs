using HostelApp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HostelApp.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        public int StudentTicketNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string IDCardNumber { get; set; }

        public string Image { get; set; }

        public int SelectedUniversity { get; set; }
        public IEnumerable<University> Universities { get; set; }

        [Required]
        public int SelectedFaculty { get; set; }
        public IEnumerable<Faculty> Faculties { get; set; }

        [Required]
        public int SelectedGroup { get; set; }
        public IEnumerable<HostelApp.Models.Group> Groups { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
