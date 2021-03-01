using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DogForLife
{
    class MongoDB
    {
        private MongoClient client;
        private IMongoDatabase db;
        private IMongoCollection<Dog> collectionDog;
        private IMongoCollection<Owner> collectionOwner;
        private IMongoCollection<Worker> collectionWorker;
        private IMongoCollection<Meeting> collectionMeeting;
        public MongoDB()
        {
            client = new MongoClient("mongodb+srv://Dog:Life@cluster0.noaru.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            db = client.GetDatabase("DogForLife");
            collectionDog = db.GetCollection<Dog>("Dog");
            collectionOwner = db.GetCollection<Owner>("Owner");
            collectionWorker = db.GetCollection<Worker>("Worker");
            collectionMeeting = db.GetCollection<Meeting>("Meeting");
        }

        //Owner
        public List<Owner> getAllOwner()
        {
            return collectionOwner.AsQueryable<Owner>().ToList<Owner>();
        }
        public Owner getOwner(string id, string password = null)
        {
            List<Owner> users = getAllOwner();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == id && (password == null || users[i].Password == password))
                {
                    return users[i];
                }
            }
            return null;
        }
        public void AddOwner(Owner owner)
        {
            collectionOwner.InsertOne(owner);
        }
        public void DeleteOwner(string id)
        {

            Owner user = getOwner(id);
            collectionOwner.DeleteOne(a => a.ID == user.ID);
        }
        public void UpdateOwner(Owner owner)
        {
            var filter = Builders<Owner>.Filter.Eq("id", owner.ID);
            var update = Builders<Owner>.Update.Set("name", owner.Name).Set("date_of_birth", owner.DateOfBirth).
                Set("password", owner.Password).Set("Phone", owner.Phone).Set("address", owner.Address).Set("email", owner.Email).Set("gender", owner.Gender).
                Set("dogsID", owner.DogsID);
            collectionOwner.UpdateOne(filter, update);
        }

        //Worker
        public List<Worker> getAllWorker()
        {
            return collectionWorker.AsQueryable<Worker>().ToList<Worker>();
        }
        public Worker getWorker(string id, string password = null)
        {
            List<Worker> users = getAllWorker();
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].ID == id && (password == null || users[i].Password == password))
                {
                    return users[i];
                }
            }
            return null;
        }
        public void AddWorker(Worker worker)
        {
            collectionWorker.InsertOne(worker);
        }
        public void DeleteWorker(string id)
        {

            Worker user = getWorker(id);
            collectionWorker.DeleteOne(a => a.ID == user.ID);
        }
        public void UpdateWorker(Worker worker)
        {
            var filter = Builders<Worker>.Filter.Eq("id", worker.ID);
            var update = Builders<Worker>.Update.Set("name", worker.Name).Set("date_of_birth", worker.DateOfBirth).Set("role", worker.Role).
                Set("password", worker.Password).Set("Phone", worker.Phone).Set("address", worker.Address).Set("email", worker.Email).Set("gender", worker.Gender);
            collectionWorker.UpdateOne(filter, update);
        }

        //Dog
        public List<Dog> getAllDog()
        {
            return collectionDog.AsQueryable<Dog>().ToList<Dog>();
        }
        public Dog getDog(string id)
        {
            List<Dog> dogs = getAllDog();
            for (int i = 0; i < dogs.Count; i++)
            {
                if (dogs[i].ID == id)
                {
                    return dogs[i];
                }
            }
            return null;
        }
        public void AddDog(Dog dog)
        {
            collectionDog.InsertOne(dog);
        }
        public void DeleteDog(string id)
        {

            Dog dog = getDog(id);
            collectionDog.DeleteOne(a => a.ID == dog.ID);
        }
        public void UpdateDog(Dog dog)
        {
            var filter = Builders<Dog>.Filter.Eq("id", dog.ID);
            var update = Builders<Dog>.Update.Set("name", dog.Name).Set("date_of_birth", dog.DateOfBirth).
                Set("owner_id", dog.OwnerID).Set("height", dog.Height).Set("weight", dog.Weight).Set("color", dog.Color).
                Set("breed", dog.Breed).Set("gender", dog.Gender).Set("character", dog.Character);
            collectionDog.UpdateOne(filter, update);
        }

        //Meeting
        public List<Meeting> getAllMeeting()
        {
            return collectionMeeting.AsQueryable<Meeting>().ToList<Meeting>();
        }
        public Meeting getMeeting(string id)
        {
            List<Meeting> meetings = getAllMeeting();
            for (int i = 0; i < meetings.Count; i++)
            {
                if (meetings[i].ID == id)
                {
                    return meetings[i];
                }
            }
            return null;
        }
        public void AddMeeting(Meeting meeting)
        {
            collectionMeeting.InsertOne(meeting);
        }
        public void DeleteMeeting(string id)
        {

            Meeting meeting = getMeeting(id);
            collectionMeeting.DeleteOne(a => a.ID == meeting.ID);
        }
        public void UpdateMeeting(Meeting meeting)
        {
            var filter = Builders<Meeting>.Filter.Eq("id", meeting.ID);
            var update = Builders<Meeting>.Update.Set("dogID", meeting.DogID).Set("ownerID", meeting.OwnerID).
                Set("OwnerID", meeting.OwnerID).Set("WorkerID", meeting.WorkerID).
                Set("date_of_meeting", meeting.DateOfMeeting).Set("time_of_meeting", meeting.DateOfMeeting).Set("adopter", meeting.Adopter);
            collectionMeeting.UpdateOne(filter, update);
        }
    }
}
