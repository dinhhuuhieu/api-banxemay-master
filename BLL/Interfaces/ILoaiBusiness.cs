using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface ILoaiBusiness
    {
        bool Update(LoaiModel model);
        bool Delete(string id);
        bool Create(LoaiModel model);
        LoaiModel GetDatabyID(string id);
        List<LoaiModel> Search(int pageIndex, int pageSize, out long total, string maloai);
        List<LoaiModel> GetDataAll();
    }
}