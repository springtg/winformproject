using System;
using System.Collections.Generic;
using System.Text;

namespace FlexCDC.FOB.CBDExcel.V_1_220
{
    class CBDEventArgs : EventArgs
    {
        private int step = 0;
        private int status = 0;

        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
