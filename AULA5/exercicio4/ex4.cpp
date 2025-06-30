/*
Exercício Proposto:
Solicite ao usuário para inserir
um número e calcule a soma dos dígitos do
quadrado desse número. Por exemplo, se o
número fornecido for 123, calcule 123² =
15129 e então a soma dos seus dígitos: 1 +
5 + 1 + 2 + 9 = 18.
*/

#include <iostream>
using namespace std;

int main() {
    int numero;
    cout << "Digite um numero: ";
    cin >> numero;

    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        int digito = quadrado % 10;
        soma += digito;
        quadrado /= 10;
    }
    cout << "Soma dos digitos do quadrado: " << soma << endl;
}
