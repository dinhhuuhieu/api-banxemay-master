using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IHopdongBusiness
    {
        bool Update(HopdongModel model);
        bool Delete(string id);
        bool Create(HopdongModel model);
        HopdongModel GetDatabyID(string id);
        List<HopdongModel> Search(int pageIndex, int pageSize, out long total, string mahopdong);
        List<HopdongModel> GetDataAll();
    }
}