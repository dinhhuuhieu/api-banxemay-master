using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface ISanphamBusiness
    {
        bool Update(SanphamModel model);
        bool Delete(string id);
        bool Create(SanphamModel model);
        SanphamModel GetDatabyID(string id);
        List<SanphamModel> Search(int pageIndex, int pageSize, out long total, string masanpham);
        List<SanphamModel> GetDataAll();
    }
}