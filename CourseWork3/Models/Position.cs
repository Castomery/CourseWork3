using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork3.Models
{
    public class Position
    {

        public Position(int id, string positionName)
        {
            Id = id;
            PositionName = positionName;
        }

        public int Id { get; }
        public string PositionName { get; }
    }
}
