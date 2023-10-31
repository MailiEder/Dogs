using Dogs.Models;
using Dogs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.ViewModels
{
    public class DogViewModel : ViewModelBase
    {

        // Felder
        private DogModel _dog;
        private IDogRepository dogRepository;

        public DogModel Dog 
        { 
            get => _dog;
            set 
            { 
                _dog = value;
                OnPropertyChanged(nameof(Dog));
            }
        }

        public DogViewModel()
        {
            dogRepository = new DogRepository();
            Dog = new DogModel();

            Load_Dog();
        }

        private void Load_Dog()
        {
            var dog = dogRepository.GetAll();
            if(dog != null)
            {
                foreach ( var dogrecord in dog)
                {
                    Dog.Id = dogrecord.Id;
                    Dog.Dogsname = dogrecord.Dogsname;
                    Dog.Dogsbreed = dogrecord.Dogsbreed;
                    Dog.Dogscolor = dogrecord.Dogscolor;
                    Dog.Dogsage = dogrecord.Dogsage;
                    Console.WriteLine(Dog.Id);

                }
            }
        }
    }
}
