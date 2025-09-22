/*
*	<copyright file="BusinessObjects.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:23:49 PM</date>
*	<description></description>
**/
using System;
using Enums;
namespace BusinessObjects
{
    /// <summary>
    /// Purpose: Class BombeiroBO que contem a patente do bombeiro
    /// Created by: diogo
    /// Created on: 12/20/2024 3:23:49 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class BombeiroBO : PessoaBO
    {
        #region Attributes
        PatenteBombeiro patente;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public BombeiroBO()
        {
        }

        /// <summary>
        /// Construtor da class BombeiroBO com a indicacao do id, nome e patente
        /// </summary>
        /// <param name="id">Id do bombeiro</param>
        /// <param name="nome">Nome do bombeiro</param>
        /// <param name="patente">Patente do bombeiro</param>
        public BombeiroBO(int id, string nome, PatenteBombeiro patente) : base(id, nome)
        {
            this.patente = patente;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Get ou set da patente do bombeiro
        /// </summary>
        public PatenteBombeiro Patente
        {
            get { return patente; }
            set { patente = value; }
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
        ~BombeiroBO()
        {
        }
        #endregion

        #endregion
    }
}
