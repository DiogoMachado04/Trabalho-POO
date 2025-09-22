/*
*	<copyright file="TrabalhoPOO.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/12/2024 11:08:33 AM</date>
*	<description></description>
**/
using Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Exceptions;
using BusinessObjects;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Purpose: Class Instituicao com as listas de tudo o que faz parte da instituicao
    /// Created by: diogo
    /// Created on: 11/12/2024 11:08:33 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Instituicao
    {
        #region Attributes
        string nome;                        //Nome da instituicao
        EquipaBombeiros equipaBombeiros;    //Lista da equipa de bombeiros
        EquipaINEM equipaINEM;              //Lista da equipa de INEM
        Equipamentos equipamentos;          //Lista de equipamentos
        Ocorrencias ocorrencias;            //Lista de ocorrencias
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Instituicao()
        {
            nome = "Protecao Civil de Braga";
            equipaBombeiros = new EquipaBombeiros();
            equipaINEM= new EquipaINEM();
            equipamentos= new Equipamentos();
            ocorrencias= new Ocorrencias();
        }

        /// <summary>
        /// Construtor da class Instituicao com indicacao de todos os seus atributos
        /// </summary>
        /// <param name="equipaBombeiros">Lista da equipa de bombeiros da instituicao</param>
        /// <param name="equipaINEM">Lista da equipa de membros do INEM</param>
        /// <param name="equipamentos">Lista dos equipamentos da instituicao</param>
        /// <param name="ocorrencias">Lista das ocorrencias da instituicao</param>
        /// <param name="nome">Nome da instituicao</param>
        public Instituicao(EquipaBombeiros equipaBombeiros, EquipaINEM equipaINEM, Equipamentos equipamentos, Ocorrencias ocorrencias, string nome)
        {
            nome = "Protecao Civil de Braga";
            this.equipaBombeiros = equipaBombeiros;
            this.equipaINEM = equipaINEM;
            this.equipamentos = equipamentos;
            this.ocorrencias = ocorrencias;
            this.nome = nome;
        }



        #endregion

        #region Properties

        /// <summary>
        /// Get ou set da equipa de bombeiros da instituicao
        /// </summary>
        public EquipaBombeiros EquipaBombeiros
        {
            get { return equipaBombeiros; }
            set { equipaBombeiros = value; }
        }

        /// <summary>
        /// Get ou set da equipa de INEM da instituicao
        /// </summary>
        public EquipaINEM EquipaINEM
        {
            get { return equipaINEM; }
            set { equipaINEM = value; }
        }

        /// <summary>
        /// Get ou set da lista de equipamentos da instituicao
        /// </summary>
        public Equipamentos Equipamentos
        {
            get { return equipamentos; }
            set { equipamentos = value; }
        } 

        /// <summary>
        /// Get ou set da lista de ocorrencias da instituicao
        /// </summary>
        public Ocorrencias Ocorrencias
        {
            get { return ocorrencias; }
            set { ocorrencias = value; }
        }

        /// <summary>
        /// Get ou set do nome da instituicao
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// Funcao que adiciona um membro do INEM na lista da equipa de INEM da instituicao
        /// </summary>
        /// <param name="membro">Membro que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool CriaMembroINEMInstCompleto (string nomeMembro, string contacto, string email, EspecialidadeINEM especialidade)
        {
            try
            {
                MembroINEM membro = new MembroINEM(nomeMembro, contacto, email, especialidade);
                return equipaINEM.Adiciona(membro);
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool CriaMembroINEMInstSimples(string nomeMembro, EspecialidadeINEM especialidade)
        {
            MembroINEM membro = new MembroINEM(nomeMembro, especialidade);
            return equipaINEM.Adiciona(membro);
        }

        /// <summary>
        /// Funcao que verifica se um determinado membro do INEM existe na lista da equipa de INEM instituicao
        /// </summary>
        /// <param name="id">ID do membro que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteMembroINEMInst (int id)
        {
            return equipaINEM.Existe(id);
        }

        /// <summary>
        /// Funcao que remove um determinado membro do INEM na lista da equipa de INEM da instituicao
        /// </summary>
        /// <param name="id">ID do membro que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveMembroINEMInst (int id)
        {
            return equipaINEM.Remove(id);
        }

        /// <summary>
        /// Funcao que devolve as informacoes de um membro do INEM da equipa de INEM da instituicao
        /// </summary>
        /// <param name="idMembro">Id do membro</param>
        /// <returns>Informacoes do MembroINEM</returns>
        public MembroINEMBO GetMembroINEMInst(int idMembro)
        {
            return equipaINEM.GetMembro(idMembro);
        }
        /// <summary>
        /// Funcao que adiciona um bombeiro na lista da equipa de bombeiros da instituicao
        /// </summary>
        /// <param name="bombeiro">Bombeiro que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool CriaBombeiroInstCompleto(string nomeBombeiro, string contacto, string email, PatenteBombeiro patente)
        {
            try
            {
                Bombeiro bombeiro = new Bombeiro(nomeBombeiro, contacto, email, patente);
                return equipaBombeiros.Adiciona(bombeiro);
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool CriaBombeiroInstSimples(string nomeBombeiro, PatenteBombeiro patente)
        {
            Bombeiro bombeiro = new Bombeiro(nomeBombeiro, patente);
            return equipaBombeiros.Adiciona(bombeiro);
        }

        /// <summary>
        /// Funcao que verifica se existe ou nao um determinado bombeiro na lista da equipa de bombeiros da instituicao
        /// </summary>
        /// <param name="id">ID do membro que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteBombeiroInst(int id)
        {
            return equipaBombeiros.Existe(id);
        }

        /// <summary>
        /// Funcao que remove um determinado bombeiro na lista da equipa de bombeiros da instituicao
        /// </summary>
        /// <param name="id">ID do bombeiro que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveBombeiroInst(int id)
        {
            return equipaBombeiros.Remove(id);
        }

        /// <summary>
        /// Funcao que devolve as informacoes de um bombeiro da equipa de bombeiros da instituicao
        /// </summary>
        /// <param name="idBombeiro">Id do bombeiro</param>
        /// <returns>Informacoes do bombeiro</returns>
        public BombeiroBO GetBombeiroInst(int idBombeiro)
        {
            return equipaBombeiros.GetBombeiro(idBombeiro);
        }

        /// <summary>
        /// Funcao que adiciona um equipamento na lista de equipamentos da instituicao
        /// </summary>
        /// <param name="equipamento">Equipamento que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool CriaEquipamentoInst(string nomeEquipamento, EstadoEquip estado, Entidade entidade)
        {
            Equipamento equipamento = new Equipamento(nomeEquipamento, estado, entidade);
            return equipamentos.Adiciona(equipamento);
        }

        /// <summary>
        /// Funcao que verifica se existe um determinado equipamento na lista de equipamentos da instituicao
        /// </summary>
        /// <param name="id">ID do equipamento que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteEquipamentoInst(int id)
        {
            return equipamentos.Existe(id);
        }

        /// <summary>
        /// Funcao que remove um determinado equipamento na lista de equipamentos da instituicao
        /// </summary>
        /// <param name="id">ID do equipamento que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveEquipamentoInst(int id)
        {
            return equipamentos.Remove(id);
        }

        /// <summary>
        /// Funcao que adiciona uma ocorrencia na lista de ocorrencias da instituicao
        /// </summary>
        /// <param name="ocorrencia">Ocorrencia que se pretende adicionar</param>
        /// <returns>Se adicionou com sucesso ou nao</returns>
        public bool CriaOcorrenciaInstCompleta(DateTime dataOcorrencia, string localizacao, string descrOcorr, EstadoOcorr estado, Entidade entidade)
        {
            Ocorrencia ocorrencia = new Ocorrencia(dataOcorrencia, localizacao, descrOcorr, estado, entidade);
            return ocorrencias.Adiciona(ocorrencia);
        }

        public bool CriaOcorrenciaInstSimples(DateTime dataOcorrencia, string localizacao, string descrOcorr)
        {
            Ocorrencia ocorrencia = new Ocorrencia(dataOcorrencia, localizacao, descrOcorr);
            return ocorrencias.Adiciona(ocorrencia);
        }

        /// <summary>
        /// Funcao que verifica se existe uma determinada ocorrencia na lista de ocorrencias da instituicao
        /// </summary>
        /// <param name="id">ID da ocorrencia que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteOcorrenciaInst(int id)
        {
            return ocorrencias.Existe(id);
        }

        /// <summary>
        /// Funcao que remove uma determinada ocorrencia na lista de ocorrencias da instituicao
        /// </summary>
        /// <param name="id">ID da ocorrencia que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveOcorrenciaInst(int id)
        {
            return ocorrencias.Remove(id);
        }

        /// <summary>
        /// Funcao que guarda todos os dados que fazem parte da instituicao num ficheiro binario
        /// </summary>
        /// <param name="fileName">Nome do ficheiro onde se pretende guardaros dados</param>
        /// <returns>Se guardou com sucesso ou nao</returns>
        public bool GuardaInstituicao(string fileName){
            try
            {
                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Funcao que le dos dados de uma  instituicao de um ficheiro binario
        /// </summary>
        /// <param name="fileName">Nome do ficheiro binario de onde pretendemos ler os dados da instituicao</param>
        /// <returns>Se leu os dados com sucesso ou nao</returns>
        public bool LerInstituicao(string fileName)
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();
                Instituicao instituicaoLida = (Instituicao)bin.Deserialize(stream);
                stream.Close();
                this.nome = instituicaoLida.nome;
                this.equipaBombeiros = instituicaoLida.equipaBombeiros;
                this.equipaINEM = instituicaoLida.equipaINEM;
                this.equipamentos = instituicaoLida.equipamentos;
                this.ocorrencias = instituicaoLida.ocorrencias;
                return true;
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Instituicao()
        {
        }
        #endregion

        #endregion
    }
}
