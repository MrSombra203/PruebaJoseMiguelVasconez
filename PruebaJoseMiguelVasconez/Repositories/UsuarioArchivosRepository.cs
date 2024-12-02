using Newtonsoft.Json;
using PruebaJoseMiguelVasconez.Interfaces;
using PruebaJoseMiguelVasconez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaJoseMiguelVasconez.Repositories
{
    public class UsuarioArchivosRepository : IUsuarioRepository
    {
        private string _fileName = Path.Combine(FileSystem.AppDataDirectory, "JoseMIguelVasconez.txt");
        IEnumerable<Usuario> IUsuarioRepository.DevuelveListadoUsuario()
        {
            throw new NotImplementedException();
        }

        Usuario IUsuarioRepository.DevuelveUsuario(int telefono)
        {
            Usuario usuario = new Usuario();
            if (File.Exists(_fileName))
            {
                string json_data = File.ReadAllText(_fileName);
                usuario = JsonConvert.DeserializeObject<Usuario>(json_data);
            }
            return usuario;

        }

        bool IUsuarioRepository.CrearUsuario(Usuario usuario)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        bool IUsuarioRepository.ActualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        bool IUsuarioRepository.EliminarUsuario(int telefono)
        {
            throw new NotImplementedException();
        }
    }
}
