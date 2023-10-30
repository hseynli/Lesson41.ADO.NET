using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true";

SqlConnection connection = new SqlConnection(conStr); // Qoşulma yaradırıq
connection.Open();

SqlCommand cmd = new SqlCommand("SELECT * FROM TestTable", connection); 

// ExecuteReader metodu SqlDataReader tipli yeni obyekt qaytarır
using (SqlDataReader reader = cmd.ExecuteReader())
{
    while (reader.Read())
    {
        Console.Write(reader[0] + " ");                          
        Console.WriteLine(
            reader[1] + " " +
            reader[2]
            );

        Console.WriteLine(new string('_', 20));
    }
} // using blokundan çıxan kimi reader avtomatik olaraq bağlanacaq
connection.Close();