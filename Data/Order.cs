public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; } = new User(); // Инициализация ссылочного свойства новым объектом
}
