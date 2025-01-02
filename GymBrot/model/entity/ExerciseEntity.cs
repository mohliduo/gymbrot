using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBrot.Model.Entity
{
    internal class ExerciseEntity
    {
        public string exercise_id { get; set; }
        public string exercise_name { get; set; }
        public string exercise_video { get; set; }
        public string exercise_image { get; set; }
        public string exercise_thumbnail { get; set; }
        public string exercise_instructions { get; set; }
        public string muscle_name { get; set; }
        public string equipment_name { get; set; }
    }
}
