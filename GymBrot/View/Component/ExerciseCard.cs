using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymBrot.View.Component
{
    public partial class ExerciseCard : UserControl
    {
        public ExerciseCard()
        {
            InitializeComponent();

            this.Cursor = Cursors.Hand;
        }

        public String Muscle
        {
            get => labelMuscle.Text; 
            set => labelMuscle.Text = value;
        }
        public String ExerciseName
        {
            get => labelName.Text;
            set => labelName.Text = value;
        }
        public async Task SetImageFromUrlAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(url);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        image.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
