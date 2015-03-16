using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Spartakiade2015.UiManipulation.BL
{
    public class DocumentController : BaseController
    {
        public override void InitDataSource()
        {
            this.ObjectId = Guid.NewGuid();
            base.InitDataSource();
        }
    }
}
