namespace API_Akun.Model
{
    public class Akun
    {
        public string Nama { get; set; }

        public string Role  { get; set; }

        public Akun(string Nama, string Role)
        {
            this.Nama = Nama;
            this.Role = Role;
        }
    }
}

