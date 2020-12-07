using System;

class Datas {
  int dia;
  int mes;
  int ano;
  

  public Datas (int d, int m, int a){
    dia = d;
    mes = m;
    ano = a;    
  }

  public int getDia (){
    return dia;
  }

  public void setDia (int d){
    if (d <= 0)
      throw new Exception("DIA Inválido");
    else
      dia = d;
  }

  public int getMes (){
    return mes;
  }

  public void setMes (int m){
    if (m <= 0)
      throw new Exception("MES Inválido");
    else
      mes = m;
  }

  public int getAno (){
    return ano;
  }

  public void setAno (int a){
    if (a <= 0)
      throw new Exception("ANO Inválido");
    else  
      ano = a;
  }


  public Datas (){
    
  }


}



