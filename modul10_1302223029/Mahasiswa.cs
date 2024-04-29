namespace modul10_1302223029
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
        public List<string> Course { get; set; }
        
        public int Year { get; set; }

        public Mahasiswa(String Nama, String Nim, List<String> Course, int year)
        {
            this.Nama = Nama;
            this.Nim = Nim;
            this.Course = Course;
            this.Year = year;
        }

    }
}
