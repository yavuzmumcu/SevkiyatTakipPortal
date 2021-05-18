using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.AdoNET
{
    public class AdDurumDal : IDurumDal
    {
        public List<Durum> Listele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.SevkiyatDurumlari", Connection.sqlConn);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Durum> SevkDurumlari = new List<Durum>();
                    
                    while (dataReader.Read())
                    {
                        SevkDurumlari.Add(
                        new Durum
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            DurumAd = dataReader["durum"].ToString(),

                        });
                    }
                    return SevkDurumlari;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Connection.sqlConn.Close();
            }
        }
    }
}
