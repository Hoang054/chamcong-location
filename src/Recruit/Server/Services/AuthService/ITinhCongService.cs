
using Recruit.Server.Models;
using Recruit.Server.Models.ModelView;
using Recruit.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recruit.Server.Services.AuthService
{
    public interface ITinhCongService
    {
        //int tinhNgayCong(ChamCongLine ngayCong);
        IEnumerable<NgayCongServer?> layNgayCongToanBoNV(DayToSearch dayToSearch);
        ChamCongHeaderDb GetChamCongHeader(ChamCongHeader ngayCong);
        int addUpdateNgayChamCong(ChamCongHeader model);
        int addUpdateNgayChamCongScan(double PsnPrkID, int trangThai);
        void deleteNgayChamCong(ChamCongDelete ChamCongHeader);
        //NgayCongView? getNgayCongsCommon(DayToSearch dayToSearch);
        IEnumerable<PersonnelsDb> getsNhanVien();
        IEnumerable<ChamCongTypeDb> getsLoaiChamCong();
        //PersonnelsDb layNhanvienbyEmail(string email);
        decimal getMaChamCongHeader(int PsnPrkID, int thangcc, int namcc);
        //ChamCongLine getNgayCong(string MaNV, string ngay, string thang, string nam);
    }
}
