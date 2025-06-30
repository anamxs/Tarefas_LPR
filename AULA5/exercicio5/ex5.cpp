/*
Exercício Proposto:
Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.
*/

#include <iostream>
using namespace std;

int main() {
    double horasPorDia;
    cout << "Digite quantas horas voce treina por dia: ";
    cin >> horasPorDia;

    int DiasUteis = 5;
    double horasPorSemana = horasPorDia * DiasUteis;

    double totalHorasNecessarias = 1000;
    double semanasNecessarias = totalHorasNecessarias / horasPorSemana;
    double diasNecessarios = semanasNecessarias * DiasUteis;
    double mesesNecessarios = semanasNecessarias / 4.5;

    cout << "\nPara atingir 1000 horas de treinamento, voce precisara de:" << endl;
    cout << "- " << diasNecessarios << " dias uteis" << endl;
    cout << "- " << semanasNecessarias << " semanas" << endl;
    cout << "- " << mesesNecessarios << " meses (considerando 1 mes = 4.5 semanas)" << endl;

    return 0;
}
