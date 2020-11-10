using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class SanphamBusiness : ISanphamBusiness
    {
        private ISanphamRepository _res;
        public SanphamBusiness(ISanphamRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(SanphamModel model)
        {
            return _res.Update(model);
        }
        public bool Create(SanphamModel model)
        {
            return _res.Create(model);
        }
        public SanphamModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<SanphamModel> Search(int pageIndex, int pageSize, out long total, string masanpham)
        {
            return _res.Search(pageIndex, pageSize, out total, masanpham);
        }
        public List<SanphamModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}