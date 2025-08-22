using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Stone_Evan
{
    internal interface IBootUp
    {

        public bool IsOn { get; set; } //get and sets the public bool IsOn

        public void PowerOnOff(); //creates PowerOnOff

    }
}
