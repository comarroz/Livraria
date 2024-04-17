using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
     class ControlReserva
    {
        Livro model;//Conectar com a classe pessoa

        private int opcao;

        public ControlReserva()
        {
            model = new Reserva();
            Modificaropcao = 0;

        }//Fim do construtor

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }

        }//Fim do Modificar Opcção

        public void Menu()
        {
            Console.WriteLine( "Reserva - livro" +

                               "\nDeseja fazer uma reserva?"   +
                               "\nDeseja consultar a reserva?" +);

            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do menu

        public void Operacao()
        {
            Menu(); //Mostra Menu
            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Informe o codigo : ");
                    int reserva = 
                        Convert.ToInt64(Console.ReadLine());
                    break;
               case 2:
                 Console.WriteLine("Inform o titulo: ");
                 string consulta = Console.ReadLine();
                    break;

                //Chamar o método cadastrar
                model.Cadastrar(reserva, consulta);
                break;









            

            }

        }

    }
}
