using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC2_Market.Models
{
    public class DocumentType
    {
        [Key]
        public int DocumentTypeId { get; set; }
        public string Description { get; set; }

        //En el lado (1:) se declara una lista del tipo Employee(el tipo :n)
        public virtual ICollection<Employee> Employees { get; set; }
    }
}