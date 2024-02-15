using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Abstract
{
    public interface IAnnoucementService : IGenericService<Annoucement>
    {
        void AnnoucementStatusToTrue(int id);
        void AnnoucementStatusToFalse(int id);
    }
}
