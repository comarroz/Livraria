using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class ControlLivro
    {
        Livro model;//Conectar com a classe pessoa

        private int opcao;

        public ControlLivro() 
        { 
            model = new Livro();
            Modificaropcao = 0
    
        }//Fim do construtor

        public int ModificarOpcao
        {
             get { return opcao; }
             set { opcao = value; }

        }//Fim do Modificar Opcção

        public void Menu()
        {
            Console.WriteLine("Menu - livro"                         +
                               
                               "\n1. Cadastar Livro:"                +
                               "\n2. Consultar Livro:"               +
                               "\n3. Atualizar quantidade"           +
                               "\n4. Atualizar Preço"                +
                               "\n5. Arualizar Excluir");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do menu

        public void Operacao()
        {
            Menu(); //Mostra Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o codigo : ");
                    int codigo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Inform o titulo: ");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Informe o autor: ");
                    string autor = Console.ReadLine();

                    Console.WriteLine("Informe a editora: ");
                    string editora = Console.ReadLine();

                    Console.WriteLine("Informe o genero do livro: ");
                    string genero = Convert.ToDateTime(Console.ReadLine());

                    Console.WriteLine("Informe o ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.WriteLine("Informe a Quantidade de paginas: ");
                    string qtdPag = Console.ReadLine();



                    //Chamar o método cadastrar
                    model.Cadastrar(codigo, titulo, autor, editora, genero, isbn, , qtdPag);
                    break;




            }






        }




    }
}
