using Microsoft.Data.SqlClient;
using System.Data;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 
SqlConnection connection = new SqlConnection(conStr);

SqlCommand cmd = new SqlCommand("SET @Parameter = 2;", connection);

SqlParameter parameter = cmd.Parameters.Add(new SqlParameter("Parameter", SqlDbType.Int));
parameter.Direction = ParameterDirection.Output; // Parametrin istiqamətini göstərmək

connection.Open();

cmd.ExecuteNonQuery();

Console.WriteLine("Parameter value: " + parameter.Value);

connection.Close();