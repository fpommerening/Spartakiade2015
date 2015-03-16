using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Spartakiade2015.UiManipulation.BL
{
    public class UserController : BaseController
    {
        public UserController()
        {
            ObjectId = Guid.NewGuid();
        }
    }
}
