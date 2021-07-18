using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryCRUDData.Models.DAL
{
    //Generic interface to perform CRUD operation
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAlldata();
        T GetDataByID(int Id);
        void InsertData(T model);
        void DeleteData(int Id);
        void UpdateData(T model);
        void Save();
    }
}
