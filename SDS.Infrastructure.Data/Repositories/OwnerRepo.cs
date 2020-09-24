using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Infrastructure.Data.Repositories
{
    public class OwnerRepo : IOwnerRepository

    {

        private static List<Owner> _ownerList = new List<Owner>();
        static int id = 1;

        public OwnerRepo()
        {

        }
        public Owner CreateOwner(Owner owner)
        {
            owner.Id = id++;
            _ownerList.Add(owner);
            return owner;
        }


        public Owner DeleteOwner(int id)
        {
            var ownerFound = this.GetOwnerById(id);
            if (ownerFound != null)
            {
                _ownerList.Remove(ownerFound);
                return ownerFound;
            }
            return null;
        }

        

        public Owner GetOwnerById(int id)
        {
            foreach (var owner in _ownerList)
            {
                if (owner.Id == id)
                {
                    return owner;
                }
            }
            return null;
        }

        public List<Owner> GetAllOwners() 
        {
            return _ownerList;
        }

       public IEnumerable<Owner> ReadAllOwners()
        {
            return _ownerList;
        }

        public Owner UpdateOwner(Owner ownerUpdate)
        {
            var ownerFromDB = this.GetOwnerById(ownerUpdate.Id);
            if (ownerFromDB != null)
            {
                ownerFromDB.FirstName = ownerUpdate.FirstName;
                ownerFromDB.LastName = ownerUpdate.LastName;
                ownerFromDB.Address = ownerUpdate.Address;
                ownerFromDB.PhoneNumber = ownerUpdate.PhoneNumber;
                ownerFromDB.Email = ownerUpdate.Email;
                return ownerFromDB;
            }
            return null;
        }

        public Owner GetOwnerByAvatar(Avatar avatar)
        {
            throw new NotImplementedException();
        }
    }
}
