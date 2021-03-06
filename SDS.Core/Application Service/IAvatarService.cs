﻿using System;
using System.Collections.Generic;
using SDS.Core.Entity;

namespace SDS.Core.Application_Service
{
    public interface IAvatarService
    {

        public List<Avatar> GetAvatars();

        Avatar AvatarCreate(string AvatarType, string name, DateTime birthday, DateTime soldDate, string color, string Owner, double price);

        Avatar Create(Avatar avatar);

        Avatar Update(Avatar avatar);

        Avatar Delete(int id);

        public List<Avatar> GetAvatars5Cheapest();

        public List<Avatar> GetAvatarsSortByPrice();

        Avatar ReadById(int id);
    }
}
