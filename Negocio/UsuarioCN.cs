using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Drawing;
using System.Resources;

namespace Negocio
{
    public class UsuarioCN
    {
        public static Users GetUsuarioLogin(string usuario, string contraseña)
        {
            UsuarioCD user = new UsuarioCD();

            string pssResult = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contraseña);
            pssResult = Convert.ToBase64String(encryted);
            return user.GetUsuarioLogin(usuario, pssResult);         
            
        }

        public static bool SaveUser(Users user)
        {
            UsuarioCD userCD = new UsuarioCD();

            return userCD.SaveUser(user);
        }
    }
}
