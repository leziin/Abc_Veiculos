namespace Abc_Veiculos.compartilhado;


public abstract class EntidadeBase
{
    public int Id { get; set; }


}


public abstract class RepositorioBase


{
    private EntidadeBase [] registros = new EntidadeBase[1000];
    private int contadorRegistros = 0;
    private int contadorIds = 0;


    public void CadastrarRegistros( EntidadeBase NovoRegistro)
    {
        NovoRegistro.Id = ++contadorIds;
        InserirRegistro(NovoRegistro);

    }
    private void InserirRegistro(EntidadeBase Registro)
    {
        for (int i = 0; i < registros.Length; i++)
        {
            if (registros[i] == null)

                registros = registros;
            return;
        }

    }
}
    
