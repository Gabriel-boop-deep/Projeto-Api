 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 using projeto_api;


 class Program {
   static void Main (string[] args) {
   Livro livro1= new Livro("ExemploA","Ficcao",1998,0);
   Livro livro2= new Livro("ExemploB","Romance",2018,0);
   Livro livro3= new Livro("ExemploC","Ficcao",2018,0);
   Livro livro4= new Livro("ExemploD","Academico",2017,0);
   Livro livro5= new Livro("ExemploE","Ficcao",1998,0);
    
    
    Console.WriteLine(livro1);
    Console.WriteLine(livro2);
    Console.WriteLine(livro3);
    Console.WriteLine(livro4);
    Console.WriteLine(livro5);
  }
}

2 aba
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_api
{
  public class Livro 
  {
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }
    public int Edicao { get; set; }
    
    
  }
  public Livro(string Titulo,string Genero,int Ano,int anosDeUso)
  {
    this.Titulo=Titulo;
    this.Genero=Genero;
    this.Ano=Ano;
    this.anosDeUso=0;
  }
  public override string ToString()
  {
    return "O titulo é: "+ this.Titulo +"\n"
    + "Genero: "+this.Genero+"\n"
    + "Ano: "+this.Ano+"\n"
    +"Anos de uso: "+this.anosDeUso;
  }

  
} 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_api
{
  public class Livro 
  {
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }
    public int Edicao { get; set; }
    
    
  }
  public Livro(string Titulo,string Genero,int Ano,int anosDeUso)
  {
    this.Titulo=Titulo;
    this.Genero=Genero;
    this.Ano=Ano;
    this.anosDeUso=0;
  }
  public override string ToString()
  {
    return "O titulo é: "+ this.Titulo +"\n"
    + "Genero: "+this.Genero+"\n"
    + "Ano: "+this.Ano+"\n"
    +"Anos de uso: "+this.anosDeUso;
  }

  
}
 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;

 namespace projeto_api
 {
  public class Livro 
  {
   public string Titulo { get; set; }
   public string Genero { get; set; }
    public int Ano { get; set; }
    public int Edicao { get; set; }
    
    
  }
  public Livro(string Titulo,string Genero,int Ano,int anosDeUso)
  {
    this.Titulo=Titulo;
    this.Genero=Genero;
    this.Ano=Ano;
    this.anosDeUso=0;
  }
  public override string ToString()
  {
    return "O titulo é: "+ this.Titulo +"\n"
    + "Genero: "+this.Genero+"\n"
    + "Ano: "+this.Ano+"\n"
    +"Anos de uso: "+this.anosDeUso;
 }

  
} 
