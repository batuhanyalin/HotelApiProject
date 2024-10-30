using HotelApiProject.BusinessLayer.Abstract;
using HotelApiProject.DataAccessLayer.Abstract;
using HotelApiProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApiProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _ContactDAL;

        public ContactManager(IContactDAL ContactDAL)
        {
            _ContactDAL = ContactDAL;
        }

        public void TDelete(Contact t)
        {
            _ContactDAL.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _ContactDAL.GetById(id);
        }

        public List<Contact> TGetList()
        {
           return _ContactDAL.GetList();
        }

        public void TInsert(Contact t)
        {
            _ContactDAL.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _ContactDAL.Update(t);
        }
    }
}
