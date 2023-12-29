using Recruit.Server.Models;
using Recruit.Server.Models.ModelView;
using Recruit.Shared;
using Recruit.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Client.Services
{
    public interface ITinhCongService
    {
        Task<int> updateTinhNgayCong(ChamCongHeader ngayCong);
        Task DeleteNgayCong(decimal? ngayCong, DateTime fromDay, DateTime toDay);
        Task<List<NgayCong?>> layNgayCongToanBoNV(DayToSearch dayToSearch);
        Task<List<NgayCong>> getsNhanVien();
        Task<List<ChamCongType>> getsLoaiChamCong();
        Task<ChamCongHeader?> getNgayCong(string MaNV, string ngay, string thang, string nam);
        Task<NgayCong> layNhanvienbyEmail(string email);
        Task<decimal> getMaChamCongHeader(int PsnPrkID,int thangcc, int namcc);
    }
}
