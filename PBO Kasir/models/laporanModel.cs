using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Kasir.models
{
    public class laporanModel
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();

        public laporanModel()
        {

        }

        public DataTable getHasilTransaksi(string kategori)
        {
            string query = "select id_transaksi, nama_pelanggan, jumlah_pemasukan, tanggal_transaksi from transaksi where jenis_transaksi = '" + kategori + "' ";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            return dt;
        }

        
        public void hapusData(string idBarang, string namaTabel, string namaID)
        {

            string query = "Delete From {0} where {1} = '{2}' ";
            query = string.Format(query, namaTabel, namaID, idBarang);
            objSqlDb.ExecuteNonQuery(query);
        }




    }
}
