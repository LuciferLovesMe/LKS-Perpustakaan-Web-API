using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LKS_Perpustakaan_Web_API.Models
{
    public class BookModel
    {
        public string kode_buku { set; get; }
        public string kode_lokasi { set; get; }
        public string kategori { set; get; }
        public string judul { set; get; }
        public string penerbit { set; get; }
        public string deskripsi { set; get; }
        public int harga { set; get; }
        public int stok { set; get; }
        public string penulis { set; get; }
    }
}