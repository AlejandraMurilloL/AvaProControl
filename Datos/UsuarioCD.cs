using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class UsuarioCD
    {
        public Users GetUsuarioLogin(string usuario, string contraseña)
        {            
            using (AvaProEntities dbContext = new AvaProEntities())
            {
                Users user = null;
                try
                {
                    user = dbContext.Users.Where(x => x.User == usuario && x.Password == contraseña).FirstOrDefault();
                }
                catch (Exception e)
                {
                    string error = e.ToString();                    
                }
                 
                return user;

            }
        }

        public bool SaveUser(Users user)
        {
            using (AvaProEntities dbContext = new AvaProEntities())
            {
                try
                {
                    Users userBD = dbContext.Users.Where(x => x.UserID == user.UserID).FirstOrDefault();
                    if (userBD != null)
                    {
                        userBD.FirstName = user.FirstName;
                        userBD.LastName = user.LastName;
                        userBD.User = user.User;
                        userBD.Password = user.Password;
                        userBD.Email = user.Email;
                        userBD.Gender = user.Gender;
                        userBD.Ocupation = user.Ocupation;
                        userBD.Profile = user.Profile;
                        userBD.ProfilePicture = user.ProfilePicture;
                    }
                    else
                    {
                        dbContext.Users.Add(user);
                    }
                    
                    dbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }    

            }
        }

    }
}
