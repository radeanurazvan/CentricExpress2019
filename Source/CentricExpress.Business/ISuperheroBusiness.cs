using System.Collections.Generic;
using CentricExpress.Business.Models;

namespace CentricExpress.Business
{
    public interface ISuperheroBusiness
    {
        IReadOnlyCollection<SuperheroModel> Get();

        void Add(SuperheroModel model);
    }
}
