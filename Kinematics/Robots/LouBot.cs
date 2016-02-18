﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinematics.Robots
{
    class LouBot : CoupledShoulder3DOF
    {
        public LouBot()
        {
            this.ShoulderOffset = 17.78;
            this.LengthUpperArm = 68.58;
            this.LengthForearm = 96.393;
            this.Theta1Max = 45;
            this.Theta1Min = -90;
            this.Theta2Max = 5;
            this.Theta2Min = -90;
            this.Theta3Max = 95;
            this.Theta3Min = 0;
        }
    }
}
