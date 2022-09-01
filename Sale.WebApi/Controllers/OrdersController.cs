using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class OrdersController : ControllerBase
    {
        IAddCardService _service;

        public OrdersController(IAddCardService service)
        {
            _service = service;
        }
        [HttpGet("getAllDetail")]
        public IActionResult GetDetail()
        {
            string orderNumber = null;
           var result = _service.GetAlls(orderNumber);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getOrderCount")]
        public IActionResult GetDetailCount()
        {
            var result = _service.GetAlls(null);
            if (result.Success)
            {
                var count=new CountDTO() {Success=true, Count = result.Data.Count };
                return Ok(count);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getAllDetailById")]
        public IActionResult GetDetailByNumber(int orderId)
        {
            var result = _service.GetById(orderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(CartItems entity)
        {
            var result=_service.Update(entity);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("update")]
        public IActionResult Update(CartItems entity)
        {
            var result = _service.Add(entity);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(CartItems entity)
        {
            var result = _service.Delete(entity);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
    }
}


//swagger
