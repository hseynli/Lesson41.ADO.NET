using Microsoft.Data.SqlClient;

string conStr = @"Data Source=.;Initial Catalog=EvoCoding;Integrated Security=True;TrustServerCertificate=True;Pooling = true"; 
// Bu qoşulma üçün pulu aktiv və ya deaktiv etmək

DateTime start = DateTime.Now;

for (int i = 0; i < 1000; i++)
{
    SqlConnection connection = new SqlConnection(conStr);
    connection.Open();    // Pul aktiv olanda fiziki qoşulma yaranmır, həmin qoşulma connection pool-dan götürülür
    connection.Close();   // Pul aktiv olanda qoşulma qırılmır, o, pula əlavə edilir
}

TimeSpan stop = DateTime.Now - start;

Console.WriteLine(stop.TotalSeconds);