using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogForLife
{
    class Living_Creature
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public String ID { get; set; }

        [BsonElement("name")]
        public String Name { get; set; }

        [BsonElement("date_of_birth")]
        public String DateOfBirth { get; set; }

        [BsonElement("gender")]
        public String Gender { get; set; }

        public Living_Creature(string iD, string name, string dateOfBirth, string gender)
        {
            ID = iD;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Living_Creature(Living_Creature l)
        {
            ID = l.ID;
            Name = l.Name;
            DateOfBirth = l.DateOfBirth;
            Gender = l.Gender;
        }
    }
    class Person: Living_Creature
    {
        [BsonElement("password")]
        public String Password { get; set; }

        [BsonElement("phone")]
        public String Phone { get; set; }

        [BsonElement("email")]
        public String Email { get; set; }

        [BsonElement("address")]
        public String Address { get; set; }

        public Person(string iD, string name, string dateOfBirth, string gender,
            string password, string phone, string email, string address):
            base(iD, name, dateOfBirth, gender)
        {
            Password = password;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Person(Living_Creature l,
            string password, string phone, string email, string address) :
            base(l)
        {
            Password = password;
            Phone = phone;
            Email = email;
            Address = address;
        }
        public Person(Person p) : base(p)
        {
            Password = p.Password;
            Phone = p.Phone;
            Email = p.Email;
            Address = p.Address;
        }
    }
    class Owner: Person//לקוח יורש מאיש
    {
        [BsonElement("dogsID")]
        public List<string> DogsID { get; set; }

        public Owner(string iD, string name, string dateOfBirth, string gender,
            string password, string phone, string email, string address, List<string> array) :
            base(iD, name, dateOfBirth, gender, password, phone, email, address) 
        {
            DogsID = array;
        }
        public Owner(string iD, string name, string dateOfBirth, string gender,
            string password, string phone, string email, string address) :
            base(iD, name, dateOfBirth, gender, password, phone, email, address)
        {
            DogsID = null;
        }
        public Owner(Living_Creature l,
            string password, string phone, string email, string address, List<string> array) :
            base(l, password, phone, email, address) 
        {
            DogsID = array;
        }
        public Owner(Living_Creature l,
            string password, string phone, string email, string address) :
            base(l, password, phone, email, address)
        {
            DogsID = null;
        }
        public Owner(Person p, List<string> array) : base(p) { DogsID = array; }
        public Owner(Person p) : base(p) { }
        public Owner(Owner owner) : base(owner) { DogsID = owner.DogsID; }

        public void AddDogID(string id)
        {
            DogsID.Add(id);
        }
        public void deleteDogID(string id)
        {
            DogsID.Remove(id);
        }
    }
    class Worker : Person
    {
        [BsonElement("role")]
        public string Role { get; set; }
        public Worker(string iD, string name, string dateOfBirth, string gender,
            string password, string phone, string email, string address, string role) :
            base(iD, name, dateOfBirth, gender, password, phone, email, address)
        {
            Role = role;
        }
        public Worker(Living_Creature l,
            string password, string phone, string email, string address, string role) :
            base(l, password, phone, email, address)
        {
            Role = role;
        }
        public Worker(Person p, string role) : base(p) 
        {
            Role = role;
        }
        public Worker(Worker worker) : base(worker) 
        {
            Role = worker.Role;
        }
    }
    class Dog: Living_Creature
    {
        [BsonElement("owner_id")]
        public String OwnerID { get; set; }

        [BsonElement("height")]
        public String Height { get; set; }

        [BsonElement("weight")]
        public String Weight { get; set; }

        [BsonElement("color")]
        public String Color { get; set; }

        [BsonElement("breed")]
        public String Breed { get; set; }

        [BsonElement("character")]
        public String Character { get; set; }
        public Dog(string iD, string name, string dateOfBirth, string gender, string ownerID, string height, string weight, string color, string breed, string character)
        : base(iD, name, dateOfBirth, gender){
            OwnerID = ownerID;
            Height = height;
            Weight = weight;
            Color = color;
            Breed = breed;
            Character = character;
        }
        public Dog(Living_Creature l, string ownerID, string height, string weight, string color, string breed, string character)
       : base(l)
        {
            OwnerID = ownerID;
            Height = height;
            Weight = weight;
            Color = color;
            Breed = breed;
            Character = character;
        }
        public Dog(Dog d)
       : base(d)
        {
            OwnerID = d.OwnerID;
            Height = d.Height;
            Weight = d.Weight;
            Color = d.Color;
            Breed = d.Breed;
            Character = d.Character;
        }
    }

    class Meeting
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("id")]
        public String ID { get; set; }

        [BsonElement("dogID")]
        public String DogID { get; set; }

        [BsonElement("ownerID")]
        public String OwnerID { get; set; }

        [BsonElement("workerID")]
        public String WorkerID { get; set; }

        [BsonElement("date_of_meeting")]
        public String DateOfMeeting { get; set; }

        [BsonElement("time_of_meeting")]
        public String TimeOfMeeting { get; set; }

        [BsonElement("adopter")]
        public String Adopter { get; set; }
        public Meeting(string iD, string dogID, string ownerID, string workerID, string dateOfMeeting, string timeOfMeeting)
        {
            ID = iD;
            DogID = dogID;
            OwnerID = ownerID;
            WorkerID = workerID;
            DateOfMeeting = dateOfMeeting;
            TimeOfMeeting = timeOfMeeting;
            Adopter = "Yet";
        }
        public Meeting(Meeting m)
        {
            ID = m.ID;
            DogID = m.DogID;
            OwnerID = m.OwnerID;
            WorkerID = m.WorkerID;
            DateOfMeeting = m.DateOfMeeting;
            TimeOfMeeting = m.TimeOfMeeting;
            Adopter = m.Adopter;
        }
        
    }

}
