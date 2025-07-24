/*
Exercicio Proposto:
Construa uma lista de 100 números
aleatórios
Crie um algoritmo que coloque-os em
ordem crescente e imprima-os
A partir dessa lista ordenada, remova
todos os números pares e imprima a lista
novamente.
Por fim imprima quais números se
repetem, se existe algum número
repetido.
*/

#include <iostream>
#include <list>
#include <algorithm>
#include <ctime>

using namespace std;

int main() {
    list<int> numeros;
    srand(time(0));

    for (int i = 0; i < 100; i++) {
        numeros.push_back(rand() % 100);
    }

    numeros.sort();
    cout << "Lista ordenada:\n";
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << endl;

    for (auto it = numeros.begin(); it != numeros.end(); ) {
        if (*it % 2 == 0)
            it = numeros.erase(it);
        else
            ++it;
    }

    cout << "Lista sem pares:\n";
    for (int num : numeros) {
        cout << num << " ";
    }
    cout << endl;

    cout << "Números repetidos:\n";
    list<int> jaVerificados;
    for (auto it = numeros.begin(); it != numeros.end(); ++it) {
        int atual = *it;
        if (count(jaVerificados.begin(), jaVerificados.end(), atual) == 0) {
            int vezes = count(numeros.begin(), numeros.end(), atual);
            if (vezes > 1) {
                cout << atual << " aparece " << vezes << " vezes\n";
            }
            jaVerificados.push_back(atual);
        }
    }
}
