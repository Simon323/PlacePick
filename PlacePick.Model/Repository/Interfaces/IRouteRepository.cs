using PlacePick.Model.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacePick.Model.Repository.Interfaces
{
    public interface IRouteRepository
    {
        void Add(Route route);
        void Save();
    }
}
