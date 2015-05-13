using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Mark Joshua R. Abrenica
//abrenicamarkjoshua@gmail.com
namespace ValidationService {
   
   public class rule {
       
        public Error Error { get; set; }
        public bool hasError { get; set; }
        
        public rule(Error error, bool condition)
        {
            hasError = !condition;
            Error = error;
        }

    }
}
