/* 
Exercício Proposto
Construa uma função em C++ que retorne
o reverso de um número inteiro.
*/

#include <iostream>
using namespace std;

int reverterNumero(int numero){
    int reverso = 0;

    while(numero != 0){
        int digito = numero % 10;
        reverso = reverso * 10 + digito;
        numero /= 10;
    }
     return reverso;
}

int main()
{
    int num;

    cout << "Digite um numero inteiro: ";
    cin >> num;

    int resultado = reverterNumero(num);
    cout << " O numero reverso dele e: " << resultado << endl;

    return 0;
}