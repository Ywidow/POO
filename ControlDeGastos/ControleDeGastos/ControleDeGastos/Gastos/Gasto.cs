using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

namespace ControleDeGastos.Gastos;

public class Gasto
{
    private DateTime Data { get; set; }
    private String Descricao { get; set; }
    private double Valor { get; set; }
    private TipoGasto TipoDeGasto { get; set; }
    public FormaPagamento FormaDePagamento { get; set; }

    public Gasto(DateTime data, String descricao, double valor, TipoGasto tipo, FormaPagamento forma)
    {
        Data = data;
        Descricao = descricao;
        Valor = valor;
        TipoDeGasto = tipo;
        FormaDePagamento = forma;
    }

    public String ObterDescricao() => Descricao;

    public DateTime GetDate() => Data;

    private void Validate()
    {
        if (Descricao == null!) throw new ArgumentNullException("Descrição não pode ser nula!");

        if (Valor < 0) throw new ArgumentException("Valor não pode ser negativo!");

        if (TipoDeGasto == null) throw new ArgumentNullException("Tipo não pode ser nulo!");

        if (FormaDePagamento == null) throw new ArgumentNullException("Forma de Pagamento não pode ser nula!");

    }
}
