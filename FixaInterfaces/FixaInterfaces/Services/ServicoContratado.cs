
using FixaInterfaces.Entities;

namespace FixaInterfaces.Services
{
    class ServicoContratado
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoContratado(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessoContrato(Contrato contrato, int meses)
        {
            double cotaBasica = contrato.TotalValue / meses;

            for (int i = 1;  i <= meses; i++)
            {
                DateTime data = contrato.Date.AddMonths(i);
                double atualizarCota = cotaBasica + _servicoPagamentoOnline.Mensalidade(cotaBasica, i);
            }
        }
    }
}
