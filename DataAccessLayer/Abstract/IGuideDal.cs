using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal:IGenericDal<Guide>
    {
        //ekle metodu, Guide dan parametre aldık
        //void Insert(Guide guide);
        //silme metodu
        //void Delete(Guide guide);
        //güncelle metodu
        //void Update(Guide guide);
        //listeleme
        //List<Guide> GetList();
    }
}
