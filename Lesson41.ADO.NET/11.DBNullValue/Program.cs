using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 

SqlConnection connection = new SqlConnection(conStr); 
connection.Open();

SqlCommand cmd = new SqlCommand("select * from TestTable;", connection);  

SqlDataReader reader = cmd.ExecuteReader();

while (reader.Read())
{
    //Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetDateTime(2));

    //if (reader[5] == DBNull.Value) // İcra olunma zamanı baş verən xəta
    if (reader.IsDBNull(1)) // IsDbNull metodu verilənlər bazasında olan cədvəldəki məlumatın null olub-olmamasını yoxlamaq üçün istifafə olunur
        Console.WriteLine("No Data");
    else
        Console.WriteLine("Name: " + reader[1]);

    Console.WriteLine();
}