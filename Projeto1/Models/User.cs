


namespace Projeto1.Models{

[Table("User")]
public class User 
{
    [Key]
    public int Id { get; set; } 

    public string Name { get; set; } 

    public string Email { get; set; } 

    public string Categoria { get; set; } 
}

}