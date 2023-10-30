using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true;"; 

SqlConnection connection = new SqlConnection(conStr); 
connection.Open();

// INSERT command

SqlCommand insertCommand = connection.CreateCommand(); // Məlumat əlavə etmək üçün komandanın yaradılması
insertCommand.CommandText = "insert TestTable values ('Test 100', getdate());";

int rowAffected = insertCommand.ExecuteNonQuery(); // Əlavəetmə komandasının icra edilməsi
Console.WriteLine("INSERT command rows affected: " + rowAffected);

// DELETE command

SqlCommand deleteCommand = connection.CreateCommand(); // Silinmə komandasının yaradılması
deleteCommand.CommandText = "delete from TestTable where id = 3;";

rowAffected = deleteCommand.ExecuteNonQuery(); // Silinmə əməliyyatının yaradılmasə
Console.WriteLine("DELETE command rows affected: " + rowAffected);