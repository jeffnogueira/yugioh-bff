using System;

namespace yugioh_bff.Application.Models
{
    public class ApiException : Exception
    {
        public string ErrorMessage { get; set; }
        public int StatusCode { get; set; }

        public ApiException(
            string ErrorMessage,
            int StatusCode
        )
        {
            this.ErrorMessage = ErrorMessage;
            this.StatusCode = StatusCode;
        }
    }
}
