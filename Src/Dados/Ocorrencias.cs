/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 2:55:21 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;


namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Ocorrencias que contem um dicionario de ocorrencias
    /// Created by: diogo
    /// Created on: 11/13/2024 2:55:21 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Ocorrencias : IMetodos<Ocorrencia>
    {
        #region Attributes
        Dictionary<int, Ocorrencia> ocorrencias;   //Dicionario de ocorrencias
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Ocorrencias()
        {
            ocorrencias = new Dictionary<int, Ocorrencia>();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma ocorrencias em texto
        /// </summary>
        /// <returns>Texto que se pretende apresentar</returns>
        public override string ToString()
        {
            if (ocorrencias.Count == 0)
            {
                return "Nao tem ocorrencias nesta lista";
            }
            string infoOcorr = string.Join("\n", ocorrencias.Select(ocorr => ocorr.ToString()));
            return infoOcorr;
        }
        #endregion

        #region OtherMethods

        /// <summary>
        /// Funcao que adiciona uma ocorrencia num dicionario de ocorrencias
        /// </summary>
        /// <param name="ocorrencia">Ocorrencia que se pretende adicionar</param>
        /// <returns>Se foi adicionada com sucesso ou nao</returns>
        public bool Adiciona(Ocorrencia ocorrencia) 
        {
            if (ocorrencia == null || Existe(ocorrencia.Id))
            {
                return false;
            }
            ocorrencias.Add(ocorrencia.Id, ocorrencia);
            return true;
        }

        /// <summary>
        /// Funcao que verifica se existe uma determinada ocorrencia num dicionario de ocorrencias
        /// </summary>
        /// <param name="id">ID da ocorrencia que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool Existe(int id)
        {
            return ocorrencias.ContainsKey(id);
        }

        /// <summary>
        /// Funcao que remove uma determinada ocorrencia de um dicionario de ocorrencias
        /// </summary>
        /// <param name="id">ID da correncia que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool Remove(int id)
        {
            if (Existe(id))
            {
                ocorrencias.Remove(id);
                return true;
            }
            return false;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Ocorrencias()
        {
        }
        #endregion

        #endregion
    }
}
