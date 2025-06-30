/* Exercício Proposto: 
Leia 2 valores inteiros (A e B). Após, o
programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos",
indicando se os valores lidos são múltiplos
entre si. Atenção: os números podem ser
digitados em ordem crescente ou
decrescente.
*/

#include <iostream>

using namespace std;

int main(){
    int A;
    int B;

    cout << "Digite o primeiro valor: ";
    cin >> A;
    cout << "Digite o segundo valor: ";
    cin >> B;

    if (A % B == 0 || B % A == 0){
        cout << "Sao multiplos os valores inteiros";
    } else {
        cout << "Nao sao multiplos os valores inteiros";
    }
}