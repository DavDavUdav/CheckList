using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Interfaces
{
    internal interface IRepository<T> : IDisposable where T : class
    {
        Task<IEnumerable<T>> GetEntityListAsync(); // получение всех объектов
        Task<T> GetByIdAsync(int id); // получение одного объекта по id
        void CreateAsync(T item); // создание объекта
        void CreateAsync(IEnumerable<T> item); // создание объектов
        void UpdateAsync(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void SaveAsync();  // сохранение изменений
    }
}
