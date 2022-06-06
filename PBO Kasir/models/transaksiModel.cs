using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Kasir.models
{
    public class transaksiModel
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();
        public transaksiModel()
        {

        }
        public void simpanTransaksi(string nama_pelanggan, string jumlah_pemasukan, string kode_barang)
        {
            string jenis_transaksi = "Pembelian";
            string query = "insert into transaksi(jenis_transaksi,nama_pelanggan,jumlah_pemasukan,barang_kode_barang) values ('{0}', '{1}', '{2}', '{3}')";
            query = string.Format(query,jenis_transaksi, nama_pelanggan, jumlah_pemasukan, kode_barang);
            objSqlDb.ExecuteNonQuery(query);
        }
    }
}
