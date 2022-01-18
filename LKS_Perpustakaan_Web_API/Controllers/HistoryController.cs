using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LKS_Perpustakaan_Web_API.Models;

namespace LKS_Perpustakaan_Web_API.Controllers
{
    public class HistoryController : ApiController
    {
        SqlConnection connection = new SqlConnection(Connection.conn);
        List<HistoryModel> h = new List<HistoryModel>();

        [HttpPost]
        public List<HistoryModel> histories([FromBody]HistoryModel m)
        {
            SqlCommand command = new SqlCommand("select * from peminjaman join peminjaman_buku on peminjaman.id_pinjam = peminjaman_buku.id_pinjam join buku on buku.kode_buku = peminjaman_buku.kode_buku where peminjaman.id_anggota = '" + m.id_anggota + "'", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            while (reader.HasRows)
            {
                h.Add(new HistoryModel
                {
                    id = Convert.ToInt32(reader["id"]),
                    denda = Convert.ToInt32(reader["denda"]),
                    jumlah_hari_denda = Convert.ToInt32(reader["jml_hari_denda"]),
                    id_anggota = reader["id_user"].ToString(),
                    kode_buku = reader["kode_buku"].ToString(),
                    tgl_kembali = reader["kode_buku"].ToString(),
                    tgl_pinjam = reader["kode_buku"].ToString(),
                    tgl_kembali_riil = reader["kode_buku"].ToString(),
                    judul = reader["kode_buku"].ToString(),
                });
            }

            connection.Close();
            return h.ToList();
        }
    }
}
