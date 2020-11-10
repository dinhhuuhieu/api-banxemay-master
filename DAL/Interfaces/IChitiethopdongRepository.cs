using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IChitiethopdongRepository
    {
        bool Create(ChitiethopdongModel model);
        bool Update(ChitiethopdongModel model);
        bool Delete(string id);
        ChitiethopdongModel GetDatabyID(string id);
        List<ChitiethopdongModel> GetDataAll();
        List<ChitiethopdongModel> Search(int pageIndex, int pageSize, out long total, string mahopdong);
    }
}