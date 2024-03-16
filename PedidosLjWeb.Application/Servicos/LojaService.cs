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
    public class LojaService
    {
        private LojaRepository _lojaRepository { get; set; }
        private IMapper Mapper { get; set; }


        public LojaService(LojaRepository lojaRepository, IMapper mapper)
        {
            _lojaRepository = lojaRepository;
            Mapper = mapper;
        }

        public LojaDto Criar(LojaDto dto)
        {
            Loja loja = this.Mapper.Map<Loja>(dto);
            this._lojaRepository.Save(loja);

            return this.Mapper.Map<LojaDto>(loja);
        }

        public LojaDto Atualizar(LojaDto dto)
        {
            Loja loja = this.Mapper.Map<Loja>(dto);
            this._lojaRepository.Update(loja);

            return this.Mapper.Map<LojaDto>(loja);
        }

        public LojaDto Obter(int id)
        {
            var loja = this._lojaRepository.GetById(id);
            return this.Mapper.Map<LojaDto>(loja);
        }

        public IEnumerable<LojaDto> ObterTodos()
        {
            var loja = this._lojaRepository.GetAll();
            return this.Mapper.Map<IEnumerable<LojaDto>>(loja);
        }

        public LojaDto Deletar(LojaDto dto)
        {
            Loja loja = this.Mapper.Map<Loja>(dto);
            this._lojaRepository.Delete(loja);
            return this.Mapper.Map<LojaDto>(loja);
        }

    }
}
