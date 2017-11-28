using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScedullerControlLibrary
{
    public partial class Sceduller: UserControl
    {
        public Day[] days = new Day[7];
        ScedullerTable scedullerTable;

        public Sceduller()
        {
            InitializeComponent();

            scedullerTable= new ScedullerTable(Width);
            
            Height = 2900;
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //e.Graphics.Clip = new Region(new Rectangle(new Point(0, this.VerticalScroll.Value), new Size(Width, 800)));
            SuspendLayout();
            scedullerTable.onPaint(e,Font);
            ResumeLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(scedullerTable != null)scedullerTable.SetWidth(Width);
            
            
            Invalidate();

        }
    }
}
