﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetMessageInBox(int id)
        {
            return _messageDal.GetInBoxListwithWriter(id);
        }

        public List<Message> GetMessageSendBox(int id)
        {
            return _messageDal.GetSendBoxListwithWriter(id);
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
