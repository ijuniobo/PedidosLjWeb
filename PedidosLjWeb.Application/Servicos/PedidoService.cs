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
    public class PedidoService
    {
        private ClienteRepository _clienteRepository { get; set; }
        private PedidoRepository _pedidoRepository { get; set; }
        private IMapper Mapper { get; set; }


        public PedidoService(ClienteRepository clienteRepository, IMapper mapper, PedidoRepository pedidoRepository)
        {
            _clienteRepository = clienteRepository;
            Mapper = mapper;
            _pedidoRepository = pedidoRepository;
        }

        public PedidoDto Criar(PedidoDto dto)
        {
            Pedido pedido = this.Mapper.Map<Pedido>(dto);
            var cliente = this._clienteRepository.GetById(pedido.IdCliente);
            pedido.CriarPedido(pedido.DataPedido,cliente,pedido.IdLoja,pedido.Itens);
            this._pedidoRepository.Save(pedido);

            return this.Mapper.Map<PedidoDto>(pedido);
        }

        public PedidoDto Atualizar(PedidoDto dto)
        {
            Pedido pedido = this.Mapper.Map<Pedido>(dto);
            var cliente = this._clienteRepository.GetById(pedido.IdCliente);
            pedido.CriarPedido(pedido.DataPedido, cliente, pedido.IdLoja, pedido.Itens);
            this._pedidoRepository.Update(pedido);

            return this.Mapper.Map<PedidoDto>(pedido);
        }

        public PedidoDto Obter(int id)
        {
            var pedido = this._pedidoRepository.GetById(id);
            return this.Mapper.Map<PedidoDto>(pedido);
        }

        public IEnumerable<PedidoDto> ObterTodos()
        {
            var pedido = this._pedidoRepository.GetAll();
            return this.Mapper.Map<IEnumerable<PedidoDto>>(pedido);
        }

        public PedidoDto Deletar(PedidoDto dto)
        {
            Pedido pedido = this.Mapper.Map<Pedido>(dto);
            this._pedidoRepository.Delete(pedido);
            return this.Mapper.Map<PedidoDto>(pedido);
        }

    }
}
