using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IGetUserListService
    {
        List<UserDto> Execute();
    }
    public class GetUserListServices : IGetUserListService
    {
        private readonly IDatabaseContext _context;

        public GetUserListServices(IDatabaseContext context)
        {
            _context = context;
        }

        public List<UserDto> Execute()
        {
            return _context.Users.Select(p => new UserDto
            {
                Id = p.Id,
                UserName = p.UserName

            }).ToList();
        }


    }
    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }
    }
}
