
namespace FixaInterfaces.Services
{
    interface IServicoPagamentoOnline
    {
        double TaxaPagamento(double quantia);
        double Mensalidade(double quantia, int meses);
    }
}
