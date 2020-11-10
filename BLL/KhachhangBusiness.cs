using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class KhachhangBusiness : IKhachhangBusiness
    {
        private IKhachhangRepository _res;
        public KhachhangBusiness(IKhachhangRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(KhachhangModel model)
        {
            return _res.Update(model);
        }
        public bool Create(KhachhangModel model)
        {
            return _res.Create(model);
        }
        public KhachhangModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<KhachhangModel> Search(int pageIndex, int pageSize, out long total, string tenkhachhang)
        {
            return _res.Search(pageIndex, pageSize, out total, tenkhachhang);
        }
        public List<KhachhangModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}