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
        Mock<IAlunoRepository> _repository;

        public AlunosControllerTest()
        {
            _repository = new Mock<IAlunoRepository>();
        }

        [Fact]
        public async void GetAluno_ExecutaAcao_RetornaOkAction()
        {
            //Arrange
            AlunosController controller = new AlunosController(_repository.Object);



            Aluno aluno1 = new Aluno("Bueno","T91", 5 );


            _repository.Setup(repo => repo.GetAluno(1)).Returns(Task.FromResult(aluno1));

            //Act
            var consulta = await controller.Details(1);

            //Assert
            var cli = Assert.IsType<Aluno>(consulta);
            //var Cliente = Assert.IsType<Cliente>((consulta.Result as OkObjectResult).Value);
            //Assert.Equal(1 , listaClientes);

        }

    }
}
