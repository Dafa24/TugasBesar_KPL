using API_Barang;
using API_Barang.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_TUBES_KPL_KELOMPOK_05.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BukuController : Controller
    {
        private static List<Barang> DataDisplayBarang = new List<Barang>();

        public BukuController()
        {
            string jsonFilePath = "D:\\TugasBesar_KPL\\API_Barang\\Data\\DataBarang.json";
            string jsonData = System.IO.File.ReadAllText(jsonFilePath);
            DataDisplayBarang = JsonConvert.DeserializeObject<List<Barang>>(jsonData);
        }

        public static List<Barang> getDataDisplayBook()
        {
            return DataDisplayBarang;
        }

        // GET DATA ALL API
        [HttpGet]
        public IEnumerable<Barang> GET()
        {
            return DataDisplayBarang;
        }

        // GET BOOK BY NamaBarang
        [HttpGet("{NamaBarang}")]
        public ActionResult<Barang> GET(string NamaBarang)
        {
            try
            {
                int id = -1;

                for (int i = 0; i < DataDisplayBarang.Count; i++)
                {
                    if (NamaBarang == DataDisplayBarang[i].NamaBarang)
                    {
                        id = i;
                    }
                }

                if (id != -1)
                {
                    return DataDisplayBarang[id];
                }
                else
                {
                    return NotFound("Nama Barang tidak ditemukan!"); // Mengembalikan respons 404 Not Found dengan pesan
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Terjadi kesalahan: " + ex.Message); // Mengembalikan respons 500 Internal Server Error dengan pesan
            }
        }
    }
}