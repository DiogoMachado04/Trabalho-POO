/*
*	<copyright file="BusinessObjects.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:25:52 PM</date>
*	<description></description>
**/
using System;
using Enums;
namespace BusinessObjects
{
    /// <summary>
    /// Purpose: Class MembroINEMBO que contem a especialidade do membro do INEM
    /// Created by: diogo
    /// Created on: 12/20/2024 3:25:52 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class MembroINEMBO : PessoaBO
    {
        #region Attributes
        EspecialidadeINEM especialidade;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public MembroINEMBO()
        {
        }

        /// <summary>
        /// Construtor da class MembroINEMBO com a indicacao do id, nome e especialidade
        /// </summary>
        /// <param name="id">Id do membro</param>
        /// <param name="nome">Nome do membro</param>
        /// <param name="especialidade">Especialidade do membro</param>
        public MembroINEMBO(int id, string nome, EspecialidadeINEM especialidade) : base(id, nome)
        {
            this.especialidade = especialidade;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get ou set da especialidade do membro
        /// </summary>
        public EspecialidadeINEM Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
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
        ~MembroINEMBO()
        {
        }
        #endregion

        #endregion
    }
}
