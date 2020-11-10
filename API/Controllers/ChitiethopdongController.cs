using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChitiethopdongController : ControllerBase
    {
        private IChitiethopdongBusiness _itemBusiness;
        public ChitiethopdongController(IChitiethopdongBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }
        [Route("create-item")]
        [HttpPost]
        public ChitiethopdongModel CreateItem([FromBody] ChitiethopdongModel model)
        {
            _itemBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public ChitiethopdongModel GetDatabyID(string id)
        {
            return _itemBusiness.GetDatabyID(id);
        }

        [Route("search")]
        [HttpPost]
        public ResponseModel Search([FromBody] Dictionary<string, object> formData)
        {
            var response = new ResponseModel();
            try
            {
                var page = int.Parse(formData["page"].ToString());
                var pageSize = int.Parse(formData["pageSize"].ToString());
                string mahopdong = "";
                if (formData.Keys.Contains("mahopdong") && !string.IsNullOrEmpty(Convert.ToString(formData["mahopdong"]))) { mahopdong = Convert.ToString(formData["mahopdong"]); }
                long total = 0;
                var data = _itemBusiness.Search(page, pageSize, out total, mahopdong);
                response.TotalItems = total;
                response.Data = data;
                response.Page = page;
                response.PageSize = pageSize;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return response;
        }

        [Route("delete-Chitiethopdong")]
        [HttpPost]
        public IActionResult Delete([FromBody] Dictionary<string, object> formData)
        {
            string mahopdong = "";
            if (formData.Keys.Contains("mahopdong") && !string.IsNullOrEmpty(Convert.ToString(formData["mahopdong"]))) { mahopdong = Convert.ToString(formData["mahopdong"]); }
            _itemBusiness.Delete(mahopdong);
            return Ok();
        }

        [Route("update-Chitiethopdong")]
        [HttpPost]
        public ChitiethopdongModel Update([FromBody] ChitiethopdongModel model)
        {
            _itemBusiness.Update(model);
            return model;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<ChitiethopdongModel> GetDatabAll()
        {
            return _itemBusiness.GetDataAll();
        }
    }
}