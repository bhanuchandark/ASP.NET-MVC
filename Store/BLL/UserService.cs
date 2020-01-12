using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BOL;

namespace BLL {
    public class UserService {

        // Validate User
        public static User ValidateUser(string email,string password) {
            User user = UserRepo.GetUser(email);
            if (user != null) {
                if(user.Password == password) {
                
                    return user;
                }
                else {
                    return null;
                }
            }
            return null;
        }
    }
}
