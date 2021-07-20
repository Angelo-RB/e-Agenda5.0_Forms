using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class CompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;

        protected Compromisso compromissoTest = new Compromisso("Palestra sobre testes", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00),
                new TimeSpan(17, 30, 00), null);

        public CompromissoTest() 
        {
            LimparTabelas();
            controladorCompromisso = new ControladorCompromisso();
        }

        [TestCleanup()]
        public void LimparTabelas()
        {
            Db.Update("DELETE FROM TBCOMPROMISSO");
        }        

        [TestMethod]
        public void DeveInserir()
        {
            Assert.AreEqual("ESTA_VALIDO", controladorCompromisso.InserirNovo(compromissoTest));
        }

        [TestMethod]
        public void DeveEditar()
        {
            Compromisso compromisso = new Compromisso("Palestra sobre testes", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00),
                new TimeSpan(17, 30, 00), null);

            Assert.AreEqual("ESTA_VALIDO", controladorCompromisso.Editar(compromissoTest.Id, compromisso));
        }

        [TestMethod]

        public void DeveValidar()
        {
            Compromisso compromisso = new Compromisso("Palestra sobre banco de dados", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00),
                new TimeSpan(17, 30, 00), null);

            Assert.AreEqual("ESTA_VALIDO",compromisso.Validar());
        }

        public void DeveSerInvalido()
        {
            Compromisso compromisso = new Compromisso("", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00),
                new TimeSpan(17, 30, 00), null);

            Assert.AreEqual("O campo Assunto é obrigatório", compromisso.Validar());
        }

    }
}
