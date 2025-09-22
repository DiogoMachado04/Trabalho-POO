/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 7:22:11 PM</date>
*	<description></description>
**/
using System;
using Enums;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class MembroINEM que recebe heranca da class Pessoa e 
    /// contem a especialidade do membro do INEM
    /// Created by: diogo
    /// Created on: 11/13/2024 7:22:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class MembroINEM : Pessoa
    {
        #region Attributes
        EspecialidadeINEM especialidade;    //Especialidade do membro do INEM
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public MembroINEM()
        {
        }
        
        /// <summary>
        /// Contrutor da class MembroINEM que indica apenas o membro do INEM
        /// </summary>
        /// <param name="especialidade">Especialidade do membro do INEM</param>
        public MembroINEM(EspecialidadeINEM especialidade)
        {
            this.especialidade = especialidade;
        }

        /// <summary>
        /// Construtor da class Membro INEM que indica a especialidade 
        /// e todos os atributos da class Pessoa que dizem respeito ao membro do INEM
        /// </summary>
        /// <param name="nome">Nome do membro do INEM</param>
        /// <param name="contacto">Numero de contacto do membro do INEM</param>
        /// <param name="email">Email do membro do INEM</param>
        /// <param name="especialidade">Especialidade do membro do INEM</param>
        public MembroINEM(string nome, string contacto, string email, EspecialidadeINEM especialidade)
            : base(nome, contacto, email)
        {
            this.especialidade = especialidade;
        }

        public MembroINEM(string nome, EspecialidadeINEM especialidade) : base(nome)
        {
            this.especialidade = especialidade;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Get ou set da especialidade do membro do INEM 
        /// </summary>
        public EspecialidadeINEM Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma o objeto MembroINEM em texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format("Especialidade:{0}\n", especialidade.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~MembroINEM()
        {
        }
        #endregion

        #endregion
    }
}
