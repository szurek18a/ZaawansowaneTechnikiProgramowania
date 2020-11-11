// Zad499.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;
int potegowanie(int a, int b);
int main()
{
    int D, a, b, c;
    int wyniki[10];
    cin >> D;
    for (int i = 0; i < D; i++) {
        cin >> a >> b;
        int c = b % 4;
        if (b > 0 && c > 0)
            b = c;
        wyniki[i] = potegowanie(a, b);
    }

    for (int i = 0; i < D; i++) {
        cout << wyniki[i] % 10 << endl;
    }
}
int potegowanie(int a, int b) {
    if (b == 0)
        return 1;
    else
        return a = a * potegowanie(a, --b);
}

