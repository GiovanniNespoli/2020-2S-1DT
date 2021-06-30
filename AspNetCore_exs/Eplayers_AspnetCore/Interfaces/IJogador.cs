using System.Collections.Generic;
using Eplayers_AspnetCore.Models;

namespace Interfaces
{
    public interface IJogador
    {
        // CRUD

        void Create(Jogador x);
        List<Jogador> ReadAll();
        void Update(Jogador x);
        void Delete(int x);
    }
}