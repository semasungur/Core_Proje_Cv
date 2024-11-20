using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //identity işlemi için context sınıfında rol alması lazım bu sınıf o yüzden
    public class WriterRole:IdentityRole<int>
    {
    }
}
