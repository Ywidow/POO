namespace ControleDeGastos.Gastos;

public class FormaPagamento
{
    private String Descricao { get; set; } = string.Empty;

    public String GetDescricao() => Descricao;
    public void SetDescricao(String descricao)
    {
        if (Descricao == null) throw new ArgumentNullException("Descrição não pode ser nula.");
        
        Descricao = descricao;
    }
}
