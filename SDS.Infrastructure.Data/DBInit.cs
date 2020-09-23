using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace SDS.Infrastructure.Data
{
    public class DBInit : IDBInit
    {
        private readonly IAvatarRepository _avatarRepository;
        private readonly IOwnerRepository _ownerRepository;
        private readonly ITypeRepository _typeRepository;
        public DBInit(IAvatarRepository avatarRepository, IOwnerRepository ownerRepository, ITypeRepository typeRepository)
        {
            _avatarRepository = avatarRepository;
            _ownerRepository = ownerRepository;
            _typeRepository = typeRepository;
        }
        public void InitData()
        {
        /*    Avatars = new List<Avatar>();
            Owners = new List<Owner>();
            Avatarypes = new List<AvatarType>();*/
            Random r = new Random();
            _avatarRepository.Create(new Avatar
            {
                      Name = "Bradley",
                      AvatarType = "Wrath",
                      Birthday = DateTime.Now.Date,
                      SoldDate = DateTime.Now.Date,
                      Color = "black",
                      Owner = "Chili",
                      Price = 900
        });
            _avatarRepository.Create(new Avatar
        {
                     Name = "Chili",
                     AvatarType = "Goddess",
                     Birthday = DateTime.Now.AddYears(-1*r.Next(1,100)),
                     SoldDate = DateTime.Now.Date.AddYears(-5),
                     Color = "Pink",
                     Owner = "Bradley",
                     Price = 800
                 });

            _avatarRepository.Create(new Avatar
            {
                Name = "Bunsy",
                AvatarType = "Sloth",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Blue",
                Owner = "Chili",
                Price = 600
            });
            _avatarRepository.Create(new Avatar
            {
                Name = "Meliodas",
                AvatarType = "Wrath",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Dark Purple",
                Owner = "Chili",
                Price = 400
            });
            _avatarRepository.Create(new Avatar
            {
                Name = "Melon",
                AvatarType = "Greed",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Sand",
                Owner = "Bradley",
                Price = 400
            }); _avatarRepository.Create(new Avatar
            {
                Name = "Ban",
                AvatarType = "Greed",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Red",
                Owner = "Lotte",
                Price = 400
            });
            _avatarRepository.Create(new Avatar
            {
                Name = "Diane",
                AvatarType = "Envy",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Orange",
                Owner = "Peter",
                Price = 400
            });
            _ownerRepository.CreateOwner(new Owner
            {
                FirstName = "Peter",
                LastName = "Pan",
                Address = "Mælkevejen",
                PhoneNumber = "20252414",
                Email = "LostBoy@putmail.com"

            });

            _ownerRepository.CreateOwner(new Owner
            {
                FirstName = "Lotte",
                LastName = "Pedersen",
                Address = "IpCom",
                PhoneNumber = "24582414",
                Email = "Lotte@gmail.com"

            });
            
            _ownerRepository.CreateOwner(new Owner
               {
                   FirstName = "Bradley",
                   LastName = "Swords",
                   Address = "Sao",
                   PhoneNumber = "12454525",
                   Email = "LostBoy@sao.com"

               });
            _ownerRepository.CreateOwner(new Owner
            {
                FirstName = "Chili",
                LastName = "Love",
                Address = "LaLaLand",
                PhoneNumber = "15865525",
                Email = "FoundBoy@sins.com"

            });

            _typeRepository.CreateType(new AvatarType
            {
                TypeOfAvatar = "Wrath"


            });
            _typeRepository.CreateType(new AvatarType
            {
                TypeOfAvatar = "Greed"


            }); _typeRepository.CreateType(new AvatarType
            {
                TypeOfAvatar = "Envy"


            }); _typeRepository.CreateType(new AvatarType
            {
                TypeOfAvatar = "Sloth"


            });
            _typeRepository.CreateType(new AvatarType
            {
                TypeOfAvatar = "Goddess"

            });




            // GiantMock.AddToRepo(_avatarRepository);
            foreach (Avatar avatar in _avatarRepository.GetAllAvatars()) {
                int bdInt = r.Next(1, 100);
                avatar.Birthday = DateTime.Now.AddYears(-1 * bdInt);
                avatar.Birthday = avatar.Birthday.AddDays(r.Next(0,365));
                avatar.Birthday = avatar.Birthday.AddSeconds(r.Next(0, 60*60*24));
                avatar.SoldDate = DateTime.Now.AddYears(-1 * r.Next(1, bdInt));
                avatar.SoldDate = avatar.SoldDate.AddDays(r.Next(0, 365));
                avatar.SoldDate = avatar.SoldDate.AddSeconds(r.Next(0, 60 * 60 * 24));
            }

        }

    }
}
