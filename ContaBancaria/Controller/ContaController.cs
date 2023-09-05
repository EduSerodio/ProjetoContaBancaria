using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContaBancaria.Model;
using ContaBancaria.Repository;

namespace ContaBancaria.Controller
{
    public class ContaController : IContaRepository
    {
        
        private readonly List<Conta> listaContas = new List<Conta>();
        int numero = 0;

        //Métodos crud
        public void Atualizar(Conta conta)
        {
            var buscaConta = BuscarNaCollection(conta.GetNumero());

            if(buscaConta is not null)
            {
                var index = listaContas.IndexOf(buscaConta);
                listaContas[index] = conta;

                Console.WriteLine($"A conta n° {conta.GetNumero()} foi atualizada com sucesso! ");
            }
            else{

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta n°{numero} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Conta conta)
        {
            listaContas.Add(conta);
            Console.WriteLine($"A conta número {conta.GetNumero()} foi criada com sucesso");
        }

        public void Deletar(int numero)
        {
            var conta = BuscarNaCollection(numero); 
            if (conta is not null)
            {
                if (listaContas.Remove(conta) == true)
                {
                    Console.WriteLine($"A conta {numero} foi apagada com sucesso!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"A conta {numero} não foi encontrada!");
                    Console.ResetColor();
                }
            }
        }

        void IContaRepository.Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void ListarTodas()
        {
            foreach (var conta in listaContas)
            {
                conta.Visualizar();
            }
        }

        //Métodos bancários
        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if(conta is not null){
                conta.Visualizar();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A conta numero {numero} não foi encontrada!!");
                Console.ResetColor();
            }
        }

        void IContaRepository.Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        void IContaRepository.Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }

        //métodos Auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }

        //Método para buscar numero na collection
        public Conta? BuscarNaCollection(int numero){

            foreach (var conta in listaContas)
            {
                if(conta.GetNumero() == numero)
                return conta;
            }
                return null;
        }

    }
}
