using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MailSubscribeManager : IMailSubscribeService
    {
        IMailSubscribeDal _mailSubscribeDal;

        public MailSubscribeManager(IMailSubscribeDal mailSubscribeDal)
        {
            _mailSubscribeDal = mailSubscribeDal;
        }

        public void TAdd(MailSubscribe t)
        {
            _mailSubscribeDal.Insert(t);
        }

        public void TDelete(MailSubscribe t)
        {
            _mailSubscribeDal.Delete(t);
        }

        public MailSubscribe TGetById(int id)
        {
            return _mailSubscribeDal.GetById(id);
        }

        public List<MailSubscribe> TGetList()
        {
            return _mailSubscribeDal.GetListAll();
        }

        public void TUpdate(MailSubscribe t)
        {
            _mailSubscribeDal.Update(t);
        }
    }
}
