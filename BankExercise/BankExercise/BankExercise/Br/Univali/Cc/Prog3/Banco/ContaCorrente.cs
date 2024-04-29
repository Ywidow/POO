using System.ComponentModel;
using System.Text.Json;

namespace Br.Univali.Cc.Prog3.Banco;

public class ContaCorrente{
    private int Numero { get; set; }
    private bool Especial { get; set; } = false;
    private double Limite { get; set; }
    private double Saldo { get; set; }
    public List<Movimentacao> Movimentacoes { get; set; } = new List<Movimentacao>();

    public ContaCorrente(int numero, double saldoInicial){
        Numero = numero;
        Saldo = saldoInicial;
    }

    public ContaCorrente(int numero, double saldoInicial, double limite)
    {
        Numero = numero;
        Saldo = saldoInicial;
        Limite = limite;
        Especial = true;

    }

    private void CriarMovimentacao(String descricao, char tipo, double valor){
        if(descricao == null) throw new ArgumentNullException("Descricao não foi fornecida");
        if(valor < 0) throw new ArgumentException("Valor não pode ser negativo");

        Movimentacoes.Add(
            new Movimentacao{
                Descricao = descricao,
                Tipo = tipo, 
                Valor = valor
            }
        );
    }

    protected bool Depositar(double valor){
        if(valor < 0) return false;

        Saldo += valor;

        CriarMovimentacao("Valor depositado", 'A', valor);

        return true;
    }

    protected String EmitirExtrato(){
        if(Especial) return $"Numero: {Numero}\nLimite: {Limite}\nSaldo: {Saldo}\nMovimentações: {TransformMovimentationInString()}";

        return $"Numero: {Numero}\nSaldo: {Saldo}\nMovimentações: {TransformMovimentationInString()}";
    }

    private String TransformMovimentationInString(){
        string movimentations = "\n";

        if(!Movimentacoes.Any()) return "Nenhuma Movimentação Realizada";

        foreach(var movimentation in Movimentacoes){
            movimentations += $"{movimentation.GetMovimentacao()}\n\n";
        }

        return movimentations;
    }

    protected bool Sacar(double valor){
        if(valor > Saldo) return false;
        if(valor < 0) return false;

        if(Especial){
            if(valor > Limite) return false;
            Limite -= valor;
            Saldo -= valor;
            
            CriarMovimentacao("Valor sacado", 'B', valor);
            CriarMovimentacao("Limite reduzido", 'C', valor);

            return true;
        }

        Saldo -= valor;

        CriarMovimentacao("Valor sacado", 'B', valor);

        return true;
    }

    public int GetNumeroConta() => Numero;

    public double GetSaldo() => Saldo;

    public bool DepositarValor(double valor) => Depositar(valor);

    public bool SacarValor(double valor) => Sacar(valor);

    public String GetExtrato() => EmitirExtrato();
}