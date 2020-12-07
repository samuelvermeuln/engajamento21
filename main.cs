using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    Datas calendario = new Datas (0,0,0);
    string DataSystem = DateTime.Now.ToString("dd/MM/yyyy");
    DateTime data = DateTime.Now;
    int i = 0;
    int x = 0;
    
    Console.WriteLine(@"
    🏁  🏁  🏁 PARA INICIAR DIGITE UMA DATA 🏁  🏁  🏁
    
    ");
    Console.WriteLine(@"Digite o DIA Desejado");
    int dia = int.Parse(Console.ReadLine());
    Console.WriteLine(@"Digite o MÊS Desejado");
    int mes = int.Parse(Console.ReadLine());
    Console.WriteLine(@"Digite o ANO Desejado");
    int ano = int.Parse(Console.ReadLine());

    calendario.setDia(dia);
    calendario.setMes(mes);
    calendario.setAno(ano);
    //Console.WriteLine(@"DATA ->> {0}/{1}/{2} <<-",//calendario.getDia(), calendario.getMes(), //calendario.getAno());
    

  List<string> ListaDatas = new List<string> ();
  ListaDatas.Add(DataSystem);
    
    

    Console.WriteLine($@"
            📅    USE AS SETAS    📅
    🔜  Para Esquerda avançar um dia
    🔙  Para Direira voltar um dia
    🔝  Mostrar todas as Datas
    ⚠️  Tecla ESC para finalizar   
     ");     

    while (true)
    {
      var controleSetas = Console.ReadKey(false).Key;      
      switch(controleSetas)
      {
          case ConsoleKey.UpArrow:
              if (ListaDatas.Count > 0)
              {

              foreach (string Todas_Datas in ListaDatas)
              {
                Console.WriteLine($@" 
              DATA DO SiSTEMA ->>  {Todas_Datas}");
              }
                }

              else
              {
              Console.WriteLine($@" LISTA VAZIA ");
              }

              Console.WriteLine(@"
              DATA DIGITADA PELO USUARIO 👉  {0}/{1}/{2} 👈
              "
              ,calendario.getDia()
              ,calendario.getMes()
              ,calendario.getAno());
              break;

          case ConsoleKey.RightArrow:
              DateTime today = DateTime.Now;
              DateTime answer = today.AddDays(i++);
                      
              Console.WriteLine("DIA DA SEMANA ✍️   {0:dddd}", answer);
              DateTime data2 = data.AddDays(i++);
              Console.WriteLine ();
              Console.WriteLine(" MAIS UM DIA ");
              Console.WriteLine ();
              DateTime data3 = data.AddDays(x++);
              Console.WriteLine(data);
              Console.WriteLine(data3);
              break;

          case ConsoleKey.LeftArrow:
              DateTime today1 = DateTime.Now;
              DateTime answer1 = today1.AddDays(i--);
              
              Console.WriteLine("DIA DA SEMANA ✍️   {0:dddd}", answer1);
              Console.WriteLine ();
              Console.WriteLine(" MENOS UM DIA ");
              Console.WriteLine ();
              DateTime data4 = data.AddDays(x--);
              Console.WriteLine(data);
              Console.WriteLine(data4);
              break;                       

          case ConsoleKey.Escape:
              Console.WriteLine($@"
              FFIM ...
              Muito Obrigado!!
              ");
              return;
      }
    }


  }
}