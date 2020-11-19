using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz
{
   public partial class FrmEnqueryData : Form
   {
        private Mahasiswa MhsSent = new Mahasiswa("", "", "", "", "", "");

        public FrmEnqueryData()
        {
         InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_Sample;Integrated Security=True");

        private void Loaddata()
        {
            SqlCommand cmd = new SqlCommand("Select * from TMahasiswa", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dgvData.DataSource = dt;

        }

        //private void Countdgvdata()
        //{
        //    int count = dgvData.Rows.Count;
        //    lblBanyakRecordData.Text = count.ToString();
        //}     

        private void FrmEnqueryData_Load(object sender, EventArgs e)
        {
            try
            {
                Loaddata();
                //Countdgvdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var frmfilter = new FrmFilter(MhsSent);
            var returnvalue = frmfilter.RunAndReturnObjectMahasiswa(frmfilter);
            if(returnvalue != null)
            {
                string nim = returnvalue.Nim;
                string nama = returnvalue.Nama;
                string jnskelamin = returnvalue.JenisKelamin;
                string prgmstudi = returnvalue.ProgramStudi;
                string watkul = returnvalue.WaktuKuliah;
                string kls = returnvalue.Kelas;

                SqlCommand cmd = new SqlCommand(@"Select * from TMahasiswa where [nim] like '" + nim + "%' and [nama] like '" + nama + "%' and [jeniskelamin] like '"
                        + jnskelamin + "%'  and [programstudi] like '" + prgmstudi + "%'  and [waktukuliah] like '" + watkul + "%' and [kelas] like '"+kls+ "%' ", conn);
                DataTable dt = new DataTable();

                conn.Open();

                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                conn.Close();

                dgvData.DataSource = dt;

                lblFilter.Text = $"Nim : {nim}.  Nama : {nama}. Jenis Kelamin : {jnskelamin}. Program Studi : {prgmstudi}. Waktu Kuliah : {watkul}. Kelas : {kls}";

                MhsSent.Nim = nim;
                MhsSent.Nama = nama;
                MhsSent.JenisKelamin = jnskelamin;
                MhsSent.ProgramStudi = prgmstudi;
                MhsSent.WaktuKuliah = watkul;
                MhsSent.Kelas = kls;

            }
        }

        private void dgvData_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int record = dgvData.Rows.Count;
            lblBanyakRecordData.Text = record + " Record";
        }
    }
}
