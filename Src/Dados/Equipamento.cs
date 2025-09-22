/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/8/2024 12:37:25 AM</date>
*	<description></description>
**/
using System;
using Enums;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Equipamento com todos os atributos que dizem respeito aos equipamentos
    /// Created by: diogo
    /// Created on: 11/8/2024 12:37:25 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Equipamento
    {
        #region Attributes
        int id;                     //ID do equipamento
        string nome;                //Nome do Equipamento
        EstadoEquip estado;         //Estado do equipamento
        Entidade entidade;          //Entidade a qual o equipamento pertence
        static int idCounter = 0;   //Variavel estatica que serve como contador dos IDs dos equipamentos
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Equipamento()
        {
            idCounter++;
            id = idCounter;
        }
        
        /// <summary>
        /// Construtor da class Equipamento com indicacao de todos os seus atributos
        /// </summary>
        /// <param name="nome">Nome do equipamento</param>
        /// <param name="estado">Estado do equipamento</param>
        /// <param name="entidade">Entidade a qual o equipamento pertence</param>
        public Equipamento (string nome, EstadoEquip estado, Entidade entidade)
        {
            idCounter++;
            id = idCounter;
            this.nome = nome;
            this.estado = estado;
            this.entidade = entidade;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get do ID do equipamento
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Get ou set do nome do equipamento
        /// </summary>
        public string Nome
        {
            get { return nome; }
        }

        /// <summary>
        /// Get ou set do estado do equipamento
        /// </summary>
        public EstadoEquip Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Get ou set da entidade a que pertence o equipamento
        /// </summary>
        public Entidade Entidade
        {
            get { return entidade; }
            set { entidade = value; }
        }
        #endregion


        #region Overrides
        /// <summary>
        /// Funcao que transforma equipamento em texto
        /// </summary>
        /// <returns>Texto que se pretende apresentar</returns>
        public override string ToString()
        {
            return string.Format("ID:{0}\nNome:{1}\nEstado:{2}\nEntidade:{3}\n", id.ToString(), nome, estado.ToString(), entidade.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Equipamento()
        {
        }
        #endregion

        #endregion
    }
}
