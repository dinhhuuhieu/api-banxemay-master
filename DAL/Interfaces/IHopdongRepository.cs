using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IHopdongRepository
    {
        bool Create(HopdongModel model);
        bool Update(HopdongModel model);
        bool Delete(string id);
        HopdongModel GetDatabyID(string id);
        List<HopdongModel> GetDataAll();
        List<HopdongModel> Search(int pageIndex, int pageSize, out long total, string mahopdong);
    }
}