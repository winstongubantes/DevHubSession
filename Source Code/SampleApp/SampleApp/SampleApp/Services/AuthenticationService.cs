using System;
using System.Collections.Generic;
using System.Text;
using SampleApp.Models;

namespace SampleApp.Services
{
    public class AuthenticationService
    {
        public bool AuthenticateUserPassword(DtoAuthModel authModel)
        {
            //You might call your webservice here to authenticate

            return true; //for test sake, we return true
        }
    }
}
