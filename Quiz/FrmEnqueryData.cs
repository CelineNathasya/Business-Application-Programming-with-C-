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

namespace Quiz
{
    public partial class FrmEnqueryData : Form
    {

        public FrmEnqueryData()
        {
            InitializeComponent();
            this.dgvData1.AutoGenerateColumns = false;
            //loadData();

        }

        private void FrmEnqueryData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mahasiswaDS.TMahasiswa' table. You can move, or remove it, as needed.
            this.tMahasiswaTableAdapter.Fill(this.mahasiswaDS.TMahasiswa);

        }

        private void loadData()
        {
            try
            {
                using (var conn = new Connection().OpenConnection())
                {
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"SELECT Nim, Nama, JenisKelamin, ProgramStudi, WaktuKuliah, Kelas From TMahasiswa ORDER BY Nim ASC";
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    this.dgvData1.Rows.Add(new string[] {
                                          reader["Nim"].ToString(),
                                          reader["Nama"].ToString(),
                                          reader["JenisKelamin"].ToString(),
                                          reader["ProgramStudi"].ToString(),
                                          reader["WaktuKuliah"].ToString(),
                                          reader["Kelas"].ToString()
                                     });
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private Mahasiswa mhsValue = new Mahasiswa("", "", "", "", "", "");


        private void btnFilter_Click(object sender, EventArgs e)
        {
            var conn = new Connection().OpenConnection();
            var formFilter = new FrmFilter(mhsValue);
            var filterValue = formFilter.passFilterValue(formFilter);
            if (filterValue != null)
            {
                string nim = filterValue.Nim;
                string nama = filterValue.Nama;
                string jk = filterValue.JenisKelamin;
                string prodi = filterValue.ProgramStudi;
                string wk = filterValue.WaktuKuliah;
                string kls = filterValue.Kelas;

                SqlCommand cmd = new SqlCommand
                (
                    @"SELECT * FROM TMahasiswa WHERE [Nim] LIKE '" + nim
                    + "%' AND [Nama] LIKE '" + nama
                    + "%' AND [JenisKelamin] LIKE '" + jk
                    + "%'  AND [ProgramStudi] LIKE '" + prodi
                    + "%'  AND [WaktuKuliah] LIKE '" + wk
                    + "%' AND [Kelas] LIKE '" + kls + "%' ", conn
                );

                DataTable dt = new DataTable();

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);

                dgvData1.DataSource = dt;

                mhsValue.Nim = nim;
                mhsValue.Nama = nama;
                mhsValue.JenisKelamin = jk;
                mhsValue.ProgramStudi = prodi;
                mhsValue.WaktuKuliah = wk;
                mhsValue.Kelas = kls;

                this.lblBanyakRecordData.Text = dgvData1.Rows.Count.ToString() + " Record Data.";

                this.lblFilter.Text = $"Nim : {nim}   " +
                                    $"Nama : {nama}    " +
                                    $"Jenis Kelamin : {jk}    " +
                                    $"Program Studi : {prodi}    " +
                                    $"Waktu Kuliah : {wk}    " +
                                    $"Kelas : {kls}";
            }


        }
    }
}
