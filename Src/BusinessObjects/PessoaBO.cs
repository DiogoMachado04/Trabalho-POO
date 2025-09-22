/*
*	<copyright file="BusinessObjects.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:13:26 PM</date>
*	<description></description>
**/
using System;

namespace BusinessObjects
{
    /// <summary>
    /// Purpose: Class PessoaBO que contem o id e o nome da pessoa
    /// Created by: diogo
    /// Created on: 12/20/2024 3:13:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class PessoaBO
    {
        #region Attributes
        int id;
        string nome;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public PessoaBO()
        {
        }

        /// <summary>
        /// Construtor da class PessoaBO com a indicacao do id e do nome
        /// </summary>
        /// <param name="id">Id da Pessoa</param>
        /// <param name="nome">Nome da Pessoa</param>
        public PessoaBO(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Get ou set do id da Pessoa
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Get ou set do nome da Pessoa
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~PessoaBO()
        {
        }
        #endregion

        #endregion
    }
}
