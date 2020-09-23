using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Application_Service
{
   public interface IOwnerService
    {

        public List<Owner> GetOwners();

        public Owner FindOwnerByAvatar(Avatar avatar);
        public Owner FindOwnerById(int id);
        public Owner CreateOwner(Owner owner);
        public Owner DeleteOwner(int id);
        public Owner UpdateOwner(Owner owner);
        public List<Owner> SearchOwner(string st);

    }
}
