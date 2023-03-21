using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private int año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(string titulo, int año)
     {
        this.titulo = titulo;
        this.año = año;
        //this.pais = pais;
        //this.director = director;
     }
     
        //Propiedades
        public string GetTitulo() 
    { 
        return titulo; 
    }
    
    public void SetTitulo(string titulo2)
    {
        titulo=titulo2;
    }

       public int GetAño()
       {
        return año;
       }

       public void SetAño(int year)
       {
        año = year;
       }

       public string GetPais()
       {
        return pais;
       }

       public void SetPais(string country)
       {
        pais = country;
       }

         public string GetDirector() 
         {
            return director;
         }

        public void SetDirector(string director2)
        {
            director = director2;
        }

        //Métodos
        public void Imprime()
        {
          Console.WriteLine($"{titulo} ({año})");

        }

        public void AgregaActor(Actor actor)
      {
        actores.Add(actor);
      }   

      public void ImprimeActores()
      {
        foreach (Actor actor in actores)
        {
            actor.Imprime();
        }  
      }

    }

    public class Actor
    {
        //Propiedades
        private string name;
        private int year;

        public string Nombre
        {
          get { return name; }
          set { name = value; }
        }

         public int Año
        {
        get { return year; }
        set { year = value; }
       }

        //Constructores
        public Actor (string nombre, int año)
        {
            name = nombre;
            year = año;
        }

        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{name} ({year})", name, year);
        }

    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {

        static void Main(string[] args)
        {
    Pelicula p1 = new Pelicula("lalaland", 2016 );
    p1.AgregaActor(new Actor("Ryan Gosling", 1980));
    p1.AgregaActor(new Actor("Emma Stone", 1988));


    

    p1.ImprimeActores();
        }
    }
}
