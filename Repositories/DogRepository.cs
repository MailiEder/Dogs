using Dogs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Dogs.Repositories
{
    public class DogRepository : RepositoryBase, IDogRepository
    {
        public void Add(DogModel dogModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(DogModel dogModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DogModel> GetAll()
        {
            var dogList = new List<DogModel>();

            using (var connection = GetNpgsqlConnection())
            using (var command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "select * from dogs order by dog_id desc";

                using(var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dogModel = new DogModel();

                        dogModel.Id = (int)reader[0];
                        dogModel.Dogsname = reader[1].ToString();
                        dogModel.Dogsbreed = reader[2].ToString();
                        dogModel.Dogscolor = reader[3].ToString();
                        dogModel.Dogsage = (int)reader[4];
                        dogList.Add(dogModel);
                    //    Console.WriteLine("Rep: " + dogModel.Id);
                    }
                }

            }

            return dogList;
        }

        public IEnumerable<DogModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
