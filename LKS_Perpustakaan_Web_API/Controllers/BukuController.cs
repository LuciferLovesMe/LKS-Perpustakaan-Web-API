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
    public class BukuController : ApiController
    {
        SqlConnection connection = new SqlConnection(Connection.conn);
        List<BookModel> m = new List<BookModel>();

        [HttpGet]
        public List<BookModel> lists()
        {
            SqlCommand command = new SqlCommand("select * from buku join kategori on buku.id_kat = kategori.id_kat where stok is not null", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                m.Add(new BookModel
                {
                    kode_buku = reader["kode_buku"].ToString(),
                    judul = reader["judul"].ToString(),
                    deskripsi = reader["deskripsi"].ToString(),
                    kategori = reader["nama_kat"].ToString(),
                    kode_lokasi = reader["kode_lokasi"].ToString(),
                    penerbit = reader["penerbit"].ToString(),
                    penulis = reader["penulis"].ToString(),
                    harga = Convert.ToInt32(reader["harga"]),
                    stok = Convert.ToInt32(reader["stok"])
                });
            }
            connection.Close();

            return m.ToList();
        }
    }
}
