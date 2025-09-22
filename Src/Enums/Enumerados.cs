/*
*	<copyright file="Enums.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/13/2024 12:27:37 PM</date>
*	<description></description>
**/
using System;


namespace Enums
{
    /// <summary>
    /// Enum com os estados dos equipamentos
    /// </summary>
    public enum EstadoEquip
    {
        DISPONIVEL = 1,
        INDISPONIVEL = 2,
        MANUTENCAO = 3
    };

    /// <summary>
    /// Enum com os estados das ocorrencias
    /// </summary>
    public enum EstadoOcorr
    {
        PENDENTE = 4,
        CONCLUIDA = 5
    };

    /// <summary>
    /// Enum com as especialidades dos membros do INEM
    /// </summary>
    public enum EspecialidadeINEM
    {
        MEDICO = 6,
        ENFERMEIRO = 7,
    };

    /// <summary>
    /// Enum com as patentes do bombeiro
    /// </summary>
    public enum PatenteBombeiro
    {
        BOMBEIRO = 9,
        OFICIAL = 10
    };

    /// <summary>
    /// Enum com as entidades que existem na instituicao
    /// </summary>
    public enum Entidade
    {
        INEM = 11,
        BOMBEIROS = 12
    };

    /// <summary>
    /// Enum com os erros que podem ocorrer
    /// </summary>
    public enum Erro
    {
        EMAIL_INVALIDO = 13,
        CONTACTO_INVALIDO = 14
    };
}
