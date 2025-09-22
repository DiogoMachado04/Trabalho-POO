/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/7/2024 4:54:40 PM</date>
*	<description></description>
**/
using System;
using Validacoes;
using Exceptions;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Pessoa com todos os atributos que dizem respeito a uma pessoa
    /// Created by: diogo
    /// Created on: 11/7/2024 4:54:40 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        int id;                     //ID da pessoa
        string nome;                //Nome da pessoa
        string contacto;            //Numero de contacto da pessoa
        string email;               //Email da pessoa
        static int idCounter = 0;   //Variavel estatica que serve como contador dos IDs das pessoas
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            idCounter++;
            id = idCounter;
        }

        /// <summary>
        /// Contrutor da classe Pessoa com indicacao de todos os seus atributos
        /// </summary>
        /// <param name="nome">Nome da pessoa</param>
        /// <param name="contacto">Numero de contacto da pessoa</param>
        /// <param name="email">Email da pessoa</param>
        public Pessoa(string nome, string contacto, string email)
        {
            idCounter++;
            id = idCounter;
            this.nome = nome;
            try
            {
                if (Validar.VerificaContacto(contacto))
                {
                    this.contacto = contacto;
                }
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            try
            {
                if (Validar.VerificaEmail(email))
                {
                    this.email = email;
                }
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Pessoa(string nome)
        {
            idCounter++;
            id = idCounter;
            this.nome = nome;
        }


        #endregion

        #region Properties

        /// <summary>
        /// Get do Id de pessoa
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Get ou Set do nome da pessoa
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Get ou set do numero de contacto da pessoa
        /// </summary>
        public string Contacto
        {
            get { return contacto; }
            set
            {
                if (Validar.VerificaContacto(value))
                {
                    contacto = value;
                }
            }
        }

        /// <summary>
        /// Get ou Set do email da pessoa
        /// </summary>
        public string Email
        {
            get { return email; }
            set {
                if (Validar.VerificaEmail(value))
                {
                    email = value;
                }
            }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma Pessoa em texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
            return string.Format("ID:{0}\nNome:{1}\nContacto:{2}\nEmail:{3}\n",
                id.ToString(), nome, contacto, email);
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
