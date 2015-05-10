using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.ViewModel
{
    public class EnumViewModel
    {
        public enum MemberLevel
        {
            NormalUser,
            Admin
        }
        public string UserNM { get; set; }
        public string UserPW { get; set; }
        [UIHint("Enum-Radio")]
        public MemberLevel UserLV { get; set; }
    }
}