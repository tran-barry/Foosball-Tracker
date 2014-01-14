using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foosball_Tracker
{
    public partial class ViewPlayerForm : Form
    {
        public static int id;
        public ViewPlayerForm()
        {
            InitializeComponent();

            // if this remains -1, it means the user exited the choosePlayerForm without selecting someone
            ViewPlayerForm.id = -1;

            // Create and show the choosePlayerForm
            choosePlayerForm choosePlayer = new choosePlayerForm();
            choosePlayer.ShowDialog();

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewPlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
