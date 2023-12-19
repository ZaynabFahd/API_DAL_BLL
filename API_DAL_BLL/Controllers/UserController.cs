using API_DAL_BLL.Mappers;
using API_DAL_BLL.Models.DTO;
using BLL.Interfaces;
using BLL.Models.FormUser;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DAL_BLL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpGet]
        public ActionResult<IEnumerable<UserDTO>> GetAll()
        {
            return Ok(_userService.GetAll().Select(x => x.ToDTO()));
        }

        [HttpPost]
        public ActionResult<UserDTO> Create(CreateUserForm form)
        {
            User? user = _userService.Create(form);

            if (user is null)
            {
                return BadRequest();
            }

            return Ok(user);
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<UserDTO> GetById(int id)
        {
            User? user = _userService.GetById(id);

            return user is null ? NotFound() : Ok(user.ToDTO());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            return _userService.Delete(id) ? NoContent() : BadRequest();
        }

        [HttpPut]
        [Route("{id:int}")]
        public ActionResult Update(int id, UpdateUserForm form)
        {
            return _userService.Update(id, form) ? NoContent() : BadRequest();
        }
    }
}
