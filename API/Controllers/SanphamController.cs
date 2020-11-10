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
    public class SanphamController : ControllerBase
    {
        private ISanphamBusiness _itemBusiness;
        public SanphamController(ISanphamBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }
        [Route("create-item")]
        [HttpPost]
        public SanphamModel CreateItem([FromBody] SanphamModel model)
        {
            _itemBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public SanphamModel GetDatabyID(string id)
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
                string masanpham = "";
                if (formData.Keys.Contains("masanpham") && !string.IsNullOrEmpty(Convert.ToString(formData["masanpham"]))) { masanpham = Convert.ToString(formData["masanpham"]); }
                long total = 0;
                var data = _itemBusiness.Search(page, pageSize, out total, masanpham);
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

        [Route("delete-Sanpham")]
        [HttpPost]
        public IActionResult Delete([FromBody] Dictionary<string, object> formData)
        {
            string masanpham = "";
            if (formData.Keys.Contains("masanpham") && !string.IsNullOrEmpty(Convert.ToString(formData["masanpham"]))) { masanpham = Convert.ToString(formData["masanpham"]); }
            _itemBusiness.Delete(masanpham);
            return Ok();
        }

        [Route("update-Sanpham")]
        [HttpPost]
        public SanphamModel Update([FromBody] SanphamModel model)
        {
            _itemBusiness.Update(model);
            return model;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<SanphamModel> GetDatabAll()
        {
            return _itemBusiness.GetDataAll();
        }
    }
}