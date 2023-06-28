using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh2002.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public string ID { get; set; }
        public string FullName { get; set; }
    }
}