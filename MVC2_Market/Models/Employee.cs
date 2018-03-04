using System;
using System.ComponentModel.DataAnnotations;

namespace MVC2_Market.Models
{
    //Esta clase tiene la relacion (n), la clase DocumentType es el (1)
    public class Employee
    {
        [Key]
        public int EmployeeId {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public float Bonus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StartTime { get; set; }
        public string Email { get; set; }

        //Para crear las relacionas (1:n) se crean el/los campos con el mismo nombre que son [Key] en la
        //tabla relacionada(tipo : 1), este campo viene a ser la fk
        public int DocumentTypeId { get; set; }

        //Ademas se crea un objeto el cual referencia el lado (1:) de la aplicacion, en este caso es 
        //DocumentType
        public virtual DocumentType DocumentType { get; set; }

    }
}