using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class ChitiethopdongBusiness : IChitiethopdongBusiness
    {
        private IChitiethopdongRepository _res;
        public ChitiethopdongBusiness(IChitiethopdongRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(ChitiethopdongModel model)
        {
            return _res.Update(model);
        }
        public bool Create(ChitiethopdongModel model)
        {
            return _res.Create(model);
        }
        public ChitiethopdongModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<ChitiethopdongModel> Search(int pageIndex, int pageSize, out long total, string tenchitiethopdong)
        {
            return _res.Search(pageIndex, pageSize, out total, tenchitiethopdong);
        }
        public List<ChitiethopdongModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}