

using System.Data.Common;

namespace dog_api.Services
{
    public class DogsService
    {

        private readonly DogsRepository _dogsRepository;

        public DogsService(DogsRepository dogsRepository)
        {
            _dogsRepository = dogsRepository;
        }

        internal Dog CreateDog(Dog dogData)
        {
            if (dogData.Name == null)
            {
                throw new Exception("Please provide a name");
            }
            Dog dog = _dogsRepository.CreateDog(dogData);
            return dog;
        }

        internal string DestoryDog(int dogId)
        {
            Dog dog = GetDogById(dogId);

            _dogsRepository.DestoryDog(dog);

            return $"{dog.Name} has been sent to bens house";

        }

        internal Dog GetDogById(int dogId)
        {
            Dog dog = _dogsRepository.GetDogById(dogId);
            if (dog == null)
            {
                throw new Exception($"Invalid id: {dogId}");
            }
            return dog;
        }

        internal List<Dog> GetDogs()
        {
            List<Dog> dogs = _dogsRepository.GetDogs();
            return dogs;
        }

    }
}