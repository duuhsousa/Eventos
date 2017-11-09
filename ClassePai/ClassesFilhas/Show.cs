using System;
using System.IO;
using System.Text;

namespace ProjetoEvento.ClassePai.ClassesFilhas
{
    public class Show : Evento
    {
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }


        /// <summary>
        /// Construtor simples, sem atributos.
        /// </summary>
        public Show()
        {
            
        }

        /// <summary>
        /// Construtor com sobrecarga de atritubos.
        /// </summary>
        /// <param name="Titulo"></param>
        /// <param name="Local"></param>
        /// <param name="Lotacao"></param>
        /// <param name="Duracao"></param>
        /// <param name="Classicacao"></param>
        /// <param name="Data"></param>
        /// <param name="Artista"></param>
        /// <param name="GeneroMusical"></param>
        public Show(string Titulo, string Local, int Lotacao,  string Duracao, int Classicacao, DateTime Data, string Artista, string GeneroMusical)
        {
            base.Titulo = Titulo;
            base.Local = Local;
            base.Lotacao = Lotacao;
            base.Duracao = Duracao;
            base.Classificacao = Classificacao;
            base.Data = Data;
            this.Artista = Artista;
            this.GeneroMusical = GeneroMusical;
            
        }

    
        /// <summary>
        /// Método Cadastrar com override está sobrescrevendo o método Cadastrar() da classe pai.
        /// </summary>
        /// <returns></returns>
        public override bool Cadastrar(){
            bool efetuado = false;
            StreamWriter arquivo = null;
            try{
                arquivo = new StreamWriter("show.csv",true);
                arquivo.WriteLine(Titulo+";"+Local+";"+Duracao+";"+Data+";"+Artista+";"+GeneroMusical+";"+Lotacao+";"+Classificacao);
                efetuado = true;
            }catch(Exception ex){
                throw new Exception("Erro ao tentar gravar o arquivo\n"+ex.Message);
            }finally{
                arquivo.Close();
            }
            return efetuado;
        }

        /// <summary>
        /// Método Pesquisar(Titulo) com override está sobrescrevendo o método Pesquisar(Titulo) da classe pai.
        /// </summary>
        /// <param name="Tituto"></param>
        /// <returns></returns>
        public override string Pesquisar(string Tituto){
            string resultado = "Título não encontrado";
            StreamReader ler = null;
            try{
                ler = new StreamReader("show.csv",Encoding.Default);
                string linha = "";
                while((linha=ler.ReadLine())!=null){
                    string[] dados = linha.Split(';');
                    if(dados[0]==Titulo){
                        resultado = linha;
                        break;
                    }
                }    
            }catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo.\n"+ex.Message;
            }finally{
                ler.Close();
            }
            return resultado;
        }

        /// <summary>
        /// Método Pesquisar(Data) com override está sobrescrevendo o método Pesquisar(Data) da classe pai.
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public override string Pesquisar(DateTime Data){
            string resultado = "Data não encontrada";
            StreamReader ler = null;
            try{
                ler = new StreamReader("show.csv",Encoding.Default);
                string linha = "";
                while((linha=ler.ReadLine())!=null){
                    string[] dados = linha.Split(';');
                    if(dados[3]==Convert.ToString(Data)){
                        resultado = linha;
                        break;
                    }
                }    
            }catch(Exception ex){
                resultado = "Erro ao tentar ler o arquivo.\n"+ex.Message;
            }finally{
                ler.Close();
            }
            return resultado;
        }



    }
    
}