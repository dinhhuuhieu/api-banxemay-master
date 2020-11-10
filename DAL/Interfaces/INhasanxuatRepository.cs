using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface INhasanxuatRepository
    {
        bool Create(NhasanxuatModel model);
        bool Update(NhasanxuatModel model);
        bool Delete(string id);
        NhasanxuatModel GetDatabyID(string id);
        List<NhasanxuatModel> GetDataAll();
        List<NhasanxuatModel> Search(int pageIndex, int pageSize, out long total, string manhasanxuat);
    }
}