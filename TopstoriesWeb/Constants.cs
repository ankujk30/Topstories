using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesWeb
{
    public static class Constants
    {
        //Details to make API call
        public const string APIBaseUrl = "https://localhost:44350/";
        public const string TopstoriesAPIPath = APIBaseUrl + "api/Topstories/";

        //Messages for users
        public const string UnauthorizeErrorMessage = "Please enter valid API key";
        public const string SaveErrorMessage = "Something went wrong while saving the data";
        public const string SaveSuccessMessage = "Data added successfully. Please check database to verify the records";
        public const string ReqErrorMessage = "Something went wrong while processing the request";
        public const string CompleteRequest = "Request completed successfully. Please check database to verify the records";
        public const string DefaultMessage = "Status code is not known. Please try again after some time";
        
    }
}
