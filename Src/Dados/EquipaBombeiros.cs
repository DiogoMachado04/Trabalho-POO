/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 7:52:17 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace Dados 
{
    [Serializable]
    /// <summary>
    /// Purpose: Class EquipaBombeiros que contem um dicionario de bombeiros e o nome da equipa
    /// Created by: diogo
    /// Created on: 11/13/2024 7:52:17 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EquipaBombeiros : IMetodos<Bombeiro>
    {
        #region Attributes
        string nome;                           //Nome da equipa de bombeiros
        Dictionary<int, Bombeiro> equipa;      //Dicionario de bombeiros
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EquipaBombeiros()
        {
            this.nome = "Bombeiros de Braga";
            equipa = new Dictionary<int, Bombeiro>();
        }
        
        /// <summary>
        /// Construtor da class EquipaBombeiro com a indicacao do nome da equipa
        /// </summary>
        /// <param name="nome">Nome da equipa de bombeiros</param>
        public EquipaBombeiros(string nome)
        {
            this.nome = nome;
            equipa = new Dictionary<int, Bombeiro>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Get ou set do nome da equipa de bombeiros
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Funcao que transforma a equipa de bombeiros em texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
           if(equipa.Count == 0)
           {
               return "A equipa nao tem pessoas";
           }
           string infoEquipa= string.Join("\n", equipa.Select(bombeiro => bombeiro.ToString()));
           return infoEquipa;
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Funcao que adiciona bombeiro no dicionario da equipa de bombeiros
        /// </summary>
        /// <param name="bombeiro">Bombeiro que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool Adiciona(Bombeiro bombeiro)
        {
            if(bombeiro == null || Existe(bombeiro.Id))
            {
                return false;
            }
            equipa.Add(bombeiro.Id, bombeiro);
            return true;
        }

        /// <summary>
        /// Funcao que verifica se existe um determinado bombeiro na equipa de bombeiros
        /// </summary>
        /// <param name="id">ID do bombeiro que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool Existe(int id)
        {
            return equipa.ContainsKey(id);
        }
        

        /// <summary>
        /// Funcao que remove um determinado bombeiro da equipa de bombeiros
        /// </summary>
        /// <param name="id">ID do bombeiro que se pretende remover da equipa</param>
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
        /// Funcao que devolve as informações de um bombeiro da equipa de bombeiros
        /// </summary>
        /// <param name="idBombeiro">Id do bombeiro</param>
        /// <returns>Informacoes do bombeiro</returns>
        public BombeiroBO GetBombeiro(int idBombeiro)
        {
            equipa.TryGetValue(idBombeiro, out Bombeiro bombeiro);
            BombeiroBO bombeiroBO = new BombeiroBO(bombeiro.Id, bombeiro.Nome, bombeiro.Patente);
            return bombeiroBO;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~EquipaBombeiros()
        {
        }
        #endregion

        #endregion
    }
}
