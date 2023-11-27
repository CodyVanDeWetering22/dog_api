




namespace dog_api.Repositories
{
    public class DogsRepository
    {
        private List<Dog> _dogs;
        public DogsRepository()
        {
            _dogs = [
                new Dog( 1,"Duke", 15, true, 4),
                new Dog(2, "Cooper", 2 , false, 4)
            ];
        }

        internal Dog CreateDog(Dog dogData)
        {
            Dog lastDog = _dogs[_dogs.Count - 1];
            if (lastDog == null)
            {
                dogData.Id = 1;
            }
            else
            {
                dogData.Id = lastDog.Id + 1;
            }
            _dogs.Add(dogData);
            return dogData;
        }

        internal void DestoryDog(Dog dog)
        {
            _dogs.Remove(dog);
        }

        internal Dog GetDogById(int dogId)
        {
            Dog foundDog = _dogs.Find(dog => dog.Id == dogId);
            return foundDog;
        }


        internal List<Dog> GetDogs()
        {
            return _dogs;
        }
    }
}