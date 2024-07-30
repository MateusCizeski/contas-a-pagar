using api_contas_pagar.Application.Fatura.DTOs;
using api_contas_pagar.Models;

namespace api_contas_pagar
{
    public class AplicFatura : IAplicFatura
    {
        private readonly IServFatura _servFatura;
        private readonly IMapperFatura _mapperFatura;

        public AplicFatura(IServFatura servFatura, IMapperFatura mapperFatura)
        {
            _servFatura = servFatura;
            _mapperFatura = mapperFatura;
        }

        public Fatura Alterar(AlterarFaturaDTO dto)
        {
            var fatura = _servFatura.ListarFaturaPorId(dto.Id);
            _mapperFatura.MapearEdicao(dto, fatura);

            return fatura;
        }

        public List<Fatura> ListarFaturas()
        {
            var fatura = _servFatura.ListarFaturas();

            return fatura;
        }

        public Fatura ListarFaturaPorId(int id)
        {
            var fatura = _servFatura.ListarFaturaPorId(id);

            return fatura;
        }

        public void Remover(int id)
        {
            var fatura = _servFatura.ListarFaturaPorId(id);
            _servFatura.Remover(fatura);
        }

        public int Salvar(SalvarFaturaDTO dto)
        {
            var mapperFatura = _mapperFatura.MapearInsercao(dto);
            var fatura = _servFatura.SalvarFatura(mapperFatura);

            return fatura.Id;
        }
    }
}
