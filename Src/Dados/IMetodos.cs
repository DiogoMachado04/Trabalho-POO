/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/12/2024 11:05:33 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Interface que contem as funcoes que serao utilizadas em todas as classes com listas
    /// </summary>
    /// <typeparam name="T">O tipo de objetos que os metodos irao operar</typeparam>
    internal interface IMetodos<T>
    {
        #region Methods
        /// <summary>
        /// Cabecalho da funcao que adiciona um objeto numa lista
        /// </summary>
        /// <param name="item">Objeto que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        bool Adiciona(T item);
        
        /// <summary>
        /// Cabecalho da funcao que remove um determinado objeto de uma lista
        /// </summary>
        /// <param name="id">ID do objeto que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        bool Remove(int id);

        /// <summary>
        /// Cabecalho da funcao que verifica se um determinado objeto existe na lista
        /// </summary>
        /// <param name="id">ID do obejto que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        bool Existe(int id);
        #endregion
    }
}
