using Microsoft.AspNetCore.Mvc;
using TPMODULL9_2311104068.Models;

namespace TPMODULL9_2311104068.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
            {
                new Mahasiswa { Nama = "Ilham", Nim = "2311104068" },
                new Mahasiswa { Nama = "Naruto", Nim = "2311104099" },
                new Mahasiswa { Nama = "William J Moriarty", Nim = "231110498" }
            };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll() => listMahasiswa;

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= listMahasiswa.Count) return NotFound();
            return listMahasiswa[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.Add(mhs);
            return Ok("Mahasiswa ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= listMahasiswa.Count) return NotFound();
            listMahasiswa.RemoveAt(index);
            return Ok("Mahasiswa dihapus");
        }
    }
}