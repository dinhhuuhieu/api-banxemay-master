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
    public class NhasanxuatController : ControllerBase
    {
        private INhasanxuatBusiness _itemBusiness;
        public NhasanxuatController(INhasanxuatBusiness itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }
        [Route("create-item")]
        [HttpPost]
        public NhasanxuatModel CreateItem([FromBody] NhasanxuatModel model)
        {
            _itemBusiness.Create(model);
            return model;
        }

        [Route("get-by-id/{id}")]
        [HttpGet]
        public NhasanxuatModel GetDatabyID(string id)
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
                string manhasanxuat = "";
                if (formData.Keys.Contains("manhasanxuat") && !string.IsNullOrEmpty(Convert.ToString(formData["manhasanxuat"]))) { manhasanxuat = Convert.ToString(formData["manhasanxuat"]); }
                long total = 0;
                var data = _itemBusiness.Search(page, pageSize, out total, manhasanxuat);
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

        [Route("delete-Nhasanxuat")]
        [HttpPost]
        public IActionResult Delete([FromBody] Dictionary<string, object> formData)
        {
            string maNhasanxuat = "";
            if (formData.Keys.Contains("manhasanxuat") && !string.IsNullOrEmpty(Convert.ToString(formData["manhasanxuat"]))) { maNhasanxuat = Convert.ToString(formData["manhasanxuat"]); }
            _itemBusiness.Delete(maNhasanxuat);
            return Ok();
        }

        [Route("update-Nhasanxuat")]
        [HttpPost]
        public NhasanxuatModel Update([FromBody] NhasanxuatModel model)
        {
            _itemBusiness.Update(model);
            return model;
        }

        [Route("get-all")]
        [HttpGet]
        public IEnumerable<NhasanxuatModel> GetDatabAll()
        {
            return _itemBusiness.GetDataAll();
        }
    }
}