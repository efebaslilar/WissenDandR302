using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WissenDandR302EntityLayer.ResultModels
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data):base(false,data)
        {

        }
        public ErrorDataResult(T data, string msg):base(false,msg,data)
        {

        }
    }
}
