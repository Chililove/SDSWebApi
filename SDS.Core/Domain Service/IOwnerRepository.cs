using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Domain_Service
{
   public interface IOwnerRepository
    {
        IEnumerable<Owner> ReadAllOwners();

        public List<Owner> GetAllOwners();
        public Owner CreateOwner(Owner owner);
        public Owner GetOwnerById(int id);

        public Owner GetOwnerByAvatar(Avatar avatar);
        public Owner UpdateOwner(Owner ownerUpdate);

        public Owner DeleteOwner(int id);
    }
}
