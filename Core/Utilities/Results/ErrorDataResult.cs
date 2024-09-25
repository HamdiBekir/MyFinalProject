using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //1.Versyon
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //2.Versiyon
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //3.Versiyon
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //4.Versiyon
        public ErrorDataResult() : base(default, false)
        {

        }
    }
