using CursoMVC.Models;
using CursoMVC.Models.Contexto;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
