using System;

namespace S4A2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           Carro c1 = new Carro();  
           c1.cor = "Vermelho";
           c1.modelo="Ferrari";
           c1.ano=2017;

          c1.MostrarDados(c1.cor,c1.modelo,c1.ano.ToString()); 

          Carro c2 = new Carro();
          c2.cor="Branco";
          c2.modelo="Fiesta";
          c2.ano = 2015;

          c2.MostrarDados(c2.cor,c2.modelo,c2.ano.ToString());
           */
           System.Console.WriteLine("Digite seu cpf: ");
           string cpf = Console.ReadLine();
           Validacao validaDocumento = new Validacao();

           bool cpfValido= validaDocumento.ValidarCPF(cpf);

           if(cpfValido){
               System.Console.WriteLine("Cpf Válido!");
           }
           else{
               System.Console.WriteLine("Cpf Inválido!");
           }       
   
        }
            
    }
}
