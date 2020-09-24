using SDS.Core.Domain_Service;
using System;
using System.Collections.Generic;
using SDS.Core.Entity;

namespace SDS.Infrastructure.Data.Repositories
{
    public class TypeRepo : ITypeRepository
    {
        private static List<AvatarType> _typeList = new List<AvatarType>();
        static int id = 1;

     
        public AvatarType CreateType(AvatarType avatarType)
        {
            avatarType.Id = DBInit.GetNextId();
            var list = DBInit.GetAvatarTypes();
            list.Add(avatarType);
            return avatarType;
        }

        public AvatarType DeleteType(int id)
        {
            AvatarType atype = GetAllTypes().Find(x => x.Id == id);
            GetAllTypes().Remove(atype);
            if (atype != null)
            {
                return atype;
            }
            return null;
        }

        public List<AvatarType> GetAllTypes()
        {
            var typeList = DBInit.GetAvatarTypes();
            return typeList;
        }

        public AvatarType GetTypeById(int id)
        {
            var typeList = DBInit.GetAvatarTypes();
            var avatarType = typeList.Find(x => x.Id == id);
            return avatarType;
        }

        public IEnumerable<AvatarType> ReadAllTypes()
        {
            return _typeList;
        }

      public AvatarType UpdateType(AvatarType typeUpdate)
        {
            var avatarType = GetTypeById(typeUpdate.Id);
            if (avatarType != null)
            {
                avatarType.TypeOfAvatar = typeUpdate.TypeOfAvatar;              
         
                return avatarType;
            }
            return null;
        }
    }
}
