using System;
using System.Collections.Generic;
using System.Text;
using CentricExpress.Api.Models;

namespace CentricExpress.Business
{
    public interface ISuperHeroBusinessLogic
    {
        List<SuperheroModel> Get();

        void Create(SuperheroModel model);

        bool LevelUp(Guid id, int power);
    }
}
