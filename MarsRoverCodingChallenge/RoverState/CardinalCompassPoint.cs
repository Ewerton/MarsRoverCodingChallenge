using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.RoverState
{
    public enum CardinalCompassPoint
    {
        [Display(Name = "North")]
        North,

        [Display(Name = "East")]
        East,

        [Display(Name = "South")]                
        South,

        [Display(Name = "West")]
        West
    }
}
