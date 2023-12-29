using EllipticCurve.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Recruit.Server.Data;
using Recruit.Server.Models;
using Recruit.Server.Models.ModelView;
using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Recruit.Server.Services.AuthService
{
    public class TinhCongService : ITinhCongService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ApplicationDbContext tinhCongDbContext;

        public TinhCongService(UserManager<ApplicationUser> userManager, ApplicationDbContext tinhCongDbContext)
        {
            this.userManager = userManager;
            this.tinhCongDbContext = tinhCongDbContext;
        }


        //public int tinhNgayCong(ChamCongLine ngayCong)
        //{
        //    ChamCongLineDb ngayCongNew = new ChamCongLineDb()
        //    {
        //        MngChamCongPrkID = ngayCong.MngChamCongPrkID,
        //        //PsnID = ngayCong.PsnID,
        //        //ThangCC = ngayCong.ThangCC,
        //        //NamCC = ngayCong.NamCC,
        //        NgayCham = ngayCong.NgayCham,
        //        //TrangThai = ngayCong.TrangThai
        //    };
        //    tinhCongDbContext.ChamCongLines.Add(ngayCongNew);
        //    return tinhCongDbContext.SaveChanges();
        ////}

        public IEnumerable<NgayCongServer?> layNgayCongToanBoNV(DayToSearch dayToSearch)
        {
            var toDay = dayToSearch.ToDay;
            var fromDay = dayToSearch.FromDay;
            List<NgayCongServer?> results = new List<NgayCongServer?>();
            //if (dayToSearch.PsnPrkID != 0)
            //{
            var nhanviens = getsNhanVien();
            foreach (var nhanvien in nhanviens)
            {
                var a = getNgayCongsCommon(new DayToSearch()
                {
                    PsnPrkID = nhanvien.PsnPrkID,
                    //PsnPrkID = 2,
                    FromDay = fromDay,
                    ToDay = toDay
                });
                if (a != null)
                    results.Add(a);
            }
            return results;
            //}
            //results.Add(getNgayCongsCommon(dayToSearch));
            //return results;
        }
        public NgayCongServer? getNgayCongsCommon(DayToSearch dayToSearch)
        {
            try
            {
                var toDay = dayToSearch.ToDay;
                var fromDay = dayToSearch.FromDay;

                var nhanVienCoNgayCong = (from Personnels in tinhCongDbContext.Personnels
                                          where Personnels.PsnPrkID == dayToSearch.PsnPrkID
                                          select new NgayCongServer()
                                          {
                                              PsnPrkID = Convert.ToInt32(Personnels.PsnPrkID),
                                              PsnID = Personnels.PsnID.ToString(),
                                              PsnName = Personnels.PsnName
                                          }).FirstOrDefault();
                List<ChamCongHeaderServer> ChamCongHeaderViews = new List<ChamCongHeaderServer>();
                if (nhanVienCoNgayCong != null)
                {
                    var ChamCongHeader = (from ChamCongHeaders in tinhCongDbContext.ChamCongHeaders
                                          where ChamCongHeaders.PsnPrkID == nhanVienCoNgayCong.PsnPrkID
                                          select new ChamCongHeaderServer()
                                          {
                                              MngChamCongPrkID = ChamCongHeaders.MngChamCongPrkID,
                                              PsnPrkID = Convert.ToInt32(ChamCongHeaders.PsnPrkID),
                                              ThangCC = ChamCongHeaders.ThangCC,
                                              NamCC = ChamCongHeaders.NamCC
                                          }).FirstOrDefault();
                    ChamCongHeaderViews.Add(ChamCongHeader);
                }
                List<ChamCongLinesServer> ChamCongLinesViews = new List<ChamCongLinesServer>();

                if (nhanVienCoNgayCong != null)
                {

                    ChamCongLinesViews = (from ChamCongLines in tinhCongDbContext.ChamCongLines
                                          join ChamCongHeaders in tinhCongDbContext.ChamCongHeaders on ChamCongLines.MngChamCongPrkID equals ChamCongHeaders.MngChamCongPrkID
                                          where ChamCongHeaders.PsnPrkID == dayToSearch.PsnPrkID
                                          && ChamCongLines.NgayCham >= fromDay && ChamCongLines.NgayCham <= toDay
                                          select new ChamCongLinesServer()
                                          {
                                              MngChamCongPrkID = ChamCongLines.MngChamCongPrkID ?? 0,
                                              NgayCC = ChamCongLines.NgayCC,
                                              BuoiChieu = ChamCongLines.BuoiChieu,
                                              BuoiSang = ChamCongLines.BuoiSang,
                                              NgayCham = ChamCongLines.NgayCham,
                                              NgayChinhSua = ChamCongLines.NgayChinhSua
                                          }).ToList();

                }

                if (nhanVienCoNgayCong != null)
                {
                    nhanVienCoNgayCong.ChamCongHeaders = ChamCongHeaderViews;
                    nhanVienCoNgayCong.ChamCongLines = ChamCongLinesViews;
                }

                return nhanVienCoNgayCong;
            }
            catch (Exception e)
            {

                throw;
            }

        }



        public ChamCongHeaderDb? GetChamCongHeader(ChamCongHeader chamCongHeader)
        {
            return tinhCongDbContext.ChamCongHeaders.FirstOrDefault(e => e.PsnPrkID == chamCongHeader.PsnPrkID && e.ThangCC == chamCongHeader.ThangCC && e.NamCC == chamCongHeader.NamCC);
        }
        public ChamCongLineDb? GetChamCongLine(ChamCongHeader chamCongLine)
        {
            return tinhCongDbContext.ChamCongLines.FirstOrDefault(e => e.MngChamCongPrkID == chamCongLine.MngChamCongPrkID && e.NgayCC == chamCongLine.NgayCC);
        }

        public int addUpdateNgayChamCong(ChamCongHeader model)
        {
            // Lấy ChamCongHeader từ cơ sở dữ liệu
            var chamCongHeader = GetChamCongHeader(model);

            // Tạo mới ChamCongHeader nếu không tồn tại
            if (chamCongHeader == null)
            {
                chamCongHeader = new ChamCongHeaderDb()
                {
                    PsnPrkID = model.PsnPrkID,
                    ThangCC = model.ThangCC,
                    NamCC = model.NamCC,
                };
                tinhCongDbContext.ChamCongHeaders.Add(chamCongHeader);
                tinhCongDbContext.SaveChanges();
            }

            // Lấy ChamCongLine từ cơ sở dữ liệu
            var chamCongLine = GetChamCongLine(model);

            // Tạo mới ChamCongLine nếu không tồn tại
            if (chamCongLine == null)
            {
                chamCongLine = new ChamCongLineDb()
                {
                    MngChamCongPrkID = chamCongHeader.MngChamCongPrkID,
                    NgayCC = model.NgayCC,
                    BuoiSang = model.BuoiSang,
                    BuoiChieu = model.BuoiChieu,
                    NgayCham = model.NgayCham,
                    NgayChinhSua = DateTime.Now,
                };
                tinhCongDbContext.ChamCongLines.Add(chamCongLine);
            }
            else
            {
                // Cập nhật ChamCongLine nếu đã tồn tại
                chamCongLine.NgayCC = model.NgayCC;
                if (model.BuoiSang != null)
                    chamCongLine.BuoiSang = model.BuoiSang == 0 ? null : model.BuoiSang;
                if (model.BuoiChieu != null)
                    chamCongLine.BuoiChieu = model.BuoiChieu == 0 ? null : model.BuoiChieu;
                chamCongLine.NgayCham = model.NgayCham;
                chamCongLine.NgayChinhSua = DateTime.Now;
                tinhCongDbContext.ChamCongLines.Update(chamCongLine);
            }


            return tinhCongDbContext.SaveChanges();
        }




        public IEnumerable<PersonnelsDb> getsNhanVien()
        {
            return tinhCongDbContext.Personnels;
        }
        public IEnumerable<ChamCongTypeDb> getsLoaiChamCong()
        {
            return tinhCongDbContext.ChamCongTypes;
        }

        //public PersonnelsDb? layNhanvienbyEmail(string email)
        //{
        //    var acc = tinhCongDbContext.Users.Where(e => e.UserID == email);
        //    var nv1 = tinhCongDbContext.Personnels;

        //    var nhanvien = from user in userManager.Users
        //                   join nv in tinhCongDbContext.Personnels on user.PsnPrkID equals nv.PsnPrkID
        //                   where user.Email == email
        //                   select nv;
        //    return nhanvien.FirstOrDefault();
        //}

        //public ChamCongLine? getNgayCong(string MaNV, string ngay, string thang, string nam)
        //{
        //    var ngayCong = (from nc in tinhCongDbContext.ChamCongLines
        //                    where nc.MngChamCongPrkID == MaNV
        //                    && nc.NgayCham == new DateTime(Int32.Parse(nam), Int32.Parse(thang), Int32.Parse(ngay))
        //                    select nc).FirstOrDefault();
        //    if(ngayCong == null)
        //    {
        //        return null;
        //    }
        //    return new ChamCongLine()
        //    {
        //        MngChamCongPrkID = ngayCong.MngChamCongPrkID,
        //        //ThangCC = ngayCong.ThangCC,
        //        //NamCC = ngayCong.NamCC,
        //        NgayCham = ngayCong.NgayCham,
        //        //TrangThai = ngayCong.TrangThai,
        //        //Latitude = ngayCong.Latitude,
        //        //Longitude = ngayCong.Longitude,
        //        PsnPrkID = ngayCong.PsnPrkID
        //    };
        //}

        public decimal getMaChamCongHeader(int PsnPrkID, int thangcc, int namcc)
        {
            var ngayCong = (from ChamCongHeaders in tinhCongDbContext.ChamCongHeaders
                            where ChamCongHeaders.PsnPrkID == PsnPrkID && ChamCongHeaders.ThangCC == thangcc && ChamCongHeaders.NamCC == namcc
                            select ChamCongHeaders.MngChamCongPrkID).FirstOrDefault();
            return ngayCong;
        }

        public void deleteNgayChamCong(ChamCongDelete ChamCongHeader)
        {
            var ngayCongs = (from aremove in tinhCongDbContext.ChamCongLines
                             where aremove.MngChamCongPrkID == ChamCongHeader.MngChamCongPrkID && aremove.NgayCham >= ChamCongHeader.fromDay && aremove.NgayCham <= ChamCongHeader.toDay
                             select aremove);
            tinhCongDbContext.RemoveRange(ngayCongs);
            tinhCongDbContext.SaveChanges();
        }

        public int addUpdateNgayChamCongScan(double PsnPrkID, int trangThai)
        {
            var now = DateTime.Now;
            var chamCongHeaderNow = tinhCongDbContext.ChamCongHeaders.Where(e => e.PsnPrkID == (decimal)PsnPrkID && e.ThangCC == now.Month& e.NamCC == now.Year).FirstOrDefault();
            ChamCongHeader chamCongHeader = new ChamCongHeader()
            {
                MngChamCongPrkID = chamCongHeaderNow!= null ? chamCongHeaderNow.MngChamCongPrkID : 0,
                PsnPrkID = (decimal)PsnPrkID,
                ThangCC = now.Month,
                NamCC = now.Year,
                NgayCC = now.Day,
                NgayCham = now,
            };
            if (now.Hour < 12)
            {
                chamCongHeader.BuoiSang = trangThai;
            }
            else
            {
                chamCongHeader.BuoiChieu = trangThai;

            }
            return addUpdateNgayChamCong(chamCongHeader);
        }
    }
}
