using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjectHandlerOfCompany
{
    public partial class Conversation : UserControl
    {
        //count
        private int count;
        //comment
        private int commentId;
        //project id
        private string projectId;
        //comment list
        ProjectComments[] commentList = new ProjectComments[100];
        //user
        UserInfo U;
 
        public Conversation()
        {
            InitializeComponent();
        }
        public Conversation(UserInfo u):this()
        {
            InitializeComponent();
            this.U = u;
        }

        private void btnSetProjectId_Click(object sender, EventArgs e)
        {
            this.projectId = this.txtProjectId.Text;
            //this.PopulateComments(this.projectId);
        }

        public void PopulateComments(/*string projectId*/)
        {
            try 
            {
                //MessageBox.Show("Something");
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                // where project_id = '" + projectId + "'
                int counter = dop.RowCounter("select * from CommentDetails;");
                //MessageBox.Show(counter.ToString());
                dop.CloseDatabase();
                
                if (counter > 0)
                {
                    DataOperation dop1 = new DataOperation();
                    dop1.OpenDatabase();
                    dop1.SetCommand("select * from CommentDetails;");
                    SqlDataReader sdr = dop1.SqlCom.ExecuteReader();
                    while (sdr.Read())
                    {
                        commentList[this.count] = new ProjectComments(
                            sdr["u_id"].ToString(),
                            sdr["description"].ToString()
                            );
                        this.flpComments.Controls.Add(commentList[this.count]);
                        this.count++;
                    }
                    dop1.CloseDatabase();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
            
        }
        private void Conversation_Load(object sender, EventArgs e)
        {
            PopulateComments(/*string projectId*/);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.commentId = 405;
                DataOperation dop = new DataOperation();
                dop.OpenDatabase();
                int u = dop.RunNonQueryCommand("insert into CommentDetails values('" + commentId.ToString() + "', '" + this.projectId + "', '" + this.U.UserId + "', '" + this.txtCommentDes + "')");
                dop.CloseDatabase();
                this.commentId++;
                this.PopulateComments();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }*/
            /*DataOperation dop = new DataOperation();
            dop.OpenDatabase();
            int u = dop.RowCounter("select * from commentdetails where project_id = '"+ this.txtProjectId.Text + "';");
            dop.CloseDatabase();
            MessageBox.Show(u.ToString());*/
        }
    }
}
