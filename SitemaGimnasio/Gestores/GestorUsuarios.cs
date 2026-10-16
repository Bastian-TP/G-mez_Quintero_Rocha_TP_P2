
using SistemaGimnaso.Modelos;

namespace SitemaGimnasio.Gestores
{
    internal class GestorUsuarios
    {
        private List<Usuario> usuarios;
        public GestorUsuarios()
        {
            usuarios = new List<Usuario>();
        }
        public void RegistrarUsuario(string nombre, int edad, string objetivo)
        {
            usuario.Add(new Usuario(nombre, edad, objetivo));

        }
        public Usuario BusarUsuario(string nombre)
        {
            return usuarios.FirstOrDefault(uint => uint.Nombre == nombre);
        }
    }
}
