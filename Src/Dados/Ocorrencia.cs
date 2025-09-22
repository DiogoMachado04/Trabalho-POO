/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/8/2024 12:54:00 AM</date>
*	<description></description>
**/
using System;
using Enums;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Ocorrencia com todos os atributos que dizem respeito as ocorrencias
    /// Created by: diogo
    /// Created on: 11/8/2024 12:54:00 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Ocorrencia
    {
        #region Attributes
        int id;                     //ID da ocorrencia
        DateTime dataOcorrencia;    //Data da ocorrencia
        string localizacao;         //Localizacao da ocorrencia
        string descrOcorr;          //Descricao da ocorrencia
        EstadoOcorr estado;         //Estado da ocorrencia (Se está pendente ou concluida)
        Entidade entidade;          //Entidade que foi necessaria para a solucao da ocorrencia
        static int idCounter = 0;   //Varivel estatica que serve como contador dos IDs das ocorrencias
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Ocorrencia()
        {
            idCounter++;
        }

        /// <summary>
        /// Construtor da class Ocorrencia que indica todos os seus atributos
        /// </summary>
        /// <param name="dataOcorrencia">Data da ocorrencia</param>
        /// <param name="localizacao">Localizacao da ocorrencia</param>
        /// <param name="descrOcorr">Descricao da ocorrencia</param>
        /// <param name="estado">Estado da ocorrencia</param>
        /// <param name="entidade">Entidade que foi necessaria para a resolucao da ocorrencia</param>
        public Ocorrencia(DateTime dataOcorrencia, string localizacao, string descrOcorr, EstadoOcorr estado, Entidade entidade)
        {
            idCounter++;
            id = idCounter;
            this.dataOcorrencia = dataOcorrencia;
            this.localizacao = localizacao;
            this.descrOcorr = descrOcorr;
            this.estado = estado;
            this.entidade = entidade;
        }

        public Ocorrencia(DateTime dataOcorrencia, string localizacao, string descrOcorr)
        {
            idCounter++;
            id = idCounter;
            this.dataOcorrencia = dataOcorrencia;
            this.localizacao = localizacao;
            this.descrOcorr = descrOcorr;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Get do ID da ocorrencia
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Get ou set da data da ocorrencia
        /// </summary>
        public DateTime DataOcorrencia
        {
            get { return dataOcorrencia; }
            set { dataOcorrencia = value; }
        }


        /// <summary>
        /// Get ou set da localizacao da ocorrencia
        /// </summary>
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /// <summary>
        /// Get ou set da descrecicao da ocorrencia
        /// </summary>
        public string DescrOcorr
        {
            get { return descrOcorr; }
            set { descrOcorr = value; }
        }

        /// <summary>
        /// Get ou set do estado da Ocorrencia
        /// </summary>
        public EstadoOcorr Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        /// <summary>
        /// Get ou set da entidade que foi necessaria para a resolucao da ocorrencia
        /// </summary>
        public Entidade Entidade
        {
            get { return entidade; }
            set { entidade = value; }
        }
        #endregion



        #region Overrides
        /// <summary>
        /// Funcao que transforma ocorrencia em texto
        /// </summary>
        /// <returns>O texto que se pretende apresentar</returns>
        public override string ToString()
        {
            return string.Format("ID:{0}\nData:{1}\nLocalizacao:{2}\nDescricao:{3}\nEstado:{4}\nEntidade:{5}\n"
            , id.ToString(), dataOcorrencia.ToString(),localizacao, descrOcorr, estado.ToString(), entidade.ToString());
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Ocorrencia()
        {
        }
        #endregion

        #endregion
    }
}
