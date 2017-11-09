using System;

namespace ProjetoEvento.ClassePai
{

    /// <summary>
    /// Classe Evento é abstrata para impossibilitar sua construção, obigando a utilização dos construtores Show, Teatro e Cinema.
    /// </summary>
    public abstract class Evento
    {
        public string Titulo { get; set; }
        public string Local { get; set; }
        public int Lotacao { get; set; }
        public string Duracao { get; set; }
        public DateTime Data { get; set; }
        public int Classificacao { get; set; }

        /// <summary>
        /// Método é virtual para ser sobresescrito pelos métodos filhos.
        /// </summary>
        /// <returns></returns>
        public virtual bool Cadastrar(){
            return false;
        }

        /// <summary>
        /// Método é virtual para ser sobresescrito pelos métodos filhos.
        /// </summary>
        /// <param name="DataEvento"></param>
        /// <returns></returns>
        public virtual string Pesquisar(DateTime DataEvento){
            return null;
        }

        /// <summary>
        /// Método é virtual para ser sobresescrito pelos métodos filhos.
        /// </summary>
        /// <param name="TitutoEvento"></param>
        /// <returns></returns>
        public virtual string Pesquisar(string TitutoEvento){
            return null;
        }
    }

}