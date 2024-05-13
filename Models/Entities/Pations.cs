using System.ComponentModel.DataAnnotations;

public class Pations
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string Family { get; set; }

   [Required]
   [MaxLength(10),MinLength(10)]
    public string Nationalcode { get; set; }
}