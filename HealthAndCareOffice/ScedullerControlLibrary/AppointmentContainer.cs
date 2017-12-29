using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScedullerControlLibrary
{
    class AppointmentContainer : Panel
    {
        public int Hour { get; set; }
        public int Mins { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }

        public Label nameLabel;
        public Label time;
        public Button showAppointmentButton;

        public AppointmentContainer()
        {
            nameLabel = new Label();
            nameLabel.Text = "Hello";
            nameLabel.SetBounds(0, 0, Width - 20, 15);
        }

        public AppointmentContainer(string name, int hour, int mins,int height)
        {

        }
    }
}
