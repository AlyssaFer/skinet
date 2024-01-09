using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLitePCL;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            //?? means if the Message=message is null thne execute what is to the right of the ??
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Internal Server Error, errors lead to anger",
                _ => null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}