/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 7:46:35 PM</date>
*	<description></description>
**/
using System;
using Enums;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Bombeiro que recebe heranca da class Pessoa e 
    /// contem a patente do bombeiro
    /// Created by: diogo
    /// Created on: 11/13/2024 7:46:35 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bombeiro : Pessoa
    {
        #region Attributes
        PatenteBombeiro patente;        //Patente do bombeiro
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Bombeiro()
        {
        }

        /// <summary>
        /// Contrutor da class Bombeiro que indica apenas a patente do bombeiro
        /// </summary>
        /// <param name="patente">Patente do bombeiro</param>
        public Bombeiro(PatenteBombeiro patente)
        {
            this.patente = patente;
        }

        /// <summary>
        /// Contrutor da class Bombeiro que indica a patente
        /// e todos os atributos da class Pessoa que dizem respeito ao bombeiro
        /// </summary>
        /// <param name="nome">Nome do bombeiro</param>
        /// <param name="contacto">Numero de contacto do bombeiro</param>
        /// <param name="email">Email do bombeiro</param>
        /// <param name="patente">Patente do bombeiro</param>
        public Bombeiro(string nome, string contacto, string email, PatenteBombeiro patente) : base(nome, contacto, email)
        {
            this.patente = patente;
        }

        public Bombeiro(string nome, PatenteBombeiro patente) : base(nome)
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
        /// <summary>
        /// Funcao que transforma Bombeiro em formato texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("Patente:{0}\n", patente.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Bombeiro()
        {
        }
        #endregion

        #endregion
    }
}
