using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using apiTask.Models;
using System.Data.Entity;



namespace apiTask
{
    using System;
using System.Data.Entity;

public class DatabaseContext : DbContext
{
    public DatabaseContext() : base("Data Source=sql.bsite.net\\MSSQL2016;Initial Catalog=nunermien_303;User ID=nunermien_303;Password=Nu@654321;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
)
        {
    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<PatientRecord> PatientRecords { get; set; }
}


}
