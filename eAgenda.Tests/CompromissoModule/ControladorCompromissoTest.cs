using eAgenda.Controladores.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Tests.CompromissoModule
{

    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;

        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserir_Compromisso_NoHorarioDeTerminoDoOutro()
        {
            //arrange
            Compromisso compromisso = new Compromisso("Palestra sobre testes", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00),
                new TimeSpan(17, 30, 00), null);

            controladorCompromisso.InserirNovo(compromisso);

            Compromisso  novoCompromisso = new Compromisso("Palestra sobre refatoração", "NDD", "Presencial", DateTime.Today, new TimeSpan(17, 30, 00),
                new TimeSpan(19, 00, 00), null);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var compromissos = controladorCompromisso.SelecionarTodos();
            compromissos.Should().HaveCount(2);
        }

        [TestMethod]
        public void DeveInserir_CompromissoComContato()
        {
            //arrange
            Contato contato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controladorContato.InserirNovo(contato);

            var novoCompromisso = new Compromisso("Palestra", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), contato);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var contatoEncontrado = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            //arrange
            var novoCompromisso = new Compromisso("Palestra", "NDD", "Presencial", DateTime.Today, new TimeSpan (13,30,00), 
                new TimeSpan(17, 30, 00), null);

            //action
            controladorCompromisso.InserirNovo(novoCompromisso);

            //assert
            var contatoEncontrado = controladorCompromisso.SelecionarPorId(novoCompromisso.Id);
            contatoEncontrado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveAtualizar_Compromisso()
        {
            //arrange
            var compromisso = new Compromisso("Palestra", "NDD", "Presencial", new DateTime(2021, 08, 13), new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Debate", "NDD", "google.meet", new DateTime(2021, 09, 13), new TimeSpan(15, 30, 00), 
                new TimeSpan(16, 30, 00), null);

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }

        [TestMethod]
        public void DeveExcluir_Compromisso()
        {
            //arrange            
            var compromisso = new Compromisso("Debate", "NDD", "google.meet", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action            
            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            var compromisso = new Compromisso("Debate", "NDD", "google.meet", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosCompromisso()
        {
            //arrange
            var c1 = new Compromisso("Debate", "NDD", "google.meet", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(c1);

            var c2 = new Compromisso("Aula sobre Testes", "NDD", "Presencial", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(c2);

            var c3 = new Compromisso("Aula sobre Front", "NDD", "google.meet", DateTime.Today, new TimeSpan(13, 30, 00), 
                new TimeSpan(17, 30, 00), null);
            controladorCompromisso.InserirNovo(c3);

            //action
            var compromisso = controladorCompromisso.SelecionarTodos();

            //assert
            compromisso.Should().HaveCount(3);
            compromisso[0].Assunto.Should().Be("Debate");
            compromisso[1].Assunto.Should().Be("Aula sobre Testes");
            compromisso[2].Assunto.Should().Be("Aula sobre Front");
        }

    }
}
