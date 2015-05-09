using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(x => ! x.isDelete);
        }

        public IQueryable<Client> Qry(string Gender)
        {
            return base.All().Where(x => !x.isDelete && x.Gender == Gender);
        }
        public IQueryable<Client> SearchCity(string City)
        {
            if (String.IsNullOrEmpty(City))
            {
                return base.All().Where(x => !x.isDelete);
            }
            else
           {
               return base.All().Where(x => !x.isDelete && x.City == City);
            }
        }
        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }


        public override void Delete(Client entity)
        {
            //client.IsDelete = true;

            var db = ((FabricsEntities)this.UnitOfWork.Context);
            foreach (var item in db.Order.ToList())
            {
                db.OrderLine.RemoveRange(item.OrderLine);
            }
            db.Order.RemoveRange(entity.Order);
        }
        internal IQueryable<Client> §ì­º­¶¸ê®Æ(int num)
        {
            return this.All().Take(num);
        }
    }

	public  interface IClientRepository : IRepository<Client>
	{

	}
}