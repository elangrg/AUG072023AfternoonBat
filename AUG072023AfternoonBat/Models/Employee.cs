using AUG072023AfternoonBat.Infra;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AUG072023AfternoonBat.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }


    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name = "Name of The Project")]
        [Remote(action: "ProjectNameTaken", controller: "ValidationEg")]

        public string ProjectName { get; set; }
        [Required]
        [MustContainPrjType]
        [Display(Name = "Project Description")]
        public string PrjDesc { get; set; }

    }






}
