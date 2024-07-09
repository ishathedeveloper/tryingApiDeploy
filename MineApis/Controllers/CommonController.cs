using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using static DAL.BO.CommonBO;

namespace MineApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {

        private readonly ICommon _common;
        public CommonController(ICommon common)
        {
            _common = common;
        }

        [HttpPost("/api/manageUserDetails")]
        public ApiResponse manageUserDetails(UserMasterBO userMaster)
        {
            return _common.manageUserDetails(userMaster);
        }

        [HttpGet("/api/getAllUsers")]
        public ApiResponse getAllUsers()
        {
            return _common.getAllUsers();
        }

    }
}
