using AutoMapper;
using PedidosLjWeb.Application.Dto;
using PedidosLjWeb.Domain.Pedidos;
using PedidosLjWeb.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosLjWeb.Application.Servicos
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository { get; set; }
        private IMapper Mapper { get; set; }


        public ProdutoService(ProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            Mapper = mapper;
        }

        public ProdutoDto Criar(ProdutoDto dto)
        {
            Produto produto = this.Mapper.Map<Produto>(dto);
            this._produtoRepository.Save(produto);

            return this.Mapper.Map<ProdutoDto>(produto);
        }

        public ProdutoDto Obter(int id)
        {
            var produto = this._produtoRepository.GetById(id);
            return this.Mapper.Map<ProdutoDto>(produto);
        }

        public IEnumerable<ProdutoDto> ObterTodos()
        {
            var produto = this._produtoRepository.GetAll();
            return this.Mapper.Map<IEnumerable<ProdutoDto>>(produto);
        }

        public ProdutoDto Deletar(ProdutoDto dto)
        {
            Produto produto = this.Mapper.Map<Produto>(dto);
            this._produtoRepository.Delete(produto);
            return this.Mapper.Map<ProdutoDto>(produto);
        }

    }
}
