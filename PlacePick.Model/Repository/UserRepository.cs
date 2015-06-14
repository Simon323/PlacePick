using PlacePick.DBContextRepository.Repository;
using PlacePick.Model.EntityModel;
using PlacePick.Model.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacePick.Model.Repository
{
    public class UserRepository : BaseDbContextRepository<User, PlacePickEntities>, IUserRepository
    {
        public User getByASPUserEmail(string email)
        {
            return Entities.AspNetUsers.Where(x => x.Email == email).FirstOrDefault().Users.FirstOrDefault();
        }
    }
}
