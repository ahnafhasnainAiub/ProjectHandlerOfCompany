using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ProjectHandlerOfCompany
{
    public partial class FormLogin : MetroForm
    {
        private byte count = 1;
        private SplashLoginWindow slw = new SplashLoginWindow();
        private LoginInfoProvider lip;
        public FormLogin()
        {
            InitializeComponent();
            this.lip = new LoginInfoProvider(this);
            timer1.Start();
            //slw.Show();
            this.pnlMultiViewer.Controls.Add(slw);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 20)
            {
                this.pnlMultiViewer.Controls.Remove(slw);
                this.pnlMultiViewer.Controls.Add(lip);
                timer1.Stop();
            }
            count++;
        }
    }
}
