using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System.Collections.Generic;

namespace SDS.Infrastructure.Data.Repositories
{
    
    public class AvatarRepo : IAvatarRepository

    {
        private static List<Avatar> _avatarList = new List<Avatar>();

        public Avatar Create(Avatar avatar)
        {
            avatar.Id = DBInit.GetNextIdAvatar();
            var list = DBInit.GetAllAvatars();
            list.Add(avatar);
            return avatar;
        }

        public Avatar GetAvatarById(int id)
        {
            var avatarList = DBInit.GetAllAvatars();
            var avatar = avatarList.Find(x => x.Id == id);
            return avatar;
        }

        public List<Avatar> GetAllAvatars()
        {

            var avatarList = DBInit.GetAllAvatars();
            return avatarList;               
        }

        public IEnumerable<Avatar> ReadAllAvatars() 
        {
            return _avatarList;
        }

        public Avatar Update(Avatar avatarUpdate)
        {
          var avatar =  GetAvatarById(avatarUpdate.Id);
            if (avatar != null)
            {
                avatar.Name = avatarUpdate.Name;
                avatar.AvatarType = avatarUpdate.AvatarType;
                avatar.Birthday = avatarUpdate.Birthday;
                avatar.SoldDate = avatarUpdate.SoldDate;
                avatar.Color = avatarUpdate.Color;
                avatar.Owner = avatarUpdate.Owner;
                avatar.Price = avatarUpdate.Price;
                return avatar;
            }
            return null;
        }

        public Avatar Delete(int id)
        {
            Avatar a = GetAllAvatars().Find(x => x.Id == id);
            GetAllAvatars().Remove(a);
            if (a != null)
            {
                return a;
            }
            return null;
        }
    }
}
