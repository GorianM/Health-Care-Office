using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthAndCareOffice
{
    class AppointmentCalendar : Panel
    {
        TableLayoutPanel appointmentTable;
        Label[] timeStamps;

        
        public AppointmentCalendar(Control parent)
        {


            this.Parent = parent;
            this.SetBounds(0, 0, parent.Width, Parent.Height);
            this.Visible = true;
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            setupTablelayout(parent);
            setupTimestumps();
            
        }

        private void setupTimestumps()
        {
            int hour = 6;

            timeStamps = new Label[appointmentTable.RowCount];
            for (int i = 0; i < appointmentTable.RowCount; i++)
            {
                timeStamps[i] = new Label();
                if (hour < 10)
                    timeStamps[i].Text = "0" + hour + ":00";
                else
                    timeStamps[i].Text = hour + ":00";

                hour++;
                timeStamps[i].Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                timeStamps[i].TextAlign = ContentAlignment.MiddleCenter;
                appointmentTable.Controls.Add(timeStamps[i], 0, i);
            }
        }

        private void setupTablelayout(Control parent)
        {
            appointmentTable = new TableLayoutPanel();
            appointmentTable.Parent = this;
            appointmentTable.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            appointmentTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            appointmentTable.ColumnCount = 8;
            for (int i = 0; i < 8; i++)
                appointmentTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            appointmentTable.BackColor = Color.AliceBlue;
            
            appointmentTable.RowCount = 19;
            for (int i = 0; i < 19; i++)
                appointmentTable.RowStyles.Add(new RowStyle(SizeType.Percent, 5.2F));
            appointmentTable.SetBounds(0, 0, parent.Width, parent.Height);
            appointmentTable.TabIndex = 0;
            appointmentTable.Visible = true;

            for (int i = 0; i <appointmentTable.RowCount*appointmentTable.ColumnCount;i++)
            {
                Panel panel = new Panel();
                panel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                panel.Visible = true;
                panel.Margin = new Padding(0);
                appointmentTable.Controls.Add(panel);
            }
            foreach (Control cell in appointmentTable.Controls)
            {
                cell.DoubleClick += Cell_Click;
                
            }
                
        }

       

        private void Cell_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.Black;
        }

        
    }
}
