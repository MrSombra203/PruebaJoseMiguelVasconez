using PruebaJoseMiguelVasconez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaJoseMiguelVasconez.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> DevuelveListadoUsuario();
        Usuario DevuelveUsuario(int telefono);
        bool CrearUsuario(Usuario usuario);
        bool ActualizarUsuario(Usuario usuario);
        bool EliminarUsuario(int telefono);
    }
}
