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

            string pass = EncriptarContraseña(contraseña);
            return user.GetUsuarioLogin(usuario, pass);         
            
        }

        public static bool SaveUser(Users user)
        {
            UsuarioCD userCD = new UsuarioCD();

            return userCD.SaveUser(user);
        }

        public static string RecuperarContraseña(string usuarioOrEmail)
        {
            UsuarioCD userCD = new UsuarioCD();

            string caracteres = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder res = new StringBuilder();
            Random rd = new Random();
            int longuitudContraseña = 10;
            while (0 < longuitudContraseña--)
            {
                res.Append(caracteres[rd.Next(caracteres.Length)]);
            }
            string nuevaContraseña = res.ToString();

            string pass = EncriptarContraseña(nuevaContraseña);

            Users user = userCD.RecuperarContraseña(usuarioOrEmail, pass);

            if (user != null)
            {
                var mailService = new Datos.MailServices.SystemSupportMail();
                mailService.SendMail(subject: "SISTEMA: Solicitud de recuperación de contraseña",
                    body: "Hola, " + user.FirstName + "\n Hemos revisado su solicitud de recuperación de contraseña. \n\n Su nueva contraseña es: " + nuevaContraseña + " \n Sin embargo, le pedimos que lacambie una vez ingrese al sistema. ",
                    recipientEmail: new List<string> { user.Email }
                );

                return "Hola, " + user.FirstName + "\n Ya tramitamos su solicitud de recuperación de contraseña \n Por favor, revise su bandeja de entrada \n Sin embargo, le pedimos que lacambie una vez ingrese al sistema";
            }
            else
            {
                return "Lo sentimos usted no tiene una cuenta registrada con este nombre de usuario o correo electronico";
            }               

            
        }

        public static string CambiarContraseña(Users user, string contraseñaNueva)
        {
            UsuarioCD userCD = new UsuarioCD();            

            string pass = EncriptarContraseña(contraseñaNueva);
            user.Password = EncriptarContraseña(user.Password);
            bool cambioExitoso = userCD.CambiarContraseña(user, pass);

            string mensaje;

            if (cambioExitoso)
            {
                mensaje = "El cambio se realizó satisfactoriamente.";
            }
            else
            {
                mensaje = "La  contraseña actual ingresada no es correcta, intente nuevamente.";
            }

            return mensaje;

        }

        private static string EncriptarContraseña(string contraseña)
        {
            string pssResult = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contraseña);
            pssResult = Convert.ToBase64String(encryted);
            return pssResult;
        }
    }
}
