using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrebasiewiczCompanyServer.Models
{
    public class WorkingTimeModel
    {
        [Required]
        [Range(1, 30, ErrorMessage = "Nie można tyle pracować!!.")]
        public string WorkingTimeValue { get; set; }
        [Required]
        [Range(1, 100000, ErrorMessage = "Indeks poza zakresem.")]
        public string WorkingTimeEmployeeId { get; set; }
    }
}
