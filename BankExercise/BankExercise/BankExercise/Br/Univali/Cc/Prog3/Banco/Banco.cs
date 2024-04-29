namespace Br.Univali.Cc.Prog3.Banco;

public class Banco{
    private string Nome { get; set; } = string.Empty;
    private int Numero { get; set; }
    private List<ContaCorrente> ContasCorrente { get; set; } = new List<ContaCorrente>();

    public void CriarConta(double saldoInicial){
        if(saldoInicial < 0) throw new ArgumentException("Saldo Inválido");

        ContasCorrente.Add(new ContaCorrente(ContasCorrente.Count + 1, saldoInicial));
    }

    public void CriarConta(double saldoInicial, double limite){
        if(saldoInicial < 0) throw new ArgumentException("Saldo inválido");
        if(limite < 0) throw new ArgumentException("Limite inválido");
        
        ContasCorrente.Add(new ContaCorrente(ContasCorrente.Count + 1, saldoInicial, limite));
    }
    
    public void Depositar(int conta, double valor){
        var entity = LocalizarConta(conta);
        
        if(entity == null) throw new ArgumentNullException("Conta Corrente não existe");

        if(!entity.DepositarValor(valor)) throw new ArgumentException("Valor inválido para de depósito");
    }

    public String EmitirExtrato(int conta){
        var entity = LocalizarConta(conta);

        if(entity == null) throw new ArgumentNullException("Conta Corrente não existe");

        return entity.GetExtrato();
    }

    private ContaCorrente LocalizarConta(int conta){
        return ContasCorrente.FirstOrDefault(cc => cc.GetNumeroConta() == conta)!;
    }

    public void Sacar(int conta, double valor){
        var entity = LocalizarConta(conta);
        
        if(entity == null) throw new ArgumentNullException("Conta Corrente não existe");

        if(!entity.SacarValor(valor)) throw new ArgumentException("Valor inválido para saque");
    }

    public void Transferir(int contaOrigem, int contaDestino, double valor){
        var originEntity = LocalizarConta(contaOrigem);

        if(originEntity == null) throw new ArgumentNullException("Conta Origem não existe");

        var destinyEntity = LocalizarConta(contaDestino);

        if(destinyEntity == null) throw new ArgumentNullException("Conta Destino não existe");

        if(!originEntity.SacarValor(valor)) throw new ArgumentNullException("Valor inválido para saque");

        if(!destinyEntity.DepositarValor(valor)) throw new ArgumentNullException("Valor inválido para depósito");
    }
}