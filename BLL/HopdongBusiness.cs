using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class HopdongBusiness : IHopdongBusiness
    {
        private IHopdongRepository _res;
        public HopdongBusiness(IHopdongRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(HopdongModel model)
        {
            return _res.Update(model);
        }
        public bool Create(HopdongModel model)
        {
            return _res.Create(model);
        }
        public HopdongModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<HopdongModel> Search(int pageIndex, int pageSize, out long total, string mahopdong)
        {
            return _res.Search(pageIndex, pageSize, out total, mahopdong);
        }
        public List<HopdongModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}