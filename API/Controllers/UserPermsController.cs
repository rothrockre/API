using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkoutDataAccess;
using static API.Models.DataManager.AppManager;

namespace API.Controllers
{
    public class UserPermsController : ApiController
    {
        //return all users
        public IEnumerable<UserPerm> Get()
        {
            using (WorkoutEntities1 user = new WorkoutEntities1())
            {
                return user.UserPerms.ToList();
            }
        }

        //return specific user by username
        public UserPerm Get(string username)
        {
            using(WorkoutEntities1 user = new WorkoutEntities1())
            {
                return user.UserPerms.FirstOrDefault(o => o.Username.Equals(username));
            }
        }

        public UserViewModel GetUserByEmail(string email)
        {

            using (WorkoutEntities1 user = new WorkoutEntities1())
            {
                //return user.UserPerms.FirstOrDefault(o => o.Email.Equals(email));
                var result = (from c in user.UserPerms
                              where c.Email.ToLower().Equals(email.ToLower())
                              select new UserViewModel
                              {
                                  UserID = c.UserID,
                                  Username = c.Username,
                                  Password = c.Password,
                                  PaidUser = c.PaidUser,
                                  CreateDate = c.CreateDate,
                                  LastUser = c.LastUser,
                                  Height = c.Height,
                                  Weight = c.Weight,
                                  Lbs_Kilos = c.Lbs_Kilos,
                                  Email = c.Email

                              });//user is the db
                if (result.Any())
                {
                    return result.SingleOrDefault();
                }
            }
            return new UserViewModel();
        }

        public int GetUserID(string email)
        {
            using (WorkoutEntities1 db = new WorkoutEntities1())
            {
                var data = db.UserPerms.Where(o => o.Email.ToLower().Equals(email.ToLower()));
                if (data.Any())
                {
                    return data.FirstOrDefault().UserID;
                }
                return 0;
            }
        }


    }
}
