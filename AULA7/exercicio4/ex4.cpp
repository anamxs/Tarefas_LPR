/*
Exercicio Proposto:
MATRIZ Crie um algoritmo que
leia duas matrizes A e B, de tamanho 3x3, e
calcule A*B. Dica abaixo:
*/

#include <iostream>
using namespace std;

int main(){
    const int TAM = 3;
    int A[TAM][TAM];
    int B[TAM][TAM];
    int C[TAM][TAM];

    cout << "Digite os valores da matriz A (3x3):\n"; 
    for (int i = 0; i < TAM; i++){
        for( int j = 0; j < TAM; j++){
            cin >> A[i][j];
        
        }
    }
    cout << "Digite os valores da matriz B (3x3):\n";
    for(int i = 0; i < TAM; i++){
        for(int j = 0; j < TAM; j++){
            cin >> B[i][j];
        }
    }
    for (int i = 0; i < TAM; i++){
        for( int j = 0; j < TAM; j++){
            C[i][j] = 0;
            for (int k = 0; k < TAM; k++){
                C[i][j] += A[i][k] * B[j][k];
            }
        }
    }
    cout << "Resultado da multiplicacao de A*B: ";
    for(int i = 0; i < TAM; i++){
        for(int j = 0; j < TAM; j++){
            cout << C[i][j] << " ";
        }
        cout << endl;
    }  
    return 0;
}