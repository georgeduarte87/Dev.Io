﻿using Dev.IO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.IO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedoresEndereco(Guid id);
        Task<Fornecedor> ObterFonecedorProdutosEndereco(Guid id);
    }
}