using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrebasiewiczCompanyServer.Models
{
    public class DeleteEmployeeModel
    {
        [Required]
        [Range(1, 100000, ErrorMessage = "Indeks poza zakresem.")]
        public string Id { get; set; }
    }
}
