using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GenericRepositoryCRUDData.Models.DAL
{
    public class AllRepository<T> : IRepository<T> where T : class
    {
        private DemoEntities _context;
        private IDbSet<T> _dbEntity;

        public AllRepository()
        {
            _context = new DemoEntities();
            _dbEntity = _context.Set<T>();
        }

        public void DeleteData(int Id)
        {
            T model = _dbEntity.Find(Id);
            _dbEntity.Remove(model);
        }

        public IEnumerable<T> GetAlldata()
        {
            return _dbEntity.ToList();
        }

        public T GetDataByID(int Id)
        {
            return _dbEntity.Find(Id);
        }

        public void InsertData(T model)
        {
            _dbEntity.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateData(T model)
        {
            _context.Entry(model).State = EntityState.Modified;
        }
    }
}