using SDS.Core.Domain_Service;
using SDS.Core.Entity;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;


namespace SDS.Infrastructure.Data
{
    public static class DBInit
    {
        public static List<AvatarType> avatarTypeLists = new List<AvatarType>();
        public static List<Owner> ownerLists = new List<Owner>();
        public static List<Avatar> avartarLists = new List<Avatar>();
        public static int Id = 1;

        public static void InitData()
        {
            Random r = new Random();
            avartarLists.Add(new Avatar
            {
                Name = "Bradley",
                AvatarType = "Wrath",
                Birthday = DateTime.Now.Date,
                SoldDate = DateTime.Now.Date,
                Color = "black",
                Owner = "Chili",
                Id = Id++,
                Price = 900
            });
            avartarLists.Add(new Avatar
            {
                Name = "Chili",
                AvatarType = "Goddess",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Pink",
                Owner = "Bradley",
                Id = Id++,
                Price = 800
            });

            avartarLists.Add(new Avatar
            {
                Name = "Bunsy",
                AvatarType = "Sloth",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Blue",
                Owner = "Chili",
                Id = Id++,
                Price = 600
            });

            avartarLists.Add(new Avatar
            {
                Name = "Meliodas",
                AvatarType = "Wrath",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Dark Purple",
                Owner = "Chili",
                Id = Id++,
                Price = 400
            });
            avartarLists.Add(new Avatar
            {
                Name = "Melon",
                AvatarType = "Greed",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Sand",
                Owner = "Bradley",
                Id = Id++,
                Price = 400
            }); avartarLists.Add(new Avatar
            {
                Name = "Ban",
                AvatarType = "Greed",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Red",
                Owner = "Lotte",
                Id = Id++,
                Price = 400
            });
            avartarLists.Add(new Avatar
            {
                Name = "Diane",
                AvatarType = "Envy",
                Birthday = DateTime.Now.AddYears(-1 * r.Next(1, 100)),
                SoldDate = DateTime.Now.Date.AddYears(-5),
                Color = "Orange",
                Owner = "Peter",
                Id = Id++,
                Price = 400
            }); 

            // Id keeps incrementing through lists. avatartypes get id's like 13 and 15..
            ownerLists.Add(new Owner
            {
                Id = Id++,
                FirstName = "Peter",
                LastName = "Pan",
                Address = "Mælkevejen",
                PhoneNumber = "20252414",
                Email = "LostBoy@putmail.com"

            });

            ownerLists.Add(new Owner
            {
                Id = Id++,
                FirstName = "Lotte",
                LastName = "Pedersen",
                Address = "IpCom",
                PhoneNumber = "24582414",
                Email = "Lotte@gmail.com"

            });
            
            ownerLists.Add(new Owner
               {
                   Id = Id++,
                   FirstName = "Bradley",
                   LastName = "Swords",
                   Address = "Sao",
                   PhoneNumber = "12454525",
                   Email = "LostBoy@sao.com"

               });
            ownerLists.Add(new Owner
            {
                Id = Id++,
                FirstName = "Chili",
                LastName = "Love",
                Address = "LaLaLand",
                PhoneNumber = "15865525",
                Email = "FoundBoy@sins.com"

            });

            avatarTypeLists.Add(new AvatarType
            {
                Id = Id++,
                TypeOfAvatar = "Wrath"


            });
            avatarTypeLists.Add(new AvatarType
            {
                Id = Id++,
                TypeOfAvatar = "Greed"


            }); avatarTypeLists.Add(new AvatarType
            {
                Id = Id++,
                TypeOfAvatar = "Envy"


            }); avatarTypeLists.Add(new AvatarType
            {
                Id = Id++,
                TypeOfAvatar = "Sloth"


            });
            avatarTypeLists.Add(new AvatarType
            {
                Id = Id++,
                TypeOfAvatar = "Goddess"

            });

          


            // GiantMock.AddToRepo(_avatarRepository);
            foreach (Avatar avatar in avartarLists) {
                int bdInt = r.Next(1, 100);
                avatar.Birthday = DateTime.Now.AddYears(-1 * bdInt);
                avatar.Birthday = avatar.Birthday.AddDays(r.Next(0,365));
                avatar.Birthday = avatar.Birthday.AddSeconds(r.Next(0, 60*60*24));
                avatar.SoldDate = DateTime.Now.AddYears(-1 * r.Next(1, bdInt));
                avatar.SoldDate = avatar.SoldDate.AddDays(r.Next(0, 365));
                avatar.SoldDate = avatar.SoldDate.AddSeconds(r.Next(0, 60 * 60 * 24));
            }

        }
        public static List<Avatar> GetAllAvatars()
        {
            return avartarLists;
        }
        public static List<Owner> GetOwners() 
        {
            return ownerLists;
        }
        public static List<AvatarType> GetAvatarTypes()
        {
            return avatarTypeLists;
        }
        public static int GetNextId()
        {
            return Id;
        }

    }
}
