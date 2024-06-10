using EmployeesContext_Galkin.Classes;
using EmployeesContext_Galkin.Modell;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Text;

namespace EmployeesContext_Galkin.Context
{
    public class CategorysContext : Categorys
    {
        public static ObservableCollection<CategorysContext> AllCategorys()
        {
            ObservableCollection<CategorysContext> allCategorys = new ObservableCollection<CategorysContext>();
            SqlConnection connection;
            SqlDataReader dataCategorys = Connection.Query("SELECT * FROM [dbo].[Otdeli]", out connection);
            while (dataCategorys.Read())
            {
                allCategorys.Add(new CategorysContext()
                {
                    Id = dataCategorys.GetInt32(0),
                    Otdel = dataCategorys.GetString(1)
                });
            }
            Connection.CloseConnection(connection);
            return allCategorys;
        }
    }
}
