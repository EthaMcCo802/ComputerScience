using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of a Thread.Sleep()
using System.Media; //allows the use of SoundPlayer
namespace USA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it 

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.AlertSound);
            alertPlayer.Play();


            //change the colors of the stat labels
            Reactor1StateLabel.BackColor = Color.Red;
            Reactor2StateLabel.BackColor = Color.White ;

            //change the message in the output label
            OutputLabel.Text = "Meltdown Imminent";

            //redraw the screen to show updates then pause for 1 second 

            Refresh();

            Thread.Sleep(1000);



            //change the colour of the state labels and output message 

            Reactor1StateLabel.BackColor = Color.White;

            Reactor2StateLabel.BackColor = Color.White;



            //change the font and background colours of the output label 

            OutputLabel.ForeColor = Color.White;

            OutputLabel.BackColor = Color.Red;



            //redraw the screen to show updates then pause for 1 second 

            Refresh();

            Thread.Sleep(1000);



            //change the colour of the state labels and output message 

            Reactor1StateLabel.BackColor = Color.Red;

            Reactor2StateLabel.BackColor = Color.Red;



            //change the font and background colours of the output label 

            OutputLabel.ForeColor = Color.Red;

            OutputLabel.BackColor = Color.White;



            //redraw the screen to show updates then pause for 1 second 

            Refresh();

            Thread.Sleep(1000);
        }
    }
}
