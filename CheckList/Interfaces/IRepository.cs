namespace CheckList.Interfaces;

internal interface IRepository<T> : IDisposable where T : class
{
    /// <summary>
    /// Получение всех объектов.
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<T>> GetEntityListAsync();

    /// <summary>
    /// Получение одного объекта по id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<T> GetByIdAsync(int id); 
        
    /// <summary>
    /// Создание объекта.
    /// </summary>
    /// <param name="item"></param>
    void CreateAsync(T item);
        
    /// <summary>
    /// Создание объектов.
    /// </summary>
    /// <param name="item"></param>
    void CreateAsync(IEnumerable<T> item); 
        
    /// <summary>
    /// Обновление объекта.
    /// </summary>
    /// <param name="item"></param>
    void UpdateAsync(T item); 
        
    /// <summary>
    /// Удаление объекта по id.
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id);
        
    /// <summary>
    /// Сохранение изменений.
    /// </summary>
    void SaveAsync();
}

