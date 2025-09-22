/*
*	<copyright file="GereInstituicao.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>12/20/2024 3:13:26 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Validacoes;
using Enums;
using Exceptions;
using BusinessObjects;

namespace Regras
{
    /// <summary>
    /// Class que tem como objetivo gerir a instituicao
    /// </summary>
    public class GereInstituicao
    {
        private Instituicao instituicao;

        /// <summary>
        /// Construtor da class GereInstituicao que inicializa a instituicao
        /// </summary>
        public GereInstituicao()
        {
            instituicao = new Instituicao();
        }

        /// <summary>
        /// Construtor da class GereInstituicao que inicializa a instituicao com os dados do ficheiro
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        public GereInstituicao(string fileName)
        {
                instituicao = new Instituicao();
                instituicao.LerInstituicao(fileName);
        }

        /// <summary>
        /// Funcao que cria um membro do INEM completo
        /// </summary>
        /// <param name="nomeMembro">Nome do membro</param>
        /// <param name="contacto">Contacto do membro</param>
        /// <param name="email">Email do membro</param>
        /// <param name="especialidade">Especialidade do membro</param>
        /// <returns>Se criou o membro completo com sucesso ou nao</returns>
        public bool CriaMembroINEMCompleto(string nomeMembro, string contacto, string email, EspecialidadeINEM especialidade)
        {
            try
            {
                if (Validar.VerificaEmail(email) && Validar.VerificaContacto(contacto))
                {
                    return instituicao.CriaMembroINEMInstCompleto(nomeMembro, contacto, email, especialidade);
                }
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        /// <summary>
        /// Funcao que cria um membro do INEM simples
        /// </summary>
        /// <param name="nomeMembro">Nome do membro</param>
        /// <param name="especialidade">Especialidade do membro</param>
        /// <returns>Se criou um membro simples com sucesso ou nao</returns>
        public bool CriaMembroINEMSimples(string nomeMembro, EspecialidadeINEM especialidade)
        {
            return instituicao.CriaMembroINEMInstSimples(nomeMembro, especialidade);
        }

        /// <summary>
        /// Funcao que verifica se um membro do INEM existe na instituicao
        /// </summary>
        /// <param name="idMembro">Id do membro que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteMembroINEM(int idMembro)
        {
            return instituicao.ExisteMembroINEMInst(idMembro);
        }

        /// <summary>
        /// Funcao que remove um membro do INEM da instituicao
        /// </summary>
        /// <param name="idMembro">Id do membro que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveMembroINEM(int idMembro)
        {
            return instituicao.RemoveMembroINEMInst(idMembro);
        }
        /// <summary>
        /// Funcao que devolve as informacoes de um membro do INEM da instituicao
        /// </summary>
        /// <param name="idMembro">Id do membro</param>
        /// <returns>Informacoes do MembroINEM</returns>
        public MembroINEMBO GetMembroINEM(int idMembro)
        {
            return instituicao.GetMembroINEMInst(idMembro);
        }
        /// <summary>
        /// Funcao que cria bombeiro completo
        /// </summary>
        /// <param name="nomeBombeiro">Nome do bombeiro</param>
        /// <param name="contacto">Contacto do bombeiro</param>
        /// <param name="email">Email do bombeiro</param>
        /// <param name="patente">Patente do bombeiro</param>
        /// <returns>Se criou com sucesso ou nao</returns>
        public bool CriaBombeiroCompleto(string nomeBombeiro, string contacto, string email, PatenteBombeiro patente)
        {
            try
            {
                if (Validar.VerificaEmail(email) && Validar.VerificaContacto(contacto))
                {
                    return instituicao.CriaBombeiroInstCompleto(nomeBombeiro, contacto, email, patente);
                }
            }
            catch (ValidationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            return false;
        }

        /// <summary>
        /// Funcao que cria um bombeiro simples
        /// </summary>
        /// <param name="nomeBombeiro">Nome do bombeiro</param>
        /// <param name="patente">Patente do bombeiro</param>
        /// <returns>Se criou com sucesso ou nao</returns>
        public bool CriaBombeiroSimples(string nomeBombeiro, PatenteBombeiro patente)
        {
            return instituicao.CriaBombeiroInstSimples(nomeBombeiro, patente);
        }

        /// <summary>
        /// Funcao que verifica se um bombeiro existe na instituicao
        /// </summary>
        /// <param name="idBombeiro">Id do bombeiro que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteBombeiro(int idBombeiro)
        {
            return instituicao.ExisteBombeiroInst(idBombeiro);
        }

        /// <summary>
        /// Funcao que remove um bombeiro da instituicao
        /// </summary>
        /// <param name="idBombeiro">Id do bombeiro que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveBombeiro(int idBombeiro)
        {
            return instituicao.RemoveBombeiroInst(idBombeiro);
        }

        /// <summary>
        /// Funcao que devolve as informacoes de um bombeiro da instituicao
        /// </summary>
        /// <param name="idBombeiro">Id do bombeiro</param>
        /// <returns>Informacoes do bombeiro</returns>
        public BombeiroBO GetBombeiro(int idBombeiro)
        {
            return instituicao.GetBombeiroInst(idBombeiro);
        }

        /// <summary>
        /// Funcao que cria um equipamento completo
        /// </summary>
        /// <param name="nomeEquipamento">Nome do equipamento</param>
        /// <param name="estado">Estado do equipamento</param>
        /// <param name="entidade">Entidade do equipamento</param>
        /// <returns>Se criou o equipamento completo com sucesso ou nao</returns>
        public bool CriaEquipamento(string nomeEquipamento, EstadoEquip estado, Entidade entidade)
        {
            return instituicao.CriaEquipamentoInst(nomeEquipamento, estado, entidade);
        }

        /// <summary>
        /// Funcao que verifica se um equipamento existe na instituicao
        /// </summary>
        /// <param name="idEquipamento">Id do equipamento que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteEquipamento(int idEquipamento)
        {
            return instituicao.ExisteEquipamentoInst(idEquipamento);
        }

        /// <summary>
        /// Funcao que remove um equipamento da instituicao
        /// </summary>
        /// <param name="idEquipamento">Id do equipamento que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveEquipamento(int idEquipamento)
        {
            return instituicao.RemoveEquipamentoInst(idEquipamento);
        }

        /// <summary>
        /// Funcao que cria uma ocorrencia completa
        /// </summary>
        /// <param name="dataOcorrencia">Data da ocorrencia</param>
        /// <param name="localizacao">Localizacao da ocorrencia</param>
        /// <param name="descrOcorr">Descricao da ocorrencia</param>
        /// <param name="estado">Estado da ocorrencia</param>
        /// <param name="entidade">Entidade necessaria para a ocorrencia</param>
        /// <returns>Se criou a ocorrencia completa com sucesso ou nao</returns>
        public bool CriaOcorrenciaCompleta(DateTime dataOcorrencia, string localizacao, string descrOcorr, EstadoOcorr estado, Entidade entidade)
        {
            return instituicao.CriaOcorrenciaInstCompleta(dataOcorrencia, localizacao, descrOcorr, estado, entidade);
        }

        /// <summary>
        /// Funcao que cria uma ocorrencia simples
        /// </summary>
        /// <param name="dataOcorrencia">Data da ocorrencia</param>
        /// <param name="localizacao">Localizacao da ocorrencia</param>
        /// <param name="descrOcorr">Descricao da ocorrencia</param>
        /// <returns>Se criou a ocorrencia simples com sucesso ou nao</returns>
        public bool CriaOcorrenciaSimples(DateTime dataOcorrencia, string localizacao, string descrOcorr)
        {
            return instituicao.CriaOcorrenciaInstSimples(dataOcorrencia, localizacao, descrOcorr);
        }

        /// <summary>
        /// Funcao que verifica se uma ocorrencia existe na instituicao
        /// </summary>
        /// <param name="idOcorrencia">Id da ocorrencia que se pretende verificar se existe</param>
        /// <returns>Se existe ou nao</returns>
        public bool ExisteOcorrencia(int idOcorrencia)
        {
            return instituicao.ExisteOcorrenciaInst(idOcorrencia);
        }

        /// <summary>
        /// Funcao que remove uma ocorrencia da instituicao
        /// </summary>
        /// <param name="idOcorrencia">Id da ocorrencia que se pretende remover</param>
        /// <returns>Se removeu com sucesso ou nao</returns>
        public bool RemoveOcorrencia(int idOcorrencia)
        {
            return instituicao.RemoveOcorrenciaInst(idOcorrencia);
        }

        /// <summary>
        /// Funcao que grava as informacoes da instituicao num ficheiro
        /// </summary>
        /// <param name="fileName">Nome do ficheiro</param>
        /// <returns>Se gravou com sucesso ou nao</returns>
        public bool GravaInstituicao(string fileName)
        {
            return instituicao.GuardaInstituicao(fileName);
        }
    }
}
