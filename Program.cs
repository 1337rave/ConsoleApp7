using System;

class Shop
{
    private string shopName;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string email;

    public void SetShopName(string name)
    {
        shopName = name;
    }

    public string GetShopName()
    {
        return shopName;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetProfileDescription(string description)
    {
        profileDescription = description;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public void SetContactPhone(string phone)
    {
        contactPhone = phone;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputShopData()
    {
        Console.WriteLine("Enter shop details:");
        Console.Write("Shop Name: ");
        shopName = Console.ReadLine();
        Console.Write("Address: ");
        address = Console.ReadLine();
        Console.Write("Profile Description: ");
        profileDescription = Console.ReadLine();
        Console.Write("Contact Phone: ");
        contactPhone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void DisplayShopData()
    {
        Console.WriteLine("Shop Details:");
        Console.WriteLine($"Shop Name: {shopName}");
        Console.WriteLine($"Address: {address}");
        Console.WriteLine($"Profile Description: {profileDescription}");
        Console.WriteLine($"Contact Phone: {contactPhone}");
        Console.WriteLine($"Email: {email}");
    }
}

class Program
{
    static void Main()
    {
        Shop shop = new Shop();
        shop.InputShopData();
        Console.WriteLine();
        shop.DisplayShopData();
    }
}
