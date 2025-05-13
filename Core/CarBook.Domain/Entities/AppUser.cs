using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string AppUserName { get; set; }
        public string AppUserPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int AppUserRoleId { get; set; }
        [ForeignKey("AppUserRoleId")]
        public AppRole AppRole { get; set; }
    }
}
