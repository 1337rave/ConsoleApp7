using System;

class Journal
{
    private string journalName;
    private int foundingYear;
    private string journalDescription;
    private string contactPhone;
    private string email;

    public void SetJournalName(string name)
    {
        journalName = name;
    }

    public string GetJournalName()
    {
        return journalName;
    }

    public void SetFoundingYear(int year)
    {
        foundingYear = year;
    }

    public int GetFoundingYear()
    {
        return foundingYear;
    }

    public void SetJournalDescription(string description)
    {
        journalDescription = description;
    }

    public string GetJournalDescription()
    {
        return journalDescription;
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

    public void InputJournalData()
    {
        Console.WriteLine("Enter journal details:");
        Console.Write("Journal Name: ");
        journalName = Console.ReadLine();
        Console.Write("Founding Year: ");
        foundingYear = Convert.ToInt32(Console.ReadLine());
        Console.Write("Journal Description: ");
        journalDescription = Console.ReadLine();
        Console.Write("Contact Phone: ");
        contactPhone = Console.ReadLine();
        Console.Write("Email: ");
        email = Console.ReadLine();
    }

    public void DisplayJournalData()
    {
        Console.WriteLine("Journal Details:");
        Console.WriteLine($"Journal Name: {journalName}");
        Console.WriteLine($"Founding Year: {foundingYear}");
        Console.WriteLine($"Journal Description: {journalDescription}");
        Console.WriteLine($"Contact Phone: {contactPhone}");
        Console.WriteLine($"Email: {email}");
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        journal.InputJournalData();
        Console.WriteLine();
        journal.DisplayJournalData();
    }
}
