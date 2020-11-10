using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IKhachhangBusiness
    {
        bool Update(KhachhangModel model);
        bool Delete(string id);
        bool Create(KhachhangModel model);
        KhachhangModel GetDatabyID(string id);
        List<KhachhangModel> Search(int pageIndex, int pageSize, out long total, string tenkhachhang);
        List<KhachhangModel> GetDataAll();
    }
}