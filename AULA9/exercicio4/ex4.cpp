/*
Exercicio Proposto:
Construa um dicionário de x pares chave-valor
onde as chaves são nomes de cidades e os
valores são suas respectivas populações.
Encontre e imprima todas as cidades com
população acima da média.
Encontre e imprima o nome da cidade mais
populosa e o nome da cidade menos populosa.
Remova todas as cidades com população igual
a um valor Y (fornecido pelo usuário) e
imprima o dicionário atualizado.
*/

#include <iostream>
#include <map>
#include <vector>

using namespace std;

int main() {
    int x;
    cout << "Quantas cidades deseja adicionar? ";
    cin >> x;

    map<string, int> cidades;
    for (int i = 0; i < x; i++) {
        string nome;
        int pop;
        cout << "Cidade: ";
        cin >> nome;
        cout << "População: ";
        cin >> pop;
        cidades[nome] = pop;
    }

    // Média
    int soma = 0;
    for (auto c : cidades) soma += c.second;
    double media = soma / (double)cidades.size();

    cout << "\nCidades com população acima da média:\n";
    for (auto c : cidades)
        if (c.second > media)
            cout << c.first << endl;

    // A mais pop e a menos pop
    string maiorCidade, menorCidade;
    int maior = 0, menor = INT_MAX;

    for (auto c : cidades) {
        if (c.second > maior) {
            maior = c.second;
            maiorCidade = c.first;
        }
        if (c.second < menor) {
            menor = c.second;
            menorCidade = c.first;
        }
    }

    cout << "\nMais populosa: " << maiorCidade << endl;
    cout << "Menos populosa: " << menorCidade << endl;

    // Remover a população de Y
    int y;
    cout << "\nDigite a população para remover: ";
    cin >> y;

    vector<string> remover;
    for (auto c : cidades)
        if (c.second == y)
            remover.push_back(c.first);

    for (string nome : remover)
        cidades.erase(nome);

    // Mostrar o dicionário atualizado aqui
    cout << "\nCidades atualizadas:\n";
    for (auto c : cidades)
        cout << c.first << ": " << c.second << endl;
}
