using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    class Livro
    {
        private int codigo;
        private string titulo;
        private string autor;
        private string editora;
        private string genero;
        private string isbn;
        private int preco;
        private int situacao;

        public Livro()
        {
            ModificarCodigo = 0;
            ModificarTitulo = "";
            ModificarAutor = "";
            ModificarEditora = "";
            ModificarGenero = "";
            ModificarIsbn = "";
            ModificarPreco = "";
            ModificarSituacao = "Ativo";

        }// Fim do modo Construtor

        //Método Modificadores = Gets e Sets
        public int ModificarCodigo
        {
            get { return codigo; }
            set { this.codigo = value; }

        }//Fim do metodo Mofificar

        public int ModificarTitulo
        {
            get { return codigo; }
            set { this.codigo = value; }

        }//Fim do metodo Modificar

     
        public string ModificarAutor

        {
            get {return codigo; }
            set { this.autor = value; }

        }//Fim do metodo Modificar

        public string ModificarEditora
        {
            get { return editora; }
            set { this.editora = value; }

        }//Fim do metodo Modificar

        public string ModificarGenero
        {
            get { return genero; }
            set { this.genero = value; }

        }// Fim do Metodo Modificar 

        public int ModificarIsbn
        {
            get { return isbn; }
            set { this.isbn = value; }

        }// Fim do Metodo Modificar

        public int ModificarPreco
        {
            get { return preco; }
            set { this.preco = value; }

        }// Fim do Metodo Modificar

        public int ModificarSituacao
        {
            get { return situacao ; }
            set { this.situaca = value ; }

        }// Fim do Metodo Modificar

        public void CadastrarLIvro(long codigo, string titulo, string autor, string editora, string genero, string isbn, int preco )
        {
            string consulta = "";
            if(ModificarCodigo == codigo)
            {
                consulta =
                          "\nTitulo: " + ModificarTitulo;
                "\nAutor:  " + ModificarAutor;
                "\nEditora:" + ModificarEditora;
                "\nGenero: " + ModificarGenero;
                "\nISBN:   " + ModificarIsbn;
                "\nPreço: " + ModificarPreco;
                "\nSituação" + ModificarSituacao;

            }
            else
            {
                consulta = "O Código não é valido !" ;

            }
            return consulta;

        }//Fim do método

        public void AtualizarTitulo(int codigo, string titulo)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarTitulo = titulo;
            }
        }// fim do método

        public void AtualizarAutor(int codigo, string autor)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarAutor = autor;
            }// fim do método
        }

        public void AtualizarEditora(int codigo, string editora)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarEditora = editora;
            }
        }//Fim do método

        public void AtualizarGenero(int codigo, string genero)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarGenero = genero;
            }
        }//Fim do método

        public void AtualizarIbn(int codigo, string ibn)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarIsbn = isbn;
            }
        }//Fim do método

        public void AtualizarPreco(int codigo, string preco)
        {
            if(ModificarCodigo == codigo)
            {
                ModificarPreco = preco;
            }
        }//fim do método
            
        public void Excluir(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                ModificarSituacao = "Inativo";
            }
        }//fim do método







    }
}
