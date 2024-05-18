using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{

    public class ApplicationUser:IdentityUser<string>
    {

    }

    //public class ApplicationDbContext : IdentityDbContext<ApplicationUser,int>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,string>
    {
        //Fix by changing int to string
    }

    public class IdentityDbContext<TUser,T> 
        where TUser : IdentityUser<T>
    {
        public List<TUser> Users { get; set; }
    }
    public class IdentityUser<T>
    { 
        public T Id { get; set; }
        public string UserName { get; set; }
    }


}
