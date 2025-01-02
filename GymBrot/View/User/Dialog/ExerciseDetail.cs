using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymBrot.View.User.Dialog
{
    public partial class ExerciseDetail : Form
    {
        public ExerciseDetail()
        {
            InitializeComponent();

            axWindowsMediaPlayer1.URL = "https://pump-app.s3.eu-west-2.amazonaws.com/exercise-assets/06521201-Pull-up_Back.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
