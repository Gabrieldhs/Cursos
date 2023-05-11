using System;

                                        // TRABALHANDO COM ENUM

class Aula08
{
    enum Meses {Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro};
    static void Main()
    {
        //Meses mes = Meses.Fevereiro;

        //Console.WriteLine(mes);
     //=========================================
        // Outro exemplo.

        //Meses mes = (Meses)9;

        //Console.WriteLine("O mês é: " + mes);  

    //============================================      
        // Selecionando o indice do mês Maio

        int mes = (int)Meses.Maio;
        Console.WriteLine(mes);
     }




}