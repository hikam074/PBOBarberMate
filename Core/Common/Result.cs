using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBOBarberMate.Core.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; }
        public string Message { get; }
        protected Result(bool _isSuccess, T _data, string _message)
        {
            IsSuccess = _isSuccess;
            Data = _data;
            Message = _message;
        }
        public static Result<T> Success(T _data, string _message = "") => new(true, _data, _message);
        public static Result<T> Failure(string _message) => new(false, default, _message);
    }
}
