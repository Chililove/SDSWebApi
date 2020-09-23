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

        public AvatarType CreateType(AvatarType AvatarType)
        {
            AvatarType.Id = id++;
            _typeList.Add(AvatarType);
            return AvatarType;
        }

        public AvatarType DeleteType(int id)
        {
            var typeFound = this.GetTypeById(id);
            if (typeFound != null)
            {
                _typeList.Remove(typeFound);
                return typeFound;
            }
            return null;
        }

        public List<AvatarType> GetAllTypes()
        {
            return _typeList;
        }

        public AvatarType GetTypeById(int id)
        {
            foreach (AvatarType AvatarType in _typeList)
            {
                if (AvatarType.Id == id)
                {
                    return AvatarType;
                }
            }
            return null;
        }

        public IEnumerable<AvatarType> ReadAllTypes()
        {
            return _typeList;
        }

      public AvatarType UpdateType(AvatarType typeUpdate)
        {
            var typeFromDB = this.GetTypeById(typeUpdate.Id);
            if (typeFromDB != null)
            {
                typeFromDB.TypeOfAvatar = typeUpdate.TypeOfAvatar;              
         
                return typeFromDB;
            }
            return null;
        }
    }
}
