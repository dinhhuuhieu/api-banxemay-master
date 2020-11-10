using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface INhasanxuatBusiness
    {
        bool Update(NhasanxuatModel model);
        bool Delete(string id);
        bool Create(NhasanxuatModel model);
        NhasanxuatModel GetDatabyID(string id);
        List<NhasanxuatModel> Search(int pageIndex, int pageSize, out long total, string manhasanxuat);
        List<NhasanxuatModel> GetDataAll();
    }
}