using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz
{
   public partial class FrmFilter : Form
   {
        private Mahasiswa mhswa = null;      

        public FrmFilter()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_Sample;Integrated Security=True");

        public  FrmFilter(Mahasiswa MhsSent)
        {
            InitializeComponent();
            this.txtNim.Text = MhsSent.Nim;
            this.txtNama.Text = MhsSent.Nim;
            this.cboJenisKelamin.SelectedItem = MhsSent.JenisKelamin;
            this.cboProgramStudi.SelectedItem = MhsSent.ProgramStudi;
            this.cboWaktuKuliah.SelectedItem = MhsSent.WaktuKuliah;
            this.cboKelas.SelectedItem = MhsSent.Kelas;
        }

        public Mahasiswa RunAndReturnObjectMahasiswa(FrmFilter frm)
        {
            frm.ShowDialog();
            return mhswa;
        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mhswa = new Mahasiswa
            (
                this.txtNim.Text.Trim(),
                this.txtNama.Text.Trim(),
                this.cboJenisKelamin.Text.ToString().Trim(),
                this.cboProgramStudi.Text.ToString().Trim(),
                this.cboWaktuKuliah.Text.ToString().Trim(),
                this.cboKelas.Text.ToString().Trim()
            );
            this.Close();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearform();
        }

        private void clearform()
        {
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.cboJenisKelamin.SelectedIndex = -1;
            this.cboProgramStudi.SelectedIndex = -1;
            this.cboWaktuKuliah.SelectedIndex = -1;
            this.cboKelas.SelectedIndex = -1;
        }
    }
}
