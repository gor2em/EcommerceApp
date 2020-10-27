﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.BLL.Abstraction
{
    public interface IManager<T> where T : class
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
