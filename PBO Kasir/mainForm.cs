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

        public void hideMainForm()
        {
            objKredit.Visible = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

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
