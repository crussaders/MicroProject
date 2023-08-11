using Micro.Services.CouponAPI.Data;
using Micro.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Micro.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly StoreContext _db;
        public CouponAPIController(StoreContext db)
        {   
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;

            }
            catch (Exception ex)
            {

            }
            return null;
        }

        [HttpGet]
        [Route("{id:int}")]
        public object GetById(int id)
        {
            try
            {
                Coupon objList = _db.Coupons.First(u=>u.CouponId==id);
                return objList;

            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
