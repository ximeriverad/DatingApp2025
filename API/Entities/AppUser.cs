namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString(); //el uso de NewGuid es por seguridad y para no permitir nulls
    public required string DisplayName { get; set; } //? acepta nulos y opcionales
    public required string Email { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
