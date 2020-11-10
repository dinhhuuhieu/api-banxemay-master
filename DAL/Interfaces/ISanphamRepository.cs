using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface ISanphamRepository
    {
        bool Create(SanphamModel model);
        bool Update(SanphamModel model);
        bool Delete(string id);
        SanphamModel GetDatabyID(string id);
        List<SanphamModel> GetDataAll();
        List<SanphamModel> Search(int pageIndex, int pageSize, out long total, string masanpham);
    }
}