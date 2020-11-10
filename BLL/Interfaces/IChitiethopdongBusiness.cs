using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IChitiethopdongBusiness
    {
        bool Update(ChitiethopdongModel model);
        bool Delete(string id);
        bool Create(ChitiethopdongModel model);
        ChitiethopdongModel GetDatabyID(string id);
        List<ChitiethopdongModel> Search(int pageIndex, int pageSize, out long total, string tenchitiethopdong);
        List<ChitiethopdongModel> GetDataAll();
    }
}