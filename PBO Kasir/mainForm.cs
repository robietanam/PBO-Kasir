using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Kasir
{
    public partial class mainForm : Form
    {
        login objLoginForm;
        Kredit objKredit;
        Transaksi objTransaksi;
        Barang objBarang;
        StokBarang objStokBarang;
        KategoriTambah objKategoriTambah;
        Kasbon objKasbon;
        KasbonTambah objKasbonTambah;
        Konfirmasi objKonfirmasi;
        KonfirmasiBerhasil objKonfirmasiBerhasil;
       
        int offset_lebar_menu = 200;
        int lebar_menu = 600;
        int panjang_menu = 450;

        public mainForm()
        {
            InitializeComponent();
            initGuiKomponen();
        }
        private void initGuiKomponen()
        {
            objLoginForm = new login(this);
            objLoginForm.Dock = DockStyle.Left;
            this.Controls.Add(objLoginForm);

            objKredit = new Kredit();
            objKredit.Location = new Point(200,0);
            objKredit.Anchor = AnchorStyles.None;
            this.Controls.Add(objKredit);

            objTransaksi = new Transaksi(this);
            objTransaksi.Location = new Point(200, 0);
            objTransaksi.Anchor = ( (AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objTransaksi);

            objBarang = new Barang(this);
            objBarang.Location = new Point(200, 0);
            objBarang.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objBarang);

            objStokBarang = new StokBarang(this);
            objStokBarang.Location = new Point(200, 0);
            objStokBarang.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objStokBarang);

            objKasbon = new Kasbon(this);
            objKasbon.Location = new Point(200, 0);
            objKasbon.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKasbon);

            objKasbonTambah = new KasbonTambah(this);
            objKasbonTambah.Location = new Point(200, 0);
            objKasbonTambah.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKasbonTambah);

            objKonfirmasi = new Konfirmasi(this);
            objKonfirmasi.Location = new Point(200, 0);
            objKonfirmasi.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKonfirmasi);

            objKonfirmasiBerhasil = new KonfirmasiBerhasil(this);
            objKonfirmasiBerhasil.Location = new Point(200, 0);
            objKonfirmasiBerhasil.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKonfirmasiBerhasil);

            objKategoriTambah = new KategoriTambah(this);
            objKategoriTambah.Location = new Point(200, 0);
            objKategoriTambah.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKategoriTambah);
            //objListUsers = new listUsers(this);
            //objListUsers.Dock = DockStyle.Fill;
            //this.Controls.Add(objListUsers);
            //showLoginForm();

            //objListPerson = new listPerson(this);
            //objListPerson.Dock = DockStyle.Fill;
            //this.Controls.Add(objListPerson);

            //objVPeran = new WinFormsApp2.peran();
            //objVPeran.Dock = DockStyle.Fill;dd
            showLoginForm();

            //showListPersons();


        }

        /*public void showListPersons()
        {
            objLoginForm.Visible = false;
            objListPerson.Visible = true;
            objListPerson.isiDataUsers();
            toolStrip1.Visible = true;
        }*/
       
        public void showLoginForm()
        {
            objLoginForm.Visible = true;
            hideMainForm();

            //objListPerson.Visible = false;
            //toolStrip1.Visible = false;
        }
        public void showMenuBarang()
        {
            objBarang.isiDataUsers();
            objBarang.Visible = true;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objTransaksi.Visible = false;
            objKasbon.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void showplsStokBarang()
        {
            objStokBarang.Visible = true;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbon.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void showMenuTransaksi()
        {
            objTransaksi.Visible = true;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objKasbon.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        
        public void showMenuKasbon()
        {
            objKasbon.Visible = true;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void showKasbonTambah()
        {
            objKasbonTambah.Visible = true;
            objKasbon.Visible = false;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void showKonfirmasi()
        {
            objKonfirmasi.Visible = true;
            objKasbon.Visible = false;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void showKonfirmasiBerhasil()
        {
            objKonfirmasiBerhasil.Visible = true;
            objKasbon.Visible = false;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
        }
        public void showTambahKategori()
        {
            objKategoriTambah.Visible = true;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbon.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;
        }
        public void hideMainForm()
        {
            objKategoriTambah.Visible = false;
            objStokBarang.Visible = false;
            objKredit.Visible = false;
            objBarang.Visible = false;
            objTransaksi.Visible = false;
            objKasbon.Visible = false;
            objKasbonTambah.Visible = false;
            objKonfirmasi.Visible = false;
            objKonfirmasiBerhasil.Visible = false;

           
            panelMenu.Visible = false;
            btnMenu_Pengaturan.Visible = false;
            btnMenu_Laporan.Visible = false;
            btnMenu_Kasbon.Visible = false;
            btnMenu_Barang.Visible = false;
            btnMenu_Transaksi.Visible = false;
            label1.Visible = false;
        }
        public void showMainForm()
        {
            objKredit.Visible = true;
            panelMenu.Visible = true;
            btnMenu_Pengaturan.Visible = true;
            btnMenu_Laporan.Visible = true;
            btnMenu_Kasbon.Visible = true;
            btnMenu_Barang.Visible = true;
            btnMenu_Transaksi.Visible = true;
            label1.Visible = true;
        }

        private void btnMenu_Barang_Click(object sender, EventArgs e)
        {
            showMenuBarang();
        }

        private void btnMenu_Transaksi_Click(object sender, EventArgs e)
        {
            showMenuTransaksi();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Kasbon_Click(object sender, EventArgs e)
        {
            showMenuKasbon();
        }
        /* public void showPeranForm()
{
objLoginForm.Visible = false;
objListPerson.Visible = false;
objVPeran.Visible = true;
toolStrip1.Visible = true;
this.Text = "Daftar Peran";
}*/

    }


    
}
