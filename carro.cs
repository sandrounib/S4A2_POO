/// <summary>
/// Classe do tipo Carro
/// </summary>
public class Carro{
    public string cor {get; set;}
    public string modelo {get;set;}
    public int ano {get;set;}

/// <summary>
/// 
/// </summary>
/// <param name="cor_">cor do veículo</param>
/// <param name="modelo_">modelo do veículo</param>
/// <param name="ano_">ano do veículo</param>
public void MostrarDados(string cor_, string modelo_, string ano_ ){
   
    System.Console.WriteLine(cor_ + " - " + modelo_ + "- " + ano_);
}
public void LigarCarro(){
    System.Console.WriteLine("Ligando o Carro");
}
}


