using GymBrot.Model.Entity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBrot.Model.Repository
{
    internal class ExerciseRepository
    {
        public List<MuscleEntity> GetAllMuscle()
        {
            string baseUrl = "http://192.168.19.197:3000";
            string endpoint = "/exercise/muscle";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<ResponseApiEntity<MuscleEntity>>(request);

            return response.Data.Data;
        }

        public List<EquipmentEntity> GetAllEquipment()
        {
            string baseUrl = "http://192.168.19.197:3000";
            string endpoint = "/exercise/equipment";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<ResponseApiEntity<EquipmentEntity>>(request);

            return response.Data.Data;
        }

        public List<ExerciseEntity> GetAll(string muscleId = null, string equipmentId = null)
        {
            string baseUrl = "http://192.168.19.197:3000";
            string endpoint = "/exercise";

            var client = new RestClient(baseUrl);
            var request = new RestRequest(endpoint, Method.GET);

            if (!string.IsNullOrEmpty(muscleId))
                request.AddQueryParameter("muscle", muscleId);

            if (!string.IsNullOrEmpty(equipmentId))
                request.AddQueryParameter("equipment", equipmentId);

            var response = client.Execute<ResponseApiEntity<ExerciseEntity>>(request);

            return response.Data.Data;
        }
    }
}
