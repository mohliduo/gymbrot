using GymBrot.Model.Entity;
using GymBrot.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBrot.Controller
{
    internal class ExerciseController
    {
        public List<ExerciseEntity> GetAll(string muscleId = null, string equipmentId = null)
        {
            // membuat objek collection
            List<ExerciseEntity> list = new List<ExerciseEntity>();

            var repo = new ExerciseRepository();
            list = repo.GetAll(muscleId, equipmentId);

            return list;
        }

        public List<MuscleEntity> GetAllMuscle()
        {
            // membuat objek collection
            List<MuscleEntity> list = new List<MuscleEntity>();

            var repo = new ExerciseRepository();
            list = repo.GetAllMuscle();

            return list;
        }

        public List<EquipmentEntity> GetAllEquipment()
        {
            // membuat objek collection
            List<EquipmentEntity> list = new List<EquipmentEntity>();

            var repo = new ExerciseRepository();
            list = repo.GetAllEquipment();

            return list;
        }
    }
}
