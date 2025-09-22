/*
*	<copyright file="ValidationException.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:13:26 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;
namespace Exceptions
{
    /// <summary>
    /// Class que contem a excecao de validacao
    /// </summary>
    public class ValidationException : Exception
    {
        public Erro erro { get; }

        public ValidationException() : base("Erro de validação") { }
        public ValidationException(Erro cod)
        {
            erro = cod;
        }
    }
}
