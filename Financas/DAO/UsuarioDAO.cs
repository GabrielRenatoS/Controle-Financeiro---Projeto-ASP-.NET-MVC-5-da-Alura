using Financas.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Financas.DAO
{
    public class UsuarioDAO 
    {
        private FinancasContext context;

        public UsuarioDAO(FinancasContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void Remove(Usuario usuario)
        {
            context.Entry(usuario).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public IList<Usuario> Lista() {
            return context.Usuarios.ToList();
        }
    }
}