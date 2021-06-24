
using CalculadoraFatorial.Shared;
using System;
using System.Collections.Generic;

namespace CalculadoraFatorial.Server.Services
{
    public class FatorialService
    {
        double finalresult;

        double fat;
        public double funcaoFatorial(double num1)
        {
        
            for (fat = 1; num1 > 1; num1 = num1 - 1)

            fat = fat * num1;

            finalresult = fat;

            return finalresult;

        }
    }
}

