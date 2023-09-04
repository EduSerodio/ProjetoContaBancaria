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
        
        private readonly List<Conta> listaConstas = new List<Conta>();
        int numero = 0;

        //Métodos crud
        public void Atualizar(Conta conta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Conta conta)
        {
            listaConstas.Add(conta);
            Console.WriteLine($"A conta número {conta.GetNumero()} foi criada com sucesso");
        }

        void IContaRepository.Deletar(int numero)
        {
            throw new NotImplementedException();
        }

        void IContaRepository.Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void ListarTodas()
        {
            foreach (var conta in listaConstas)
            {
                conta.Visualizar();
            }
        }

        //Métodos bancários
        void IContaRepository.ProcurarPorNumero(int numero)
        {
            throw new NotImplementedException();
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
    }
}
