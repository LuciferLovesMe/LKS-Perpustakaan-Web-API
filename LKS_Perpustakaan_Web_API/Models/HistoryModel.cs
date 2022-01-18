using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Perpustakaan_Web_API.Models
{
    public class HistoryModel
    {
        public int id { set; get; }
        public string id_anggota { set; get; }
        public string kode_buku { set; get; }
        public string tgl_pinjam { set; get; }
        public string tgl_kembali { set; get; }
        public string tgl_kembali_riil { set; get; }
        public int denda { set; get; }
        public int jumlah_hari_denda { set; get; }
        public string judul { set; get; }
    }
}