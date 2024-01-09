using System.ComponentModel.DataAnnotations;
public class User
{
    public int? Id { get; set;}  //свойства

    // [Required]
    // [DataType(DataType.Text)]
    public string? name { get; set;}

    // [Required]
    // [DataType(DataType.PhoneNumber)]
    // [MaxLength(12)]
    public int PhoneNumber { get; set;}

    // [Required]
    // [DataType(DataType.Text)]
    public string FirstName{ get; set;}

    // [Required]
    // [DataType(DataType.Text)]
    public string LastName { get; set;}

    // [Required]
    // [DataType(DataType.Password)]
    public string Password { get; set;}


    public string Mail { get; set;}

}