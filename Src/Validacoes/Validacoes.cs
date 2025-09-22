/*
*	<copyright file="Validacoes.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:13:26 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using Enums;

namespace Validacoes
{
    /// <summary>
    /// Class que tem como objetivo ter funcoes de validacao
    /// </summary>
    public class Validar
    {
        /// <summary>
        /// Funcao que verifica se o email introduzido e valido
        /// </summary>
        /// <param name="email">Email que se esta a tentar introduzir</param>
        /// <returns>Se email e valido ou nao</returns>
        public static bool VerificaEmail(string email)
        {   
            MailAddress enderecoEmail = new MailAddress(email);
            if(email == enderecoEmail.Address)
            {
                return true;
            }
            else
            {
                throw new ValidationException(Erro.EMAIL_INVALIDO);
            }
        }

        /// <summary>
        /// Funcao que verifica se um numero de contacto introduzido e valido
        /// </summary>
        /// <param name="contacto">Contacto que se pretende introduzir</param>
        /// <returns>Se contacto e valido ou nao</returns>
        public static bool VerificaContacto(string contacto)
        {
            if (contacto.Length == 9)
            {
                return true;
            }
            else
            {
                throw new ValidationException(Erro.CONTACTO_INVALIDO);
            }
        }
    }
}
