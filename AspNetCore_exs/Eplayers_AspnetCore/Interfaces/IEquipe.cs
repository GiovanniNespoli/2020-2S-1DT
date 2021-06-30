using System.Collections.Generic;
using Eplayers_AspnetCore.Models;

namespace Eplayers_AspnetCore.Interfaces
{
    public interface IEquipe
    {
        //CRUD!!!!

        void Create(Equipe x);
        List<Equipe> ReadAll();
        void uptade(Equipe x);
        void Delete(int id);
    }
}