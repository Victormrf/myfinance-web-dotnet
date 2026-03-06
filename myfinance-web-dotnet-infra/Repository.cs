using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfinance_web_dotnet_infra
{
    public abstract class Repository<TEntity> : MyFinanceDbContext,IRepository<TEntity> where TEntity : class
    {
        protected Repository(MyFinanceDbContext context) : base()
        {
        }
        public void Cadastrar(TEntity Entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> ListarRegistros()
        {
            throw new NotImplementedException();
        }

        public TEntity RetornarRegistro(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}