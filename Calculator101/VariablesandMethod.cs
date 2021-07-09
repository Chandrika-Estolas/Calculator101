using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator101
{
    class VariablesandMethod
    {
        public string Operation_str;
        public string UserInput;
        public float Result; 
        public float second;
        public bool IsOperationPressed;

        private string numInput1;
        public string NumInput1
        {
            get
            {
                return numInput1;
            }

            set
            {
                numInput1 = value;
            }
        }

        private string numInput2;

        public string NumInput2
        {
            get
            {
                return numInput2;
            }

            set
            {
                numInput2 = value;
            }
        }

        public void Calculation()
        {
            second = float.Parse(NumInput2);

                if (Operation_str == "x")
                    Result = float.Parse(NumInput1) * (second);
                NumInput2 = string.Empty + Result.ToString();

                if (Operation_str == "/")
                {
                    if (second == 0)
                    {
                        NumInput2 = "Undefined";
                    }
                    else
                    {
                        Result = float.Parse(NumInput1) / (second);
                        NumInput2 = string.Empty + Result.ToString();
                    }
                }

                if (Operation_str == "+")
                    Result = float.Parse(NumInput1) + (second);
                NumInput2 = string.Empty + Result.ToString();

                if (Operation_str == "-")
                    Result = float.Parse(NumInput1) - (second);
                NumInput2 = string.Empty + Result.ToString();
            
        }
    }
}
