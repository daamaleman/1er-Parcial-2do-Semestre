﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uso_if.models
{
    internal class Evaluate
    {
        public Evaluate() { }

        public string EvalAge(int age)
        { 
        try //Trata de hacer algo
        {
            if (age >= 0 && age <= 12) return "Eres un niño";
            else if (age >= 13 && age <= 25) return "Eres un joven";
            else if (age >= 26) return "Eres un adulto";
        }catch (Exception ex) //Atrapa el error
        {
            return $"Error (ex.ToString)";
        }
        return "Edad no admitida";
    } 
   }
}