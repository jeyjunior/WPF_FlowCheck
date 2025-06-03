using FlowCheck.Domain.Entidades;
using FlowCheck.Domain.Interfaces;
using JJ.Net.CrossData.Interfaces;
using JJ.Net.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCheck.InfraData.Repository
{
    public class AnotacaoRepository : Repository<Anotacao>, IAnotacaoRepository
    {
        public AnotacaoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
