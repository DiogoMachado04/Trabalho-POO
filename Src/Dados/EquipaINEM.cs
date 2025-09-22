/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 7:42:47 PM</date>
*	<description></description>
**/
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class EquipaINEM que contem um Dicionario de membros do INEM e o nome da equipa
    /// Created by: diogo
    /// Created on: 11/13/2024 7:42:47 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EquipaINEM : IMetodos<MembroINEM>
    {
        #region Attributes
        string nome;                           //Nome da equipa de INEM
        Dictionary<int, MembroINEM> equipa;    //Dicionario de membros do INEM
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EquipaINEM()
        {
            this.nome= "INEM de Braga";
            equipa = new Dictionary<int, MembroINEM>();
        }

        /// <summary>
        /// Contrutor da class EquipaINEM com a indicacao do nome da equipa
        /// </summary>
        /// <param name="nome">Nome da equipa de INEM</param>
        public EquipaINEM(string nome)
        {
            this.nome = nome;
            equipa = new Dictionary<int, MembroINEM>();
        }



        #endregion

        #region Properties

        /// <summary>
        /// Get ou set do nome da equipa de INEM
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma a equipa de INEM em texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
            if (equipa.Count == 0)
            {
                return "A equipa nao tem pessoas";
            }
            string infoEquipa = string.Join("\n", equipa.Select(MembroINEM => MembroINEM.ToString()));
            return infoEquipa;
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Funcao que adiciona um determinado membro no dicionario da equipa de membros do INEM
        /// </summary>
        /// <param name="membro">Membro do INEM que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool Adiciona(MembroINEM membro)
        {
            if (membro == null || Existe(membro.Id))
            {
                return false;
            }
            equipa.Add(membro.Id, membro);
            return true;
        }

        /// <summary>
        /// Funcao que verifica se existe um determinado membro na equipa de membros do INEM
        /// </summary>
        /// <param name="id">ID do membro do INEM que se pretende verificar se existe</param>
        /// <returns>Se existe na equipa ou nao</returns>
        public bool Existe(int id)
        {
            return equipa.ContainsKey(id);
        }

        /// <summary>
        /// Funcao que remove um determinado membro da equipa de membros do INEM
        /// </summary>
        /// <param name="id">ID do membro do INEM que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool Remove(int id)
        {
            if(Existe(id))
            {
                equipa.Remove(id);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Funcao que devolve as informacoes de um membro do INEM
        /// </summary>
        /// <param name="idMembro">Id do membro</param>
        /// <returns>Informacoes do MembroINEM</returns>
        public MembroINEMBO GetMembro(int idMembro)
        {
            equipa.TryGetValue(idMembro, out MembroINEM membro);
            MembroINEMBO membroINEMBO = new MembroINEMBO(membro.Id, membro.Nome, membro.Especialidade);
            return membroINEMBO;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~EquipaINEM()
        {
        }
        #endregion

        #endregion
    }
}
