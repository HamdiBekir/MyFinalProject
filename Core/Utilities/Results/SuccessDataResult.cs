using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //1.Versyon
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        //2.Versiyon
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //3.Versiyon
        public SuccessDataResult(string message):base(default,true,message) 
        {
            
        }
        //4.Versiyon
        public SuccessDataResult():base(default,true) 
        {
            
        }
    }
}
