using Microsoft.AspNetCore.Mvc;
using Recruit.Server.Models;
using Recruit.Server.Services.AuthService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NgayCongController : Controller
    {
        private readonly ITinhCongService tinhCongService;

        public NgayCongController(ITinhCongService tinhCongService)
        {
            this.tinhCongService = tinhCongService;
        }

        [HttpPost("/Search")]
        public JsonResult Search(DayToSearch dayToSearch)
        {
            var result = tinhCongService.layNgayCongToanBoNV(dayToSearch);
            return Json(result);
        }

        [HttpGet("/getsNhanVien")]
        public JsonResult getsNhanVien()
        {
            var result = tinhCongService.getsNhanVien();
            return Json(result);
        }

        [HttpGet("/getsLoaiChamCong")]
        public JsonResult getsLoaiChamCong()
        {
            var result = tinhCongService.getsLoaiChamCong();
            return Json(result);
        }

        //[HttpGet("/layNhanvienbyEmail/{email}")]
        //public JsonResult layNhanvienbyEmail(string email)
        //{
        //    var result = tinhCongService.layNhanvienbyEmail(email);
        //    return Json(result);
        //}

        //[HttpGet("/getNgayCong/{maNV}/{ngay}/{thang}/{nam}")]
        //public JsonResult getNgayCong(string maNV, string ngay, string thang, string nam)
        //{
        //    var result = tinhCongService.getNgayCong(maNV, ngay, thang, nam);
        //    return Json(result);
        //}        

        [HttpGet("/getMaChamCongHeader/{PsnPrkID}/{thangcc}/{namcc}")]
        public JsonResult getNgayCong(int PsnPrkID, int thangcc, int namcc)
        {
            var result = tinhCongService.getMaChamCongHeader(PsnPrkID, thangcc, namcc);
            return Json(result);
        }

        [HttpPost("/NgayCong/Update")]
        public JsonResult Update(ChamCongHeader chamCongHeader)
        {
            var kqua = tinhCongService.addUpdateNgayChamCong(chamCongHeader);
            return Json(kqua);
        }

        [HttpGet("/NgayCong/UpdateScan/{PsnPrkID}/{trangThai}")]
        public JsonResult UpdateScan(double PsnPrkID, int trangThai)
        {
            var kqua = tinhCongService.addUpdateNgayChamCongScan(PsnPrkID, trangThai);
            return Json(kqua);
        }

        [HttpPost("/NgayCong/Delete")]
        public JsonResult Delete(ChamCongDelete chamCongHeader)
        {
            tinhCongService.deleteNgayChamCong(chamCongHeader);
            return Json("");
        }
    }
}
