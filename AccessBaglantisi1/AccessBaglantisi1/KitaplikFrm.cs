using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    

namespace AccessBaglantisi1
{
    public partial class KitaplikFrm : Form
    {
        OleDbConnection odcbaglanti; 
        public KitaplikFrm()
        {
            InitializeComponent();
        }

        public void baglan()
        {
            odcbaglanti = new OleDbConnection();
            odcbaglanti.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = KitaplikDB.accdb;";
            odcbaglanti.Open();
        }

        public void baglantiKapat()
        {
            odcbaglanti.Close();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand odcom = new OleDbCommand();
            odcom.Connection = odcbaglanti;
            odcom.CommandText = "insert into Kitaplar(kitapAdi,yayinEvi,yazarAdi) values('"+kitapaditxt.Text+"','"+yayinevitxt.Text+"','"+yazaraditxt.Text+"')";
            odcom.ExecuteNonQuery();
            baglantiKapat();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            baglan();
            String sql = "select * from Kitaplar";
            OleDbDataAdapter oda = new OleDbDataAdapter(sql, odcbaglanti);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            veriTablodgw.DataSource = ds.Tables["Kitaplar"];
            baglantiKapat();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand odcom = new OleDbCommand();
            odcom.Connection = odcbaglanti;
            odcom.CommandText = "delete from Kitaplar where kitapAdi='"+kitapaditxt.Text+"'";
            odcom.ExecuteNonQuery();
            baglantiKapat();
        }

        private void guncellebtn_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand odcom = new OleDbCommand();
            odcom.Connection = odcbaglanti;
            odcom.CommandText = "update Kitaplar set yayinEvi='"+yayinevitxt.Text+"',yazarAdi='"+yazaraditxt.Text+"' where kitapAdi='" + kitapaditxt.Text + "'";
            odcom.ExecuteNonQuery();
            baglantiKapat();
        }
    }
}
