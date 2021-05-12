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
    public class AdMusteriDal:IMusteriDal
    {
        public List<Musteri> MusteriListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM siparisTakip.Musteriler", Connection.sqlConn);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Musteri> Musteriler = new List<Musteri>();
                    Musteriler.Add(new Musteri { Id = 0, MusteriAd = "Müşteri Seç.." });
                    while (dataReader.Read())
                    {
                        Musteriler.Add(
                        new Musteri
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            MusteriAd = dataReader["MusteriAd"].ToString(),
                            MusteriTip = dataReader["MusteriTip"].ToString(),
                            Ulke = dataReader["Ulke"].ToString(),
                            Sehir = dataReader["Sehir"].ToString()


                        });
                    }
                    return Musteriler;
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
