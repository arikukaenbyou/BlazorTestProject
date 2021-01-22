using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrebasiewiczCompanyServer.Models
{
    public class DisplayEmployeeModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Imię jest za długie.")]
        [MinLength(3, ErrorMessage = "Imię jest za krótkie.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Nazwisko jest za długie.")]
        [MinLength(3, ErrorMessage = "Nazwisko jest za krótkie.")]
        public string Surname { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Nazwa staniowiska jest za długa.")]
        [MinLength(3, ErrorMessage = "Nazwa staniowiska jest za krótka.")]
        public string EmployeeType { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Nazwa regionu jest za długa.")]
        [MinLength(3, ErrorMessage = "Nazwa regionu jest za krótka.")]
        public string WorkLocation { get; set; }


    }
}
