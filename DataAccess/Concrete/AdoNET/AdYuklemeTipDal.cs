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
    public class AdYuklemeTipDal : IYuklemeTipDal
    {
        public List<YuklemeTip> YuklemeTipListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.YuklemeTipleri", Connection.sqlConn);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<YuklemeTip> YuklemeTipleri = new List<YuklemeTip>();
                    YuklemeTipleri.Add(new YuklemeTip { Id = 0, YuklemeTipAd = "Yukleme Şekli Seç.." });
                    while (dataReader.Read())
                    {
                        YuklemeTipleri.Add(
                        new YuklemeTip
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            YuklemeTipAd = dataReader["YuklemeTip"].ToString(),

                        });
                    }
                    return YuklemeTipleri;
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
