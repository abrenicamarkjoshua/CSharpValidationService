using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Mark Joshua R. Abrenica
//abrenicamarkjoshua@gmail.com
namespace ValidationService {
    public class Error {
        public int ErrorNo { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
        public Error(Int32 errorNo, string error)
        {
            this.ErrorNo = errorNo;
            this.ErrorMessage = error;
        }
        public Error(int errorNo, string error, string errorDetails)
        {
            this.ErrorNo = errorNo;
            this.ErrorMessage = error;
            this.ErrorDetails = errorDetails;
        
        }
    }
}
