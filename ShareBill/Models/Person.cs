namespace ShareBill.Models;

public class Person
{
    public string Name { get; set; } = string.Empty;
    public bool IsPayer { get; set; } = true;
    public bool IsOwner { get; set; } = true;
}