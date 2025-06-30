/*
Exercicio Proposto:
VETOR: Construa um algoritmo
que leia 10 números inteiros e armazene-os
em um vetor (use o for para fazer a leitura).
Depois, crie automaticamente dois
vetores, um contendo apenas os números
pares e outro os números ímpares
digitados. 

*/

#include <iostream>
using namespace std;

int main(){
    int numero[10];
    int pares[10], impares[10];
    int contPares = 0, contImpares = 0;

    for (int i; i <= 10; i++){
        cout << "Digite o " << i + 1 << "º número: ";
        cin >> numero[i]; 

        if(numero[i] % 2 == 0){
            pares[contPares] = numero[i];
            contPares++;
        } else {
            impares[contImpares] = numero[i];
            contImpares++;
        }
    }
    cout << "\nNúmeros pares: ";
    for (int i = 0; i < contPares; i++) {
        cout << pares[i] << " ";
    }

    cout << "\nNúmeros ímpares: ";
    for (int i = 0; i < contImpares; i++) {
        cout << impares[i] << " ";
    }
    
    cout << endl;
    return 0;
}
