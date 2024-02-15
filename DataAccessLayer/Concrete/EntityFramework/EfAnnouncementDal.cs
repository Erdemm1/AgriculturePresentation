using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnoucementDal : GenericRepository<Annoucement>, IAnnoucementDal
    {
        public void AnnoucementStatusToFalse(int id)
        {
            using var context = new AgricultureContext();
            Annoucement p = context.Annoucements.Find(id);
            p.Status = false;
            context.SaveChanges();
        }

        public void AnnoucementStatusToTrue(int id)
        {
            using var context = new AgricultureContext();
            Annoucement p = context.Annoucements.Find(id);
            p.Status = true;
            context.SaveChanges();
        }
    }
}
