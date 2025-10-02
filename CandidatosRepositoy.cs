using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class CandidatosRepositoy : ICandidatosRepository

    {
        private readonly List<Candidatos> _candidatos = new();
        public void Adicionar(Candidatos candidatos)
        {
            _candidatos.Add(candidatos);

        }


        public bool ExisteNumeoProjeto(int NumProjeto)
        {
            throw new NotImplementedException();
        }

        public List<Candidatos> GetAll()
        {
            return _candidatos;
        }

    
    }

}