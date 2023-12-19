using API_DAL_BLL.Models.DTO;
using DAL.Entities;

namespace API_DAL_BLL.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
            };
        }
    }
}
