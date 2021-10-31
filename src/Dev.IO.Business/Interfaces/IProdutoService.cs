﻿using Dev.IO.Business.Models;
using System;
using System.Threading.Tasks;

namespace Dev.IO.Business.Interfaces
{
    public interface IProdutoService
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
