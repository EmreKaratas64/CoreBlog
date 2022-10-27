using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageDal:GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetInBoxListwithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages.Include(x => x.SenderUser).Where(y => y.ReceiverId == id).ToList();
            }
        }

        public List<Message> GetSendBoxListwithWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Messages.Include(x => x.ReceiverUser).Where(y => y.SenderId == id).ToList();
            }
        }
    }
}
