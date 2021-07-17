using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HilaWeiser_align.Models
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMsg { get; set; }
        public T Data { get; set; }

        public void SetSuccess(T data)
        {
            IsSuccess = true;
            Data = data;
        }

        public void SetFail(string error)
        {
            IsSuccess = false;
            ErrorMsg = error;
        }
    }
}
