using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class HangmanEntity
    { 
        private bool head = false;
        private bool torso = false;
        private bool left_arm = false;
        private bool right_arm = false;
        private bool left_leg = false;
        private bool right_leg = false;
          
        public bool bpHead
        {
            get { return head; }
            set { head = value; }
        }
        public bool bpTorso
        {
            get { return torso; }
            set { torso = value; }
        }
        public bool bpLeft_Arm
        {
            get { return left_arm; }
            set { left_arm = value; }
        }
        public bool bpRight_Arm
        {
            get { return right_arm; }
            set { right_arm = value; }
        }
        public bool bpLeft_Leg
        {
            get { return left_leg; }
            set { left_leg = value; }
        }
        public bool bpRight_Leg
        {
            get { return right_leg; }
            set { right_leg = value; }
        } 
    }
}
