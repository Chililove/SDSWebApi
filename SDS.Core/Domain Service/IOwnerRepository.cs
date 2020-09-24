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
        Owner CreateOwner(Owner owner);
        Owner GetOwnerById(int id);

        Owner GetOwnerByAvatar(Avatar avatar);
        Owner UpdateOwner(Owner ownerUpdate);

        Owner DeleteOwner(int id);
    }
}
