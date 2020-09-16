using System;
using System.Collections.Generic;
using System.Text;

namespace SDS.Core.Entity
{
    public class AvatarType
    {
        public int id { get; set; }
        public string nameType { get; set; }

        public List<Avatar> avatarTypeList { get; set; }

    }
}
