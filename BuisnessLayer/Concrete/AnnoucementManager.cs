using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class AnnoucementManager : IAnnoucementService
    {
        private readonly IAnnoucementDal _annoucementDal;

        public AnnoucementManager(IAnnoucementDal annoucementDal)
        {
            _annoucementDal = annoucementDal;
        }

        public void AnnoucementStatusToFalse(int id)
        {
            _annoucementDal.AnnoucementStatusToFalse(id);
        }

        public void AnnoucementStatusToTrue(int id)
        {
            _annoucementDal.AnnoucementStatusToTrue(id);
        }

        public void Delete(Annoucement t)
        {
            _annoucementDal.Delete(t);
        }

        public Annoucement GetById(int id)
        {
            return _annoucementDal.GetById(id);
        }

        public List<Annoucement> GetListAll()
        {
            return _annoucementDal.GetListAll();
        }

        public void Insert(Annoucement t)
        {
            _annoucementDal.Insert(t);
        }

        public void Update(Annoucement t)
        {
            _annoucementDal.Update(t);
        }
    }
}
