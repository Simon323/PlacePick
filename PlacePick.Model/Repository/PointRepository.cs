using PlacePick.DBContextRepository.Repository;
using PlacePick.Model.EntityModel;
using PlacePick.Model.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacePick.Model.Repository
{
    public class PointRepository : BaseDbContextRepository<Point, PlacePickEntities>, IPointRepository
    {
    }
}
