using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Mark Joshua R. Abrenica
//abrenicamarkjoshua@gmail.com
namespace ValidationService {
    public class Validation {
        public bool HasError { get; set; }
        public List<Error> Errors { get;set; }
        public List<rule> Rules { get; set; }
        public static Validation execute(List<rule> rules, Boolean StopOnError = false)
        {
            List<rule> _rules = rules;
            bool _HasError = false;
            List<Error> _Errors = new List<Error>();
            for (int i = 0; i <= rules.Count - 1; i++)
            {
                if (rules[i].hasError)
                {
                    _HasError = true;
                    _Errors.Add(rules[i].Error);
                    if (StopOnError)
                    {
                       
                        return new Validation()
                        {
                            HasError = _HasError,
                            Errors = _Errors,
                            Rules =rules
                        };
                        
                    }
                }
            }
            return new Validation()
            {
               
                HasError = _HasError,
                Errors = _Errors,
                Rules = rules
            };
           
        }
       

    }
}
