using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
   public partial class FrmFilter : Form
   {

        public FrmFilter(Mahasiswa mhs)
        {
            InitializeComponent();
            this.txtNim.Text = mhs.Nim;
            this.txtNama.Text = mhs.Nama;
            this.cboJenisKelamin.SelectedItem = mhs.JenisKelamin;
            this.cboProgramStudi.SelectedItem = mhs.ProgramStudi;
            this.cboWaktuKuliah.SelectedItem = mhs.WaktuKuliah;
            this.cboKelas.SelectedItem = mhs.Kelas;
        }

        private Mahasiswa DataMahasiswa = null;

        public Mahasiswa passFilterValue(FrmFilter form)
        {
            form.ShowDialog();
            return DataMahasiswa;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataMahasiswa = new Mahasiswa
            (
                this.txtNim.Text,
                this.txtNama.Text,
                this.cboJenisKelamin.Text.ToString(),
                this.cboProgramStudi.Text.ToString(),
                this.cboWaktuKuliah.Text.ToString(),
                this.cboKelas.Text.ToString()
            );
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.cboJenisKelamin.SelectedIndex = 0;
            this.cboProgramStudi.SelectedIndex = 0;
            this.cboWaktuKuliah.SelectedIndex = 0;
            this.cboKelas.SelectedIndex = 0;
        }

        private void FrmFilter_Load(object sender, EventArgs e)
        {

        }

    }
}
