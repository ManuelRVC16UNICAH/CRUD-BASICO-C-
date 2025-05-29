using Pruebas_diarias.Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_diarias.Capa_Logica
{
    public class PerroBO
    {
        public void Agregar(Perro p) => PerroDAO.Agregar(p);
        public void Editar(Perro p) => PerroDAO.Editar(p);
        public void Eliminar(int id) => PerroDAO.Eliminar(id);
        public List<Perro> Buscar(string nombre) => PerroDAO.Buscar(nombre);
        public List<Perro> Listar() => PerroDAO.Listar();
    }
}
