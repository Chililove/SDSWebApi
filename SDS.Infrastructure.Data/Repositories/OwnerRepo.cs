﻿using SDS.Core.Application_Service.Service;
using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDS.Infrastructure.Data.Repositories
{
    public class OwnerRepo : IOwnerRepository

    {

        private static List<Owner> _ownerList = new List<Owner>();


        public Owner CreateOwner(Owner owner)
        {
            owner.Id = DBInit.GetNextIdOwner();
            var list = DBInit.GetOwners();
            list.Add(owner);
            return owner;
        }


        public Owner DeleteOwner(int id)
        {
            Owner o = GetAllOwners().Find(x => x.Id == id);
            GetAllOwners().Remove(o);
            if (o != null)
            {
                return o;
            }
            return null;
        }

        

        public Owner GetOwnerById(int id)
        {
            var ownerList = DBInit.GetOwners();
            var owner = ownerList.Find(x => x.Id == id);
            return owner;
        }

        public List<Owner> GetAllOwners() 
        {
            var ownerList = DBInit.GetOwners();
            return ownerList;
        }

       public IEnumerable<Owner> ReadAllOwners()
        {
            return _ownerList;
        }

        public Owner UpdateOwner(Owner ownerUpdate)
        {
            var owner = GetOwnerById(ownerUpdate.Id);
            if(owner != null)
            { 
           
                owner.FirstName = ownerUpdate.FirstName;
                owner.LastName = ownerUpdate.LastName;
                owner.Address = ownerUpdate.Address;
                owner.PhoneNumber = ownerUpdate.PhoneNumber;
                owner.Email = ownerUpdate.Email;
                return owner;
            }
            return null;
        }
        // How to connect the two lists by names?
        public Owner GetOwnerByAvatar(Owner owner)
        {
            var names = new HashSet<string>(AvatarService.avatarList.Select(p => p.Name));
            var products = _ownerList.Where(p => names.Contains(p.FirstName))
                                       .ToList();
            return owner;
        }
        
    }
}
