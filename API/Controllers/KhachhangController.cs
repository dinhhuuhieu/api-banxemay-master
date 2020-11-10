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
    public class KhachhangController : ControllerBase
    {
        private IKhachhangBusiness _itemBusiness;
        public KhachhangController(IKhachhangBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }
        [Route("create-item")]
        [HttpPost]
        public KhachhangModel CreateItem([FromBody] KhachhangModel model)
        {
            _itemBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public KhachhangModel GetDatabyID(string id)
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
                string tenkhachhang = "";
                if (formData.Keys.Contains("tenkhachhang") && !string.IsNullOrEmpty(Convert.ToString(formData["tenkhachhang"]))) { tenkhachhang = Convert.ToString(formData["tenkhachhang"]); }
                long total = 0;
                var data = _itemBusiness.Search(page, pageSize, out total, tenkhachhang);
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

        [Route("delete-khachhang")]
        [HttpPost]
        public IActionResult Delete([FromBody] Dictionary<string, object> formData)
        {
            string makhachhang = "";
            if (formData.Keys.Contains("makhachhang") && !string.IsNullOrEmpty(Convert.ToString(formData["makhachhang"]))) { makhachhang = Convert.ToString(formData["makhachhang"]); }
            _itemBusiness.Delete(makhachhang);
            return Ok();
        }

        [Route("update-khachhang")]
        [HttpPost]
        public KhachhangModel Update([FromBody] KhachhangModel model)
        {
            _itemBusiness.Update(model);
            return model;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<KhachhangModel> GetDatabAll()
        {
            return _itemBusiness.GetDataAll();
        }
    }
}