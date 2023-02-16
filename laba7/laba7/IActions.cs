using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IActions<T>
{
    void Add(T bookname);
    void Delete(T number);
    void Display();


}
