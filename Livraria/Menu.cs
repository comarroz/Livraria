﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Menu
    {
        ControlPessoa controlePessoa;
        ControlLivro controleLivro;
        ControlReserva controleReserva;

        public int opcao;
        public Menu()
        {
            controlePessoa = new ControlPessoa();
            controleLivro = new ControlLivro();
            ControlReserva = new ControlReserva();

            opcao = 0;
        }//fim do menu

        public void EscolherControl()
        {
            Console.WriteLine("\n\nMenu - Geral"               +
                             "\n0. Sair"                       +
                             "\n1. Pessoa"                     +
                             "\n2. Livro"                      +
                             "\n3. Reserva"                    +
                             "\n4. Compra"                     +
                             "\nEscolha uma das opções acima: ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }//fim do escolher

        public void OperacaoMenu()
        {
            do
            {
                EscolherControl();//Chamar o texto do menu
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        controlePessoa.Operacao();
                        break;
                    case 2:
                        controleLivro.Operacao();

                        break;
                    case 3:
                        controleReserva.Operacao();

                        break;
                    case 4:
                        controleCompra.Operacao();

                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida!");
                        break;
                }//fim do switch
            } while (opcao != 0);
        }//fim do operacaoMenu
    }//fim da classe
}//fim do projeto
