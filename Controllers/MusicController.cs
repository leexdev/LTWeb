using Lab2_3.Models;
using Lab2_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2_3.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        Data a = new Data();
        // List<Song> listSong = new List<Song>();

        private List<Song> Initializesongs()
        {
            return new List<Song>
            {
            new Song { Id = 1, Title = "Em là kẻ đáng thương", Artist = "Phát Huy T4", FilePath = "~/Content/EmLaKeDangThuong-PhatHuyT4-8504796.mp3", FileName = "EmLaKeDangThuong-PhatHuyT4-8504796.mp3"},
                new Song { Id = 2, Title = "Một năm mới bình an", Artist = "Sơn Tùng", FilePath = "~/Content/Mot-Nam-Moi-Binh-An-Son-Tung-M-TP.mp3", FileName = "Mot-Nam-Moi-Binh-An-Son-Tung-M-TP.mp3"},
                new Song { Id = 3, Title = "Rồi ta sẽ ngắm pháo hoa cùng nhau", Artist = "Olew VietNam", FilePath = "~/Content/RoiTaSeNgamPhaoHoaCungNhau-OlewVietNam-8485329.mp3", FileName = "RoiTaSeNgamPhaoHoaCungNhau-OlewVietNam-8485329.mp3"},
                new Song { Id = 4, Title = "Bồng bềnh bồng bềnh", Artist = "Nam Em", FilePath = "~/Content/BongBenhBongBenhTheHeroes2022-NamEm-8738686.mp3", FileName = "BongBenhBongBenhTheHeroes2022-NamEm-8738686.mp3"},
                new Song { Id = 5, Title = "Như anh đã thấy em", Artist = "Tim", FilePath = "~/Content/NhuAnhDaThayEm-PhucXPFreakD-7370334.mp3", FileName = "NhuAnhDaThayEm-PhucXPFreakD-7370334.mp3"},
                new Song { Id = 6, Title = "Waiting for you", Artist = "Mono", FilePath = "~/Content/WaitingForYou-MONOOnionn-7733882.mp3", FileName = "WaitingForYou-MONOOnionn-7733882.mp3"},
                new Song { Id = 7, Title = "Lửng Lơ", Artist = "Massew", FilePath = "~/Content/LungLo-MasewBRayRedTYTien-5934275.mp3", FileName = "LungLo-MasewBRayRedTYTien-5934275.mp3"},
                new Song { Id = 8, Title = "Nàng thơ", Artist = "Hoàng Dũng", FilePath = "~/Content/NangTho-HoangDung-6413381.mp3", FileName = "NangTho-HoangDung-6413381.mp3"},
                new Song { Id = 9, Title = "Ánh sao và bầu trời", Artist = "Tri", FilePath = "~/Content/AnhSaoVaBauTroi-TRI-7085073.mp3", FileName = "AnhSaoVaBauTroi-TRI-7085073.mp3"},
                new Song { Id = 10, Title = "Em đồng ý", Artist = "Đức Phúc", FilePath = "~/Content/EmDongYIDo-DucPhucx911-8679310.mp3", FileName = "EmDongYIDo-DucPhucx911-8679310.mp3"}
            };
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult ListMusic()
        {
            a.listSong = Initializesongs();
            ViewBag.listSong = a.listSong;
            //TempData["listSong"] = a.listSong;
            return View();
        }

        public ViewResult DetailsMusic(string filePath, string song_Title, string artist)
        {
            ViewBag.filePath = filePath;
            ViewBag.song_Title = song_Title;
            ViewBag.artist = artist;
            return View();
        }

        public ActionResult PlayMusic(int id)
        {
            return View();
        }

        public FilePathResult Download(string filePath, string fileName)
        {
            string get_path = Server.MapPath(filePath);
            return File(get_path, "music/mp3", fileName);
        }
    }
}