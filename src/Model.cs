using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogForLife
{
    class Model
    {
        protected MongoDB db;
        public Model()
        {
            db = new MongoDB();
        }
    }
    class WorkerModel : Model
    {
        private Dictionary<string, Worker> workers;

        public WorkerModel()
        {
            workers = new Dictionary<string, Worker>();
            List<Worker> listWorker = db.getAllWorker();
            foreach (var x in listWorker)
            {
                workers.Add(x.ID, x);
            }
        }
        public Worker get(string id)
        {
            if (id == null)
                return null;
            if(workers.ContainsKey(id))
                return workers[id];
            return null;
        }
        public Dictionary<string, Worker> getList()
        {
            return workers;
        }
        public bool add(Worker w)
        {
            if (!workers.ContainsKey(w.ID))
            {
                workers.Add(w.ID, w);
                db.AddWorker(w);
                return true;
            }
            return false;
        }
        public bool update(Worker w)
        {
            if (workers.ContainsKey(w.ID))
            {
                workers[w.ID] = w;
                db.UpdateWorker(w);
                return true;
            }
            return false;
        }
        public bool remove(Worker w)
        {
            if (workers.ContainsKey(w.ID))
            {
                workers.Remove(w.ID);
                db.DeleteWorker(w.ID);
                return true;
            }
            return false;
        }
    }
    class MeetingModel : Model
    {
        private Dictionary<string, Meeting> meetings;

        public MeetingModel()
        {
            meetings = new Dictionary<string, Meeting>();
            List<Meeting> listMeeting = db.getAllMeeting();
            foreach (var x in listMeeting)
            {
                meetings.Add(x.ID, x);
            }
        }
        public Meeting get(string id)
        {
            if (id == null)
                return null;
            if(meetings.ContainsKey(id))
                return meetings[id];
            return null;
        }
        public Dictionary<string, Meeting> getList()
        {
            return meetings;
        }
        public bool add(Meeting m)
        {
            if (!meetings.ContainsKey(m.ID))
            {
                meetings.Add(m.ID, m);
                db.AddMeeting(m);
                return true;
            }
            return false;
        }
        public bool update(Meeting m)
        {
            if (meetings.ContainsKey(m.ID))
            {
                meetings[m.ID] = m;
                db.UpdateMeeting(m);
                return true;
            }
            return false;
        }
        public bool remove(Meeting m)
        {
            if (meetings.ContainsKey(m.ID))
            {
                meetings.Remove(m.ID);
                db.DeleteMeeting(m.ID);
                return true;
            }
            return false;
        }
    }
    class DogModel : Model
    {
        private Dictionary<string, Dog> dogs;

        public DogModel()
        {
            dogs = new Dictionary<string, Dog>();
            List<Dog> listDog = db.getAllDog();
            foreach (var x in listDog)
            {
                dogs.Add(x.ID, x);
            }
        }
        public Dog get(string id)
        {
            if (id == null)
                return null;
            if(dogs.ContainsKey(id))
                return dogs[id];
            return null;
        }
        public Dictionary<string, Dog> getList()
        {
            return dogs;
        }
        public bool add(Dog d)
        {
            if (!dogs.ContainsKey(d.ID))
            {
                dogs.Add(d.ID, d);
                db.AddDog(d);
                return true;
            }
            return false;
        }
        public bool update(Dog d)
        {
            if (dogs.ContainsKey(d.ID))
            {
                dogs[d.ID] = d;
                db.UpdateDog(d);
                return true;
            }
            return false;
        }
        public bool remove(Dog d)
        {
            if (dogs.ContainsKey(d.ID))
            {
                dogs.Remove(d.ID);
                db.DeleteDog(d.ID);
                return true;
            }
            return false;
        }
    }
    class OwnerModel : Model
    {
        private Dictionary<string, Owner> owners;

        public OwnerModel()
        {
            owners = new Dictionary<string, Owner>();
            List<Owner> listOwner = db.getAllOwner();
            foreach (var x in listOwner)
            {
                owners.Add(x.ID, x);
            }
        }
        public Owner get(string id)
        {
            if (id == null)
                return null;
            if(owners.ContainsKey(id))
                return owners[id];
            return null;
        }
        public Dictionary<string, Owner> getList()
        {
            return owners;
        }
        public bool add(Owner owner)
        {
            if (!owners.ContainsKey(owner.ID))
            {
                owners.Add(owner.ID, owner);
                db.AddOwner(owner);
                return true;
            }
            return false;
        }
        public bool update(Owner owner)
        {
            if (owners.ContainsKey(owner.ID))
            {
                owners[owner.ID] = owner;
                db.UpdateOwner(owner);
                return true;
            }
            return false;
        }
        public bool remove(Owner owner)
        {
            if (owners.ContainsKey(owner.ID))
            {
                owners.Remove(owner.ID);
                db.DeleteDog(owner.ID);
                return true;
            }
            return false;
        }
    }
}
