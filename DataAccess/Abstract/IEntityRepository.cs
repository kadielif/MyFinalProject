using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new() //T bitek class=referans tip, IEntity:IEntity yada IEntity imlemente eden bir nesne olabilir. Ve T new'lenebilir olmalı 
    {
        //Expression<Func<T, bool>> filter = null bu kısım fonksiyonu çağırırken parametre olarak filtre ekleyebilmemizi sağlıyor
        //_productDal.GetAll(p=>p.CatagoryId==2); gibi
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtre verilmeyedebilir. _productDal.GetAll();
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
