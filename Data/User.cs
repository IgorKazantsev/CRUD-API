public class User
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty; // Инициализация строкового свойства пустой строкой
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}
