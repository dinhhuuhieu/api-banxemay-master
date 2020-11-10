using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class NhasanxuatBusiness : INhasanxuatBusiness
    {
        private INhasanxuatRepository _res;
        public NhasanxuatBusiness(INhasanxuatRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(NhasanxuatModel model)
        {
            return _res.Update(model);
        }
        public bool Create(NhasanxuatModel model)
        {
            return _res.Create(model);
        }
        public NhasanxuatModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<NhasanxuatModel> Search(int pageIndex, int pageSize, out long total, string manhasanxuat)
        {
            return _res.Search(pageIndex, pageSize, out total, manhasanxuat);
        }
        public List<NhasanxuatModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}