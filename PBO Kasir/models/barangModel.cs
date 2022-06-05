using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Kasir.models
{
    public class barangModel
    {
        SqlDBHelper objSqlDb = new SqlDBHelper();

        public barangModel()
        {

        }

        public DataTable getKategori()
        {
           
            string query = "SELECT id_kategori FROM kategori;";
             DataTable dt = objSqlDb.ExecuteQuery(query);
             return dt;
        }
        public void tambahKategori(string id_kategori)
        {
            try
            {
                string query = "insert into kategori values ('{0}');";
                query = string.Format(query, id_kategori);
                objSqlDb.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                //
            }

        }
        public DataTable getDataBarang()
        {
            string query = "select * from barang ;";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            return dt;
        }
        public bool checkValueAda(string namaKolom, string data, string tabel)
        {
            string query = "select * from " + tabel + " where " + namaKolom + " = '" + data + "'";
            DataTable dt = objSqlDb.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void hapusData(string idBarang, string namaTabel, string namaID)
        {
            string sql = @"DELETE FROM :nama_tabel
                           Where :namaID = :idBarang";
            objSqlDb.ExecuteNonQuery(sql,
                new NpgsqlParameter(":nama_tabel", namaTabel),
                new NpgsqlParameter(":idBarang", idBarang),
                new NpgsqlParameter(":namaID", namaID)
                );
        }

        public void updateBarang(string kode, string nama, string hargaDasar, string hargaJual, string stok, string kategori)
        {
            string query = @"update barang set kode_barang =:kode::varchar(100),
                                nama_barang =:nama::varchar(255) , 
                                harga_dasar =:hargaDasar::money,
                                harga_jual =:hargaJual::money,
                                stok = :stok::integer,
                                kategori_id_kategori = :kategori::varchar(100)
                                where kode_barang =:kode::varchar(100);";
            objSqlDb.ExecuteNonQuery(query,
                new NpgsqlParameter(":kode", kode),
                new NpgsqlParameter(":nama", nama),
                new NpgsqlParameter(":hargaDasar", hargaDasar),
                new NpgsqlParameter(":hargaJual", hargaJual),
                new NpgsqlParameter(":stok", stok),
                new NpgsqlParameter(":kategori", kategori)
                );
        }

        public void tambahBarang(string kode, string nama, string hargaDasar, string hargaJual, string stok, string kategori)
        {
            try
            {
                string query = "insert into barang (kode_barang, nama_barang, harga_dasar, harga_jual, stok, kategori_id_kategori) values ('{0}','{1}','{2}','{3}','{4}','{5}');";
                query = string.Format(query, kode, nama, hargaDasar, hargaJual, stok, kategori);
                objSqlDb.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                //
            }
            
        }

        

    }
}
