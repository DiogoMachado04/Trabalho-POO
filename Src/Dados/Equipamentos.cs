/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/12/2024 11:04:29 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Equipamentos que contem um dicionario de equipamentos
    /// Created by: diogo
    /// Created on: 11/12/2024 11:04:29 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Equipamentos : IMetodos<Equipamento>
    {
        #region Attributes
        Dictionary<int, Equipamento> equipamentos;    //Dicionario de equipamentos
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Equipamentos()
        {
            equipamentos = new Dictionary<int,Equipamento>();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma os equipamentos em texto
        /// </summary>
        /// <returns>Texto que se pretende apresentar</returns>
        public override string ToString()
        {
            if (equipamentos.Count == 0)
            {
                return "Nao tem equipamentos nesta lista";
            }
            string infoEquip = string.Join("\n", equipamentos.Select(equip => equip.ToString()));
            return infoEquip;
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Funcao que adiciona um equipamento num dicionario de equipamentos
        /// </summary>
        /// <param name="equipamento">Equipamento que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool Adiciona(Equipamento equipamento)
        {
            if(equipamento == null || Existe(equipamento.Id))
            {
                return false;
            }
            equipamentos.Add(equipamento.Id, equipamento);
            return true;
        }

        /// <summary>
        /// Funcao que verifica se existe um determinado equipamento num dicionario de equipamentos
        /// </summary>
        /// <param name="id">ID do equipamento que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool Existe(int id)
        {
            return equipamentos.ContainsKey(id);
        }

        /// <summary>
        /// Funcao que remove um determinado equipamento do dicionario de equipamentos
        /// </summary>
        /// <param name="id">ID do equipamento que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool Remove(int id)
        {
            if (Existe(id))
            {
                equipamentos.Remove(id);
                return true;
            }
            return false;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Equipamentos()
        {
        }
        #endregion

        #endregion
    }
}
