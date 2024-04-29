using Microsoft.AspNetCore.Mvc;
using modul10_1302223029;   

namespace modul10_1302223029.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa> {
            new Mahasiswa("Asy-Syifa Ekhar Nanda Kautsar", "1302223029", new List<string> { "KPL", "PBO", "BO"}, 2019),
            new Mahasiswa("Fionadhilla Gustriani", "1302220002", new List<string> { "KPL", "PBO", "BO"}, 2019),
            new Mahasiswa("Febry Twenido Firmanio", "1302220084", new List<string> { "KPL", "PBO", "BO"}, 2019),
            new Mahasiswa("Henri Silas Samban", "1302220087", new List<string> { "KPL", "PBO", "BO"}, 2019),
            new Mahasiswa("Indra Mahesa", "1302220067", new List < string > { "KPL", "PBO", "BO" }, 2019),
        };


        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }


        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }   

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(Get), new { id = mahasiswaList.IndexOf(mahasiswa) }, mahasiswa);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}