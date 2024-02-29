using System;

class Website
{
    private string siteName;
    private string sitePath;
    private string siteDescription;
    private string ipAddress;

    public void SetSiteName(string name)
    {
        siteName = name;
    }

    public string GetSiteName()
    {
        return siteName;
    }

    public void SetSitePath(string path)
    {
        sitePath = path;
    }

    public string GetSitePath()
    {
        return sitePath;
    }

    public void SetSiteDescription(string description)
    {
        siteDescription = description;
    }

    public string GetSiteDescription()
    {
        return siteDescription;
    }

    public void SetIpAddress(string ip)
    {
        ipAddress = ip;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void InputWebsiteData()
    {
        Console.WriteLine("Enter website details:");
        Console.Write("Site Name: ");
        siteName = Console.ReadLine();
        Console.Write("Site Path: ");
        sitePath = Console.ReadLine();
        Console.Write("Site Description: ");
        siteDescription = Console.ReadLine();
        Console.Write("IP Address: ");
        ipAddress = Console.ReadLine();
    }

    public void DisplayWebsiteData()
    {
        Console.WriteLine("Website Details:");
        Console.WriteLine($"Site Name: {siteName}");
        Console.WriteLine($"Site Path: {sitePath}");
        Console.WriteLine($"Site Description: {siteDescription}");
        Console.WriteLine($"IP Address: {ipAddress}");
    }
}

class Program
{
    static void Main()
    {
        Website website = new Website();
        website.InputWebsiteData();
        Console.WriteLine();
        website.DisplayWebsiteData();
    }
}
