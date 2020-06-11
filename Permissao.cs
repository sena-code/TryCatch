using System;
using System.IO;

namespace TryCatch
{
    public class Permissao
    {
        private bool Acesso { get; set; }

        public int Idade { get; set; }

        public void Autorizar(){

            System.Console.WriteLine("Acessar a Aplicação? True/False ");

            try{
                Acesso = Boolean.Parse(Console.ReadLine());
            }catch(System.Exception){
                using (StreamReader sr = File.OpenText("doc.txt"))
                System.Console.WriteLine($"Erro nos dados inseridos {sr.ReadLine()}");
            }

        }

        public void Age(){
            System.Console.WriteLine("Digite sua idade: ");

            try{
                Idade = Int32.Parse(Console.ReadLine());
            }catch(Exception){
                using (StreamReader sr = File.OpenText("doc.txt"))
            {
                Console.WriteLine($"Valor inválido ou numero inexistente {sr.ReadLine()}");
            }
            }
        }
    }

    
}