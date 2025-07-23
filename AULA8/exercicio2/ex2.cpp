
/*Exercício Proposto:
RESOLVA EM C++
Defina uma struct Livro com os seguintes
campos: Titulo, Autor, AnoPublicacao,
NumeroPaginas e Preco. Crie um
programa que permita ao usuário inserir
dados de 3 livros e, em seguida, calcule e
exiba o preço total dos livros cadastrados
e a média de páginas dos livros.*/

#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro livros[3];
    float precoTotal = 0;
    int somaPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":" << endl;

        cout << "Título: ";
        cin >> livros[i].Titulo;

        cout << "Autor: ";
        cin >> livros[i].Autor;

        cout << "Ano de Publicação: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Número de Páginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preço: ";
        cin >> livros[i].Preco;

        cout << endl;

        precoTotal += livros[i].Preco;
        somaPaginas += livros[i].NumeroPaginas;
    }

    float mediaPaginas = somaPaginas / 3.0;
    cout << "O preço total dos livros: R$ " << precoTotal << endl;
    cout << "A média de páginas é: " << mediaPaginas << " páginas" << endl;

    return 0;
}
