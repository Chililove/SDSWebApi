using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Application_Service
{
   public interface IOwnerService
    {

        public List<Owner> GetOwners();

        Owner FindOwnerByAvatar(Avatar avatar);
        Owner FindOwnerById(int id);
        Owner CreateOwner(Owner owner);
        Owner DeleteOwner(int id);
        Owner UpdateOwner(Owner owner);
        public List<Owner> SearchOwner(string st);

    }
}
