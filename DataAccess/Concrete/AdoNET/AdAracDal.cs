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
    public class AdAracDal:IAracDal
    {
        

        List<Arac> IAracDal.SevkAracListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.SevkAraclari", Connection.sqlConn);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Arac> SevkAraclari = new List<Arac>();
                    SevkAraclari.Add(new Arac { Id = 0, AracAd = "Sevk Aracı Seç.." });
                    while (dataReader.Read())
                    {
                        SevkAraclari.Add(
                        new Arac
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            AracAd = dataReader["sevkAraci"].ToString(),

                        });
                    }
                    return SevkAraclari;
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
