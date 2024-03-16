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
    public class ClienteService
    {
        private ClienteRepository _clienteRepository { get; set; }
        private IMapper Mapper { get; set; }


        public ClienteService(ClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            Mapper = mapper;
        }

        public ClienteDto Criar(ClienteDto dto)
        {
            Cliente cliente = this.Mapper.Map<Cliente>(dto);
            cliente.CriarCliente(cliente.Nome, cliente.Endereco,cliente.Cidade,cliente.Bairro, cliente.Estado, cliente.Complemento, cliente.Cpf, cliente.Cnpj,cliente.TipoPessoa,cliente.Login,cliente.Senha);
            this._clienteRepository.Save(cliente);

            return this.Mapper.Map<ClienteDto>(cliente);
        }

        public ClienteDto Atualizar(ClienteDto dto)
        {
            Cliente cliente = this.Mapper.Map<Cliente>(dto);
            cliente.CriarCliente(cliente.Nome, cliente.Endereco, cliente.Cidade, cliente.Bairro, cliente.Estado, cliente.Complemento, cliente.Cpf, cliente.Cnpj, cliente.TipoPessoa, cliente.Login, cliente.Senha);
            this._clienteRepository.Update(cliente);

            return this.Mapper.Map<ClienteDto>(cliente);
        }

        public ClienteDto Obter(int id)
        {
            var cliente = this._clienteRepository.GetById(id);
            return this.Mapper.Map<ClienteDto>(cliente);
        }

        public IEnumerable<ClienteDto> ObterTodos()
        {
            var cliente = this._clienteRepository.GetAll();
            return this.Mapper.Map<IEnumerable<ClienteDto>>(cliente);
        }

        public ClienteDto Deletar(ClienteDto dto)
        {
            Cliente cliente = this.Mapper.Map<Cliente>(dto);
            this._clienteRepository.Delete(cliente);
            return this.Mapper.Map<ClienteDto>(cliente);
        }

    }
}
