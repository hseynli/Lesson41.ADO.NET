using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true;";

SqlConnection connection = new SqlConnection(conStr);
connection.Open();

SqlCommand cmd = new SqlCommand("SELECT * FROM TestTable", connection); 

SqlDataReader reader = cmd.ExecuteReader();

// GetName
while (reader.Read())
{
    Console.WriteLine(reader.GetName(2));
    Console.WriteLine(new string('_', 20));
}
reader.Close();
connection.Close();