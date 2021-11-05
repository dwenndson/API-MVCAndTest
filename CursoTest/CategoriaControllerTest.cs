using CursoAPI.Controllers;
using CursoMVC.Models;
using CursoMVC.Models.Contexto;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTest
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Contexto> _mockContexto;
        private readonly Categoria _categoria;
        
        public CategoriaControllerTest ()
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContexto = new Mock<Contexto>();
            _categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };

            _mockContexto.Setup(m => m.Categorias).Returns(_mockSet.Object);
            _mockContexto.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContexto.Object);

            await service.GetCategoria(1);
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
