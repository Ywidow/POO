namespace ControleDeGastos.Gastos;

public class Aplicacao
{
    private List<Gasto> Gastos { get; set; } = new List<Gasto>();
    private List<FormaPagamento> FormasDePagamento { get; set; } = new List<FormaPagamento>();
    private List<TipoGasto> TiposDeGasto { get; set; } = new List<TipoGasto>();

    public void AdicionarFormaPagamento(FormaPagamento forma)
    {
        if (forma == null) throw new ArgumentNullException("Forma de Pagamento não pode ser nula");
        if (FormasDePagamento.Exists(f => f.GetDescricao() == forma.GetDescricao())) throw new ArgumentException("Forma de Pagamento ja existe");

        FormasDePagamento.Add(forma);
    }

    public void AdicionarTipoGasto(TipoGasto tipo)
    {
        if (tipo == null) throw new ArgumentNullException("Tipo de Pagamento não pode ser nulo");
        if (TiposDeGasto.Exists(t => t.GetDescricao() == tipo.GetDescricao())) throw new ArgumentException("Tipo de Pagamento ja existe");

        TiposDeGasto.Add(tipo);
    }

    public void ListarGastos(int mes, int ano)
    {
        if (mes < 1 || mes > 12) throw new ArgumentException("Mes inválido");
        if (ano < 0) throw new ArgumentException("Ano inválido");

        if (!Gastos.Any())
        {
            Console.WriteLine("Nenhum Gasto foin realizado nesse período de tempo");
            return;
        }

        var timePeriodExpenses = Gastos.Where(g => g.GetDate().Year == ano && g.GetDate().Month == mes);

        Console.WriteLine("~~~~~~ Gastos ~~~~~~");
        foreach(var expense in timePeriodExpenses)
        {
            Console.WriteLine(expense.ObterDescricao());
            Console.WriteLine("\n\n");
        }
    }

    public void NovoGasto(String descricao, DateTime date, double valor, TipoGasto tipo, FormaPagamento forma)
    {
        if (!TiposDeGasto.Exists(t => t.GetDescricao() == tipo.GetDescricao())) throw new ArgumentException("Tipo de Gasto não existe");
        if (!FormasDePagamento.Exists(f => f.GetDescricao() == forma.GetDescricao())) throw new ArgumentException("Forma de Pagamento não existe");

        Gastos.Add(new Gasto(date, descricao, valor, tipo, forma));
    }
}
