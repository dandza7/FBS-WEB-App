using FBSApp.Models.DTOs;
using FBSApp.Models.DTOs.Award;
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
        /// [Anonymous] Gets staff in list view
        /// </summary>
        [HttpGet("{page}/{pageSize}", Name = "GetAllStaff")]
        [AllowAnonymous]
        public ActionResult<PaginationWrapper<StaffDTO>> GetAllStaff(int page, int pageSize)
        {
            return Ok(_staffService.GetAll(page, pageSize));
        }

        /// <summary>
        /// [Anonymous] Gets staff by id
        /// </summary>
        [HttpGet("{id}", Name = "GetOneStaff")]
        [AllowAnonymous]
        public ActionResult<StaffDTO> GetOneStaff(long id)
        {
            return Ok(_staffService.GetOne(id));
        }

        /// <summary>
        /// [Anonymous] Gets staff employments
        /// </summary>
        [HttpGet("{id}/employments", Name = "GetAllStaffEmployments")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<TeamEmploymentDTO>> GetAllStaffEmployments(long id)
        {
            return Ok(_staffService.GetEmployments(id));
        }

        /// <summary>
        /// [Anonymous] Gets staff awards
        /// </summary>
        [HttpGet("{id}/awards", Name = "GetStaffAwards")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<AwardDTO>> GetStaffAwards(long id)
        {
            return Ok(_staffService.GetStaffAwards(id));
        }
    }
}
