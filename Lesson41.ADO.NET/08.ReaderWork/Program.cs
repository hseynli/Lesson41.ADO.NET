using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 

SqlConnection connection = new SqlConnection(conStr);

SqlCommand cmd = new SqlCommand("SELECT * FROM TestTable", connection); 

connection.Open();
SqlDataReader reader = cmd.ExecuteReader(); 

while (reader.Read())
{
    Console.WriteLine(reader.GetFieldValue<int>(0));
    Console.WriteLine(reader.GetString(1));
    Console.WriteLine(reader.GetDateTime(2));
    Console.WriteLine(new string('_',20));
}
reader.Close();
connection.Close();