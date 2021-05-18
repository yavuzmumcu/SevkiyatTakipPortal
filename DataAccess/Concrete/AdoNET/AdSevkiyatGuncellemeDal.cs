using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.AdoNET
{
    public class AdSevkiyatGuncellemeDal : ISevkiyatGuncellemeDal
    {
        public int Ekle(SevkiyatGuncelleme sevkiyatGuncelleme)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO SevkiyatTakip.SevkiyatGuncellemeleri (SevkiyatId,durumId,Aciklama) " +
                "VALUES(@SevkiyatId,@durumId,@Aciklama) ", Connection.sqlConn))
            {
                command.Parameters.AddWithValue("@SevkiyatId", sevkiyatGuncelleme.SevkiyatId);
                command.Parameters.AddWithValue("@durumId", sevkiyatGuncelleme.DurumId);
                command.Parameters.AddWithValue("@Aciklama", sevkiyatGuncelleme.Aciklama);
                

                Connection.OpenConnection();

                int result = command.ExecuteNonQuery();

                Connection.sqlConn.Close();
                return result;
            }
        }

        public List<SevkiyatGuncellemeView> Listele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.View_sevkiyatGuncellemeleri", Connection.sqlConn);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<SevkiyatGuncellemeView> SevkiyatGuncellemeleri = new List<SevkiyatGuncellemeView>();
                    
                    while (dataReader.Read())
                    {
                        SevkiyatGuncellemeleri.Add(
                        new SevkiyatGuncellemeView
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            SiparisNo = dataReader["siparisNo"].ToString(),
                            MusteriAd = dataReader["musteriAd"].ToString(),
                            Aciklama = dataReader["aciklama"].ToString(),
                            Durum = dataReader["Durum"].ToString(),
                            IslemTarih = Convert.ToDateTime(dataReader["IslemTarih"]),


                        });
                    }
                    return SevkiyatGuncellemeleri;
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

        public List<SevkiyatGuncellemeView> ListeleBySevkiyatId(int sevkiyatId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.View_sevkiyatGuncellemeleri where sevkiyatId=@sevkiyatID", Connection.sqlConn);
            command.Parameters.AddWithValue("@sevkiyatId", sevkiyatId);
            try
            {
                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<SevkiyatGuncellemeView> SevkiyatGuncellemeleri = new List<SevkiyatGuncellemeView>();

                    while (dataReader.Read())
                    {
                        SevkiyatGuncellemeleri.Add(
                        new SevkiyatGuncellemeView
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            SiparisNo = dataReader["siparisNo"].ToString(),
                            MusteriAd = dataReader["musteriAd"].ToString(),
                            Aciklama = dataReader["aciklama"].ToString(),
                            Durum = dataReader["Durum"].ToString(),
                            IslemTarih = Convert.ToDateTime(dataReader["IslemTarih"]),


                        });
                    }
                    return SevkiyatGuncellemeleri;
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
