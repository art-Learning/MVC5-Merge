using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            //���o�|���R�����
            return base.All().Where(x => x.isDelete == false);
        }

        public Client Find(int id)
        {
            return this.All().Where(x => x.ClientId == id).FirstOrDefault();
        }

	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}