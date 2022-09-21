﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //Generic metodlar C#'ta genel,
    //belirli bir veri türüne özgü olmayan anlamına gelir.
    //Genel türün bir örneğini oluştururken belirtilen belirli bir tür için bir yer tutucudur
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
    }
}
