using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLCVM
{
    public partial class Form1 : Form
    {
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
            selectedPan.Height = homePageBtn.Height;
            selectedPan.Top = homePageBtn.Top;
        }
        



        


        // SelectedPan Edits starts here

        private void homePageBtn_click(object sender, EventArgs e)
        {
            selectedPan.Height = homePageBtn.Height;
            selectedPan.Top = homePageBtn.Top;
            ongoingProcessLabel.Text = "Home Page";

        }
        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            selectedPan.Height = addVehicleBtn.Height;
            selectedPan.Top = addVehicleBtn.Top;
            ongoingProcessLabel.Text = "Add New Vehicle to the List using the form below :";
        }


        private void trackVehicleBtn_Click(object sender, EventArgs e)
        {
            selectedPan.Height = trackVehicleBtn.Height;
            selectedPan.Top = trackVehicleBtn.Top;
            ongoingProcessLabel.Text = "Track Vehicle By using the Unique Vehicle ID";
        }

        
        private void showServiceListBtn_Click(object sender, EventArgs e)
        {
            selectedPan.Height = showServiceListBtn.Height;
            selectedPan.Top = showServiceListBtn.Top;
            ongoingProcessLabel.Text = "Search with Vehicle ID to retrieve the Service List of a Particular Vehicle";
        }

      
        //Selected Pane changer ends here






























        //Move the Form Code Starts Here

        private void SocialPane_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void SocialPane_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Move the form Code Ends here



        //Close the Application :


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string message = " Unsaved Contents Will be Erased !! \n Are you Sure you want to close the Window ?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

       
    }
}
