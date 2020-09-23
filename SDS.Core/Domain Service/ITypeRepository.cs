using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Domain_Service
{
   public interface ITypeRepository

    {
        IEnumerable<AvatarType> ReadAllTypes();

        public List<AvatarType> GetAllTypes();
        AvatarType CreateType(AvatarType AvatarType);

        AvatarType UpdateType(AvatarType typeUpdate);

        AvatarType DeleteType(int id);

        AvatarType GetTypeById(int id);

        


    }
}
