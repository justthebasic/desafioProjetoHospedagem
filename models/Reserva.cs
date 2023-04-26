using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafioProjetoHospedagem.models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get;set;}
        public Suite Suite{get;set;}
        public int DiasReservados {get;set;}

        public Reserva(){ }

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            //TODO: verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            //implemente aqui
            if(hospedes.Count <= Suite.Capacidade ){
                Hospedes = hospedes;
            }else {
                // TODO: retornar exception caso a capacidade seja menor que o número de hóspedes 
                //implemente aqui
                throw new Exception("Capacidade de suite insuficiente para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(){
            //TODO: retornar a quantida de hospedes (propriedade Hospedes)
            //implemente aqui
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(){
            //TODO: retornar o valor da diária 
            //calculo: DiasReservados x Suite.ValorDiaria
            //implesmente aqui
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //regra: caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            //implemente aqui
            if(DiasReservados >= 10){
                valor *= 0.9m;
            }
            return valor;

        }
    }
}