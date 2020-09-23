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
        public DBInit(IAvatarRepository avatarRepository, IOwnerRepository ownerRepository)
        {
            _avatarRepository = avatarRepository;
            _ownerRepository = ownerRepository;
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
                      Type = "Meliodas",
                      Birthday = DateTime.Now.Date,
                      SoldDate = DateTime.Now.Date,
                      Color = "blue",
                      Owner = "Bradley",
                      Price = 250
        });
            _avatarRepository.Create(new Avatar
        {
                     Name = "Chili",
                     Type = "Wrath",
                     Birthday = DateTime.Now.AddYears(-1*r.Next(1,100)),
                     SoldDate = DateTime.Now.Date.AddYears(-5),
                     Color = "purple",
                     Owner = "Lotte",
                     Price = 400
                 });
            _avatarRepository.Create(new Avatar
            {
                Name = "Bunsy",
                Type = "Sloth",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "purple",
                Owner = "Peter",
                Price = 400
            }); _avatarRepository.Create(new Avatar
            {
                Name = "Melon",
                Type = "Greed",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "purple",
                Owner = "Bradley",
                Price = 400
            }); _avatarRepository.Create(new Avatar
            {
                Name = "Meliodas",
                Type = "Wrath",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "purple",
                Owner = "Bradley",
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
