using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true;"; // создание строки подключения

Console.WriteLine("Enter ID:");

var customerNo = Console.ReadLine();

string commandStr = string.Format("SELECT * FROM TestTable WHERE Id = {0};", customerNo);

using (SqlConnection connection = new SqlConnection(conStr)) //
{
    connection.Open();

    SqlCommand cmd = new SqlCommand(commandStr, connection);

    using (SqlDataReader reader = cmd.ExecuteReader())
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
                Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);
            Console.WriteLine(new string('-', 20));
        }
    }
}