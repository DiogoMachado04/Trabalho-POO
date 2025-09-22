/*
*	<copyright file="Testes.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>diogo</author>
*   <date>11/7/2024 4:54:40 PM</date>
*	<description></description>
**/
using Dados;
using Enums;
using Exceptions;

namespace Testes
{
    /// <summary>
    /// Class que contem os testes
    /// </summary>
    [TestClass]
    public sealed class Testes
    {
        /// <summary>
        /// Teste ao construtor da classe Bombeiro
        /// </summary>
        [TestMethod]
        public void Constructor_ParametrosValidos_Bombeiro()
        {
            ///Arrange
            string nome = "Joao";
            string contacto = "912345678";
            string email = "joni@gmail.com";
            PatenteBombeiro patente = PatenteBombeiro.OFICIAL;
        
            ///Act
            Bombeiro bombeiro = new Bombeiro(nome, contacto, email, patente);


            ///Assert
            Assert.AreEqual(nome, bombeiro.Nome);
            Assert.AreEqual(contacto, bombeiro.Contacto);
            Assert.AreEqual(email, bombeiro.Email);
            Assert.AreEqual(patente, bombeiro.Patente);
            Assert.AreNotEqual(0, bombeiro.Id);
        }

        [TestMethod]
        public void Constructor_ParametrosInvalidos_EsperaExcecaoContactoInvalido()
        {
            ///Arrange
            string nome = "Joao";
            string contacto = "9123456758";
            string email = "joni@gmail.com";
            PatenteBombeiro patente = PatenteBombeiro.OFICIAL;

            ///Act & Assert
            try
            {
                Bombeiro bombeiro = new Bombeiro(nome, contacto, email, patente);
                Assert.Fail("Exception esperada nao foi lancada");
            }
            catch (ValidationException e)
            {
               Assert.AreEqual(Erro.CONTACTO_INVALIDO, e.erro);
            }
        }
    }
}
