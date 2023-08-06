using FBSApp.Models.DTOs.Staff;
using FBSApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FBSApp.Controllers
{
    [ApiController]
    [Route("api/staff")]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        /// <summary>
        /// [Anonymous] Gets players in list view
        /// </summary>
        [HttpPost(Name = "GetAllStaff")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<StaffGroupDTO>> GetAllStaff()
        {
            return Ok(_staffService.GetAll());
        }
    }
}
