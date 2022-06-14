using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace TopstoriesWeb
{
    public static class ErrorMessage
    {
        //Check the status code and return message accordingly
        public static string CheckErrorMEssage(HttpStatusCode statusCode)
        {
            string errorMessage;

            switch (statusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized:
                    errorMessage = Constants.UnauthorizeErrorMessage;
                    break;

                case System.Net.HttpStatusCode.BadRequest:
                    errorMessage = Constants.ReqErrorMessage;
                    break;

                default:
                    errorMessage = Constants.DefaultMessage;
                    break;
            }

            return errorMessage;
        }
    }
}
