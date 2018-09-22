using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_ANGULAR.Models.Address
{
  [Table("City")]
  public class City
  {
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set;}
  }
}
