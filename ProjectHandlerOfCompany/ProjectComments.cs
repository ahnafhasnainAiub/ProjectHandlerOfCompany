using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHandlerOfCompany
{
    public partial class ProjectComments : UserControl
    {
        public ProjectComments()
        {
            InitializeComponent();
        }
        public ProjectComments(string userid, string comment) : this()
        {
            this.lblDescription.Text = comment;
            this.lblUserId.Text = userid;
        }
    }
}
