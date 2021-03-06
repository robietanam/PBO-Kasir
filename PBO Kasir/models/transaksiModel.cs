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
        public void simpanTransaksiBarang(string nama_pelanggan, float jumlah_pemasukan, string kode_barang)
        {
            string jenis_transaksi = "Pembelian";
            string query = "insert into transaksi(jenis_transaksi,nama_pelanggan,jumlah_pemasukan) values ('{0}', '{1}', '{2}')";
            query = string.Format(query,jenis_transaksi, nama_pelanggan, jumlah_pemasukan.ToString().Replace(',','.'));
            objSqlDb.ExecuteNonQuery(query);

        }
        public void simpanTransaksiKasbon(string nama_pelanggan, float jumlah_pemasukan)
        {
            string jenis_transaksi = "Kasbon";
            string query = "insert into transaksi(jenis_transaksi,nama_pelanggan,jumlah_pemasukan ) values ('{0}', '{1}', '{2}')";
            query = string.Format(query, jenis_transaksi, nama_pelanggan, jumlah_pemasukan);
            objSqlDb.ExecuteNonQuery(query);

        }
        public DataTable getHargaDasar(string kode)
        {
            string query = "select harga_dasar from barang where kode_barang='" + kode + "'";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            return dt;
        }
    }
}
