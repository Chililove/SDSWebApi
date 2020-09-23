using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Application_Service.Service
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _OwnerRepository;
        public static IEnumerable<Owner> ownerList;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _OwnerRepository = ownerRepository;
        }



        public Owner CreateOwner(Owner owner)
        {
            if (owner.FirstName.Length < 1 || owner.LastName.Length < 1)
            {
                throw new System.IO.InvalidDataException("You need to put in atleast 1 letter!");
            }
            return _OwnerRepository.CreateOwner(owner);
        }

        public Owner Update(Owner owner)
        {
            if (owner.FirstName.Length < 1 || owner.LastName.Length < 1)
            {
                throw new System.IO.InvalidDataException("Name must be atleast 1 char");
            }

            if (owner == null)
            {
                throw new System.IO.InvalidDataException("Did not find owner with id: " + owner.Id);
            }
            return _OwnerRepository.UpdateOwner(owner);


        }
        public Owner UpdateOwner(Owner ownerUpdate)
        {
            var DBOwner = FindOwnerById(ownerUpdate.Id);
            if (DBOwner != null)
            {
                DBOwner.FirstName = ownerUpdate.FirstName;
                DBOwner.LastName = ownerUpdate.LastName;
                DBOwner.Address = ownerUpdate.Address;
                DBOwner.PhoneNumber = ownerUpdate.PhoneNumber;
                DBOwner.Email = ownerUpdate.Email;

            }

            return DBOwner;
        }
        
        public Owner DeleteOwner(int id)
        {
            if (id < 1)
            {

                throw new System.IO.InvalidDataException("Id must be atleast 1");
            }
            return _OwnerRepository.DeleteOwner(id);
        }

        public List<Owner> GetOwners( )
        {
            return (List<Owner>)_OwnerRepository.ReadAllOwners();
        }

        /// I Dont get this one.
        
        public Owner FindOwnerByAvatar(Avatar avatar)
        {
            return _OwnerRepository.GetOwnerByAvatar(avatar);
        }

        public Owner FindOwnerById(int id)
        {
            foreach (Owner owner in _OwnerRepository.ReadAllOwners())
            {
                if (id == owner.Id)
                {
                    return owner;
                }
            }
            return null;
        }





        public List<Owner> SearchOwner(string st)
        {
            List<Owner> results = new List<Owner>();
            foreach (Owner owner in _OwnerRepository.ReadAllOwners())
            {
                if (owner.FirstName.Contains(st))
                {
                    results.Add(owner);
                }
            }
            return results;
        }
    }
    
}
