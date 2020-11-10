using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class LoaiBusiness : ILoaiBusiness
    {
        private ILoaiRepository _res;
        public LoaiBusiness(ILoaiRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(LoaiModel model)
        {
            return _res.Update(model);
        }
        public bool Create(LoaiModel model)
        {
            return _res.Create(model);
        }
        public LoaiModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<LoaiModel> Search(int pageIndex, int pageSize, out long total, string maloai)
        {
            return _res.Search(pageIndex, pageSize, out total, maloai);
        }
        public List<LoaiModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}