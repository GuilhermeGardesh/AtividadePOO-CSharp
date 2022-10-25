using MaoNaMassaPOO.ConteudoContext;
using System.Collections.Generic;
using System.Linq;

namespace MaoNaMassaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre OOP","Orientacao-Objetos"));
            artigos.Add(new Artigo("Artigo sobre C#","C-Sharp"));
            artigos.Add(new Artigo("Artigo sobre .Net","Dot-Net"));

            //foreach (var artigo in artigos)
            //{
            //    System.Console.WriteLine();
            //    System.Console.WriteLine(artigo.Id);
            //    System.Console.WriteLine(artigo.Titulo);
            //    System.Console.WriteLine(artigo.Url);
            //}

            var cursos = new List<Curso>();
            var cursoOOP = new Curso("Fundamentos OOP","fundamentos-oop");
            var cursoCsharp = new Curso("Fundamentos C#","fundamentos-c-sharp");
            var cursoDotNet = new Curso("Fundamentos .Net","fundamentos-dot-net");

            cursos.Add(cursoOOP);
            cursos.Add(cursoDotNet);
            cursos.Add(cursoCsharp);

            var carreiras = new List<Carreira>();
            var carreiraDotNet = new Carreira("Especialista .Net","especioalista-dot-net");
            var itensDaCarreira2 = new ItensDaCarreira(2, "Aprenda .Net", "", cursoDotNet);
            var itensDaCarreira = new ItensDaCarreira(1, "Comece por aqui", "", cursoCsharp);
            var itensDaCarreira3 = new ItensDaCarreira(3, "Aprenda OOP", "", cursoOOP);
            carreiraDotNet.Itens.Add(itensDaCarreira2);
            carreiraDotNet.Itens.Add(itensDaCarreira);
            carreiraDotNet.Itens.Add(itensDaCarreira3 );
            carreiras.Add(carreiraDotNet);

            foreach (var carreira in carreiras)
            {
                System.Console.WriteLine(carreira.Titulo);
                foreach (var item in carreira.Itens.OrderBy(x=>x.Ordem))
                {
                    System.Console.WriteLine(item.Ordem +" - "+ item.Titulo);
                    System.Console.WriteLine(item.Curso.Id);
                    System.Console.WriteLine(item.Curso.Titulo);
                    System.Console.WriteLine();
                }
            }
        }
    }
}
