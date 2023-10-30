using System.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 

SqlConnection connection = new SqlConnection(conStr);
connection.Open(); // Qoşulmanın açılması

SqlCommand cmd = new SqlCommand("select name from TestTable where id = 1", connection); // skalyar nəticə qaytaran komandanın yaradılması

string phoneNumber = (string)cmd.ExecuteScalar(); // Əmrin icra olunması

Console.WriteLine(phoneNumber);