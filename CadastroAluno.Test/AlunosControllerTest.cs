using CadastroAluno.Contracts;
using CadastroAluno.Controllers;
using CadastroAluno.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CadastroAluno.Test
{
    public class AlunosControllerTest
    {
        private Mock<IAlunoRepository> _repository;
        private AlunosController _controller;

        public AlunosControllerTest()
        {
            _repository = new Mock<IAlunoRepository>();
            _controller = new AlunosController(_repository.Object);
        }

        [Theory]
        [InlineData("Pedro", "T91")]
        public async void Atualizar_ExecutaAcao_RetornaOkAction(string nome, string turma)
        {
            //Arrange
            //Aluno aluno = new Aluno();
            //    aluno.Nome = "Pedro";
            //    aluno.Turma = "T91";
            Aluno aluno = new Aluno();
            //Act
            var resul = aluno;
            aluno.AtualizarDados(nome,turma);
            //Assert
            Assert.Equal(resul, aluno);

         

        }

        [Theory]
        [InlineData("Pedro", "T91", 4 )]
        public async void VerificaAprovacao_ExecutaAcao_RetornaTrueOrFalse(string nome, string turma, double media)
        {
            //Arrange
     
            Aluno aluno = new Aluno();
            aluno.Media = 6;
            //Act
            var resul = 
            aluno.VerificaAprovacao();
            //Assert
            Assert.Equal(true, resul);
        }
        
        [Theory]
        [InlineData( 5 )]
        public async void AtualizarMedia_ExecutaAcao_RetornaTrueOrFalse(double media)
        {
            //Arrange
     
            Aluno aluno = new Aluno();
            aluno.Media = 6;
            //Act
            var resul = aluno;
            aluno.AtualizaMedia(media);
            //Assert
            Assert.Equal(resul, aluno);
        }

        [Fact]
        public async void Index_ExecutaAcao_RetornaOuNao()
        {
            //Arange
            var result =_controller.Index();
            //Act
            var okResult = Assert.IsType<OkResult>(result);
            //Assert
            Assert.NotNull(result);
        }


    }
}
