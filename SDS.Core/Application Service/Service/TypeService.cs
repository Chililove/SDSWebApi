using SDS.Core.Domain_Service;
using System;
using SDS.Core.Entity;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Application_Service.Service
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository _typeRepository;
        public static IEnumerable<AvatarType> typeList;

        public TypeService(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }


        // Not sure about the naming of name, its called NameType in AvatarType entity?

        public AvatarType CreateType(AvatarType AvatarType)
        {
            if (AvatarType.TypeOfAvatar == null)
            {
                throw new System.IO.InvalidDataException("You need to put in atleast 1 letter!");
            }
            return _typeRepository.CreateType(AvatarType);
        }

        public AvatarType DeleteType(int id)
        {
            if (id < 1)
            {

                throw new System.IO.InvalidDataException("Id must be atleast 1");
            }
            return _typeRepository.DeleteType(id);
        }

        public List<AvatarType> GetTypes()
        {
            return _typeRepository.GetAllTypes();
        }

        public AvatarType ReadTypeById(int id)
        {
            return _typeRepository.GetTypeById(id); 
        }

       
        public AvatarType UpdateType(AvatarType typeToUpdate) 
        {
            var DBType = ReadTypeById(typeToUpdate.Id);
            if (DBType != null)
            {
                DBType = typeToUpdate;                             
            }
            return DBType;
        }
    
 

    }
}
