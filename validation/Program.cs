using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValidationService;
using System.Text.RegularExpressions;
//Mark Joshua R. Abrenica
//abrenicamarkjoshua@gmail.com
namespace validation {
    class Program {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine();
               Console.WriteLine("System start.");
               string input = Console.ReadLine();
               Console.WriteLine();
               if (input == "quit")
               {
                   start = false;
                   return;
               }
               rule mustBeNumber = rulesCollection.mustBeNumber(input);
                //validation
               ValidationService.Validation validationOutput = ValidationService.Validation.execute(
                   new List<rule>()
                   {
                       //SET: set rules (condition logic) Here. you can customize the logics and error messages here. you can create variable instances of rules or can create it inline
                      
                       new rule(new Error(100,"must not be greather than 9 characters") , !(input.Length > 9)),
                       new rule(new Error(200,"must not contain spaces"), !(input.Contains(' '))),
                       new rule(new Error(300,"must not be less than 3 digits"), !(input.Length<3)),
                       //and other rules like...
                      mustBeNumber
                   });
                //addition validation logic.
                if(validationOutput.Rules.Contains(mustBeNumber) && validationOutput.HasError == false){
                    validationOutput = ValidationService.Validation.execute(
                        new List<rule>(){
                            new rule(new Error(111, "must not be greater than 300"), !((int.Parse(input) > 300))),
                            new rule(new Error(111, "must not be less than 200"), !((int.Parse(input) < 200)))

                        }
                        );
                }
                //handling errors
               if (validationOutput.HasError)
               {
                   foreach(Error error in validationOutput.Errors){
                       Console.WriteLine("Error code: " + error.ErrorNo.ToString() + ": " + error.ErrorMessage);
                   }
               }
               else
               {
                   Console.WriteLine("no errors");
               }
              
            }
        }
    }
}
