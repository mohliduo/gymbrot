using Guna.UI2.WinForms;
using GymBrot.View.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GymBrot.Controller;
using GymBrot.Model.Entity;

namespace GymBrot.View.User
{
    public partial class Exercise : UserControl
    {
        private ExerciseController controller = new ExerciseController();

        public Exercise()
        {
            InitializeComponent();
            loadAllExercise();
            loadAllMuscle();
            loadAllEquipment();
        }

        public void loadAllMuscle()
        {
            List<MuscleEntity> listMuscle = controller.GetAllMuscle();

            muscleComboBox.Items.Clear();
            muscleComboBox.DataSource = listMuscle;
            muscleComboBox.ValueMember = "muscle_id";
            muscleComboBox.DisplayMember = "muscle_name";
        }

        public void loadAllEquipment()
        {
            List<EquipmentEntity> listEquipment = controller.GetAllEquipment();

            equipmentComboBox.Items.Clear();
            equipmentComboBox.DataSource = listEquipment;
            equipmentComboBox.ValueMember = "equipment_id";
            equipmentComboBox.DisplayMember = "equipment_name";
        }

        public void loadAllExercise()
        {
            flowLayoutPanel2.Controls.Clear();

            string selectedMuscleId = null;
            string selectedEquipmentId = null;

            if (muscleComboBox.SelectedValue != null)
            {
                selectedMuscleId = muscleComboBox.SelectedValue.ToString();
            }

            if (equipmentComboBox.SelectedValue != null)
            {
                selectedEquipmentId = equipmentComboBox.SelectedValue.ToString();
            }


            List<ExerciseEntity> listExercise = controller.GetAll(selectedMuscleId, selectedEquipmentId);

            foreach (ExerciseEntity item in listExercise)
            {
                loadExerciseCard(item.muscle_name, item.exercise_name, item.exercise_thumbnail);
            }
        }

        public async void loadExerciseCard(string muscleName, string exerciseName, string imageUrl)
        {
            var card = new ExerciseCard
            {
                Muscle = muscleName,
                ExerciseName = exerciseName,
            };

            await card.SetImageFromUrlAsync(imageUrl);

            flowLayoutPanel2.Controls.Add(card);
        }

        private void muscleComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllExercise();
        }

        private void equipmentComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            loadAllExercise();
        }
    }
}
