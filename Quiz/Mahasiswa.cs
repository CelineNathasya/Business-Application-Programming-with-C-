using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
   
    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public string ProgramStudi { get; set; }
        public string WaktuKuliah { get; set; }
        public string Kelas { get; set; }

        public Mahasiswa(string nim, string nama, string jk, string prodi, string wk, string kls)
        {
            this.Nim = nim;
            this.Nama = nama;
            this.JenisKelamin = jk;
            this.ProgramStudi = prodi;
            this.WaktuKuliah = wk;
            this.Kelas = kls;
        }
    }
   
}
