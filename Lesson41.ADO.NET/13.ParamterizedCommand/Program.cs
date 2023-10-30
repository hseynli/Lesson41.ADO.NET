using Microsoft.Data.SqlClient;

var conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true;"; 

var commandStr = "SELECT * FROM TestTable WHERE Id = @Id;";  

Console.WriteLine("Enter customer ID");
var customerNo = Console.ReadLine(); //

SqlConnection connection = new SqlConnection(conStr);
SqlCommand cmd = new SqlCommand(commandStr, connection);

cmd.Parameters.AddWithValue("Id", customerNo);   // Paramterin komandanın paramter kolleksiyasına əlavə edilməsi
connection.Open();

SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    for (int i = 0; i < reader.FieldCount; i++)
        Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);

    Console.WriteLine(new string('-', 20));
}

reader.Close();
connection.Close();