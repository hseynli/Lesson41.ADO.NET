using Microsoft.Data.SqlClient;

// connection string
string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 

SqlConnection connection = new SqlConnection(conStr); // Qoşulmanın yaradılması
connection.Open();

SqlCommand cmd = new SqlCommand("SELECT * FROM TestTable WHERE Id = 10; SELECT * FROM TestTable WHERE Id = 11;", connection);  // Sorğular paketinin yaradılması
SqlDataReader reader = cmd.ExecuteReader();

Console.WriteLine("press any key to see data from TestTable");
Console.ReadKey();

WriteReaderData(reader);  // Məlumatların ekrana çıxarılması

Console.WriteLine("press any key to see data from TestTable");
Console.ReadKey();

reader.NextResult();      // Növbəti sorğuya getmək  

WriteReaderData(reader);  // Məlumatların ekrana çıxarılması

connection.Close();
reader.Close();           // reader obyektini bağlamağı unutmayın
Console.ReadKey();


static void WriteReaderData(SqlDataReader reader)
{
    while (reader.Read())
    {
        for (int i = 0; i < reader.FieldCount; i++)
            Console.WriteLine(reader.GetName(i) + ": " + reader[i]);
        Console.WriteLine(new string('_', 20));
    }
}