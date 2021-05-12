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
    public class AdSevkiyatDal:ISevkiyatDal
    {
        public int Ekle(Sevkiyat sevkiyat)
        {
            using (SqlCommand command = new SqlCommand("INSERT INTO SevkiyatTakip.Sevkiyatlar (MusteriId,AracId,YuklemeTipId,PlakaNo,Adet,Aciklama,LojistikFirma,SiparisNo,TerminTarih,DurumId) " +
                "VALUES(@MusteriId,@AracId,@YuklemeTipId,@PlakaNo,@Adet,@Aciklama,@LojistikFirma,@SiparisNo,@TerminTarih,@DurumId) ", Connection.sqlConn))
            {
                command.Parameters.AddWithValue("@MusteriId", sevkiyat.MusteriId);
                command.Parameters.AddWithValue("@AracId", sevkiyat.AracId);
                command.Parameters.AddWithValue("@YuklemeTipId", sevkiyat.YuklemeTipId);
                command.Parameters.AddWithValue("@PlakaNo", sevkiyat.PlakaNo);
                command.Parameters.AddWithValue("@Adet", sevkiyat.Adet);
                command.Parameters.AddWithValue("@Aciklama", sevkiyat.Aciklama);
                command.Parameters.AddWithValue("@LojistikFirma", sevkiyat.LojistikFirma);
                command.Parameters.AddWithValue("@SiparisNo", sevkiyat.SiparisNo);
                command.Parameters.AddWithValue("@TerminTarih", sevkiyat.TerminTarih);
                command.Parameters.AddWithValue("@DurumId", sevkiyat.DurumId);

                Connection.OpenConnection();

                int result = command.ExecuteNonQuery();

                Connection.sqlConn.Close();
                return result;
            }
           
        }

        public Sevkiyat SevkiyatDeger(int sevkiyatId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.Sevkiyatlar WHERE Id=@sevkiyatId", Connection.sqlConn))
            {
                command.Parameters.AddWithValue("@sevkiyatId", sevkiyatId);

                Connection.OpenConnection();

                SqlDataReader dataReader = command.ExecuteReader();


                if (dataReader.HasRows)
                {
                    Sevkiyat sevkiyat = new Sevkiyat();
                    while (dataReader.Read())
                    {
                        sevkiyat.Id = sevkiyatId;
                        sevkiyat.MusteriId = Convert.ToInt32(dataReader["MusteriId"]);
                        sevkiyat.AracId = Convert.ToInt32(dataReader["AracId"]);
                        sevkiyat.YuklemeTipId = Convert.ToInt32(dataReader["YuklemeTipId"]);
                        sevkiyat.PlakaNo = dataReader["PlakaNo"].ToString();
                        sevkiyat.Adet = Convert.ToInt32(dataReader["Adet"]);
                        sevkiyat.IslemTarih = Convert.ToDateTime(dataReader["IslemTarih"]);
                        sevkiyat.TerminTarih = Convert.ToDateTime(dataReader["TerminTarih"]);
                        sevkiyat.Aciklama = dataReader["Aciklama"].ToString();
                        sevkiyat.LojistikFirma = dataReader["LojistikFirma"].ToString();
                        sevkiyat.DurumId = Convert.ToInt32(dataReader["DurumId"]);
                        sevkiyat.SiparisNo = dataReader["SiparisNo"].ToString();
                    }
                    Connection.sqlConn.Close();
                    dataReader.Close();
                    return sevkiyat;
                }
                else
                {
                    Connection.sqlConn.Close();
                    dataReader.Close();
                    return null;
                }


            }
        }


        public List<SevkiyatView> GunlukSevkiyatlar(int yil,int hafta,int gun)
        {
                using (SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.View_Sevkiyatlar  WHERE Yil=@yil and hafta=@hafta and gun=@gun   ", Connection.sqlConn))
                {
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@hafta", hafta); 
                command.Parameters.AddWithValue("@gun", gun);

                Connection.OpenConnection();
                    SqlDataReader dataReader = command.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        List<SevkiyatView> Entities = new List<SevkiyatView>();
                        while (dataReader.Read())
                        {
                            Entities.Add(new SevkiyatView
                            {
                                SevkiyatId = Convert.ToInt32(dataReader["Id"]),
                                MusteriAd = dataReader["MusteriAd"].ToString(),
                                SevkAraci = dataReader["SevkAraci"].ToString(),
                                PlakaNo = dataReader["PlakaNo"].ToString(),
                                YuklemeTip = dataReader["YuklemeTip"].ToString(),
                                Ulke = dataReader["Ulke"].ToString(),
                                Aciklama = dataReader["Aciklama"].ToString(),
                                LojistikFirma = dataReader["LojistikFirma"].ToString(),
                                SiparisNo = dataReader["SiparisNo"].ToString(),
                                TerminTarih =Convert.ToDateTime(dataReader["TerminTarih"]),
                                Durum = dataReader["Durum"].ToString(),
                                Adet = Convert.ToInt32(dataReader["Adet"]),



                            });
                        }
                    Connection.sqlConn.Close();
                        dataReader.Close();
                        return Entities;
                    }
                    else
                    {
                    Connection.sqlConn.Close();
                        dataReader.Close();
                        return null;
                    }
                }
            
        }

        public List<SevkiyatView> HaftalikSevkiyatlar(int yil, int hafta)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SevkiyatTakip.View_Sevkiyatlar  WHERE Yil=@yil and hafta=@hafta   ", Connection.sqlConn))
            {
                command.Parameters.AddWithValue("@yil", yil);
                command.Parameters.AddWithValue("@hafta", hafta);
               

                Connection.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<SevkiyatView> Entities = new List<SevkiyatView>();
                    while (dataReader.Read())
                    {
                        Entities.Add(new SevkiyatView
                        {
                            SevkiyatId = Convert.ToInt32(dataReader["Id"]),
                            MusteriAd = dataReader["MusteriAd"].ToString(),
                            SevkAraci = dataReader["SevkAraci"].ToString(),
                            PlakaNo = dataReader["PlakaNo"].ToString(),
                            YuklemeTip = dataReader["YuklemeTip"].ToString(),
                            Ulke = dataReader["Ulke"].ToString(),
                            Aciklama = dataReader["Aciklama"].ToString(),
                            LojistikFirma = dataReader["LojistikFirma"].ToString(),
                            SiparisNo = dataReader["SiparisNo"].ToString(),
                            TerminTarih = Convert.ToDateTime(dataReader["TerminTarih"]),
                            Durum = dataReader["Durum"].ToString(),
                            Adet = Convert.ToInt32(dataReader["Adet"]),



                        });
                    }
                    Connection.sqlConn.Close();
                    dataReader.Close();
                    return Entities;
                }
                else
                {
                    Connection.sqlConn.Close();
                    dataReader.Close();
                    return null;
                }
            }
        }

        public int Guncelle(Sevkiyat sevkiyat)
        {
            using (SqlCommand command = new SqlCommand("UPDATE SevkiyatTakip.Sevkiyatlar SET " +
                "musteriId=@musteriId,yuklemeTipID=@yuklemeTipID,AracId=@AracId,siparisNo=@siparisNo,Adet=@Adet,aciklama=@aciklama,PlakaNo=@PlakaNo,LojistikFirma=@LojistikFirma,terminTarih=@terminTarih " +
                "WHERE Id=@Id",
                Connection.sqlConn))
            {
                command.Parameters.AddWithValue("@musteriId", sevkiyat.MusteriId);
                command.Parameters.AddWithValue("@yuklemeTipID", sevkiyat.YuklemeTipId);
                command.Parameters.AddWithValue("@AracId", sevkiyat.AracId);
                command.Parameters.AddWithValue("@siparisNo", sevkiyat.SiparisNo);
                command.Parameters.AddWithValue("@Adet", sevkiyat.Adet);
                command.Parameters.AddWithValue("@aciklama", sevkiyat.Aciklama);
                command.Parameters.AddWithValue("@PlakaNo", sevkiyat.PlakaNo);
                command.Parameters.AddWithValue("@LojistikFirma", sevkiyat.LojistikFirma);
                command.Parameters.AddWithValue("@terminTarih", sevkiyat.TerminTarih);

                command.Parameters.AddWithValue("@Id", sevkiyat.Id);

                Connection.OpenConnection();

                int sonuc = command.ExecuteNonQuery();

                Connection.sqlConn.Close();

                return sonuc;
            }
        }

    }
}
