using System.Configuration;

Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("COnnectionStr1", "SomeConnectionString"));
config.Save();

ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;

if (section.SectionInformation.IsProtected)
{
    // Seksiyanı deşirləmək
    section.SectionInformation.UnprotectSection();
}
else
{
    // Seksiyanı şifirləmək.
    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
}

// Konfiqurasiya faylını yadda saxlamaq.
config.Save();

// Şifrləmənin yoxlanılması
Console.WriteLine("Protected={0}", section.SectionInformation.IsProtected);

Console.WriteLine(ConfigurationManager.ConnectionStrings["COnnectionStr1"].ConnectionString);

Console.ReadKey();