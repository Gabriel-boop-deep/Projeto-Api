
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
