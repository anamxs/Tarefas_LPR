
#include <iostream>
using namespace std;

void imprimirNumeros(int inicio = 1,int fim = 100){

    for (int i = 1; i <= fim; i++){
        cout << i ;
    }
    cout <<endl;
}

void calcularMedia(int quantidade){
    float soma = 0, numero;

    for (int i = 1; i <= quantidade; i++){
        cout << "Digite o" << i << "primeiro numero: ";
        cin >> numero;
        soma+= numero;
    }

    float media = soma / quantidade;
    cout << "A media e:" << media << endl;
}

void calcularFatorial(int n){
    int fatorial = 1;

    for (int i = 0; i <= n; i++){
    fatorial*= i;

    cout << "O fatorial de " << n << " e: " << fatorial << endl;
    }
}

int main(){
    int opcao;

    do{
        cout << "\n====== MENU ======\n";
        cout << "1= Imprimir numeros de 1 a 100\n";
        cout << "2= Calcular media de N numeros\n";
        cout << "3= Calcular fatorial\n";
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao){
            case 1:
                imprimirNumeros();
                break;

            case 2: 
                int qtd;
                cout << "Quantos numeros voce deseja informar?: ";
                cin >> qtd;
                calcularMedia(qtd);
                break;

            case 3:
                int numero;
                cout << "Digite o numero que deseja calcular o fatorial: ";
                cin >> numero;
                calcularFatorial(numero);
                break;

            case 0: 
                cout << "Encerrando o prorama.\n";
                break; 

                default:
                cout << "Opção inválida.\n";
        }

    } while (opcao != 0);

    return 0;
}