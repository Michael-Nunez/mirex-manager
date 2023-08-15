﻿namespace MirexManager.Domain.Abstractions;

public interface IRepository<T> where T : class
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}
