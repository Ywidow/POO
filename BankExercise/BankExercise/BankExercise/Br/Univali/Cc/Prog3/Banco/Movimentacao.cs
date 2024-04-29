namespace Br.Univali.Cc.Prog3.Banco;

public class Movimentacao{
    public String Descricao { get; set; } = string.Empty;
    public char Tipo { get; set; }
    public double Valor { get; set; }

    public String GetMovimentacao(){
        return $"\tDescrição: {Descricao}\n\tTipo:{Tipo}\n\tValor:{Valor}";
    }
}       