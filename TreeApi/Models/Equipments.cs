using System;
using System.ComponentModel.DataAnnotations;

namespace TreeApi.Models
{
    public class Equipments
    {
        [Key]
        public int EquipmentsID {get;set;}
        [Required(ErrorMessage ="Please enter with a Equipment name it is required")]
        public string Name {get;set;}
        [MaxLength(16)][Required(ErrorMessage ="Please enter with a Equipment Serial Number it is required")]
        public string SerialNumber {get;set;}
        [Required(ErrorMessage ="Please enter with a voltage of  Equipment it is required")]
        public string Voltage { get; set; }
        [Required(ErrorMessage ="Please enter with a electric current of Equipment it is required")]
        public string ElectricCurrent {get; set;}
        [Required(ErrorMessage ="Please enter with a oil of Equipment it is required")]
        public string Oil {get; set;}
        [Required(ErrorMessage ="Please enter with an Date it is required")]
        public DateTime Date {get; set;}
        
    }
}