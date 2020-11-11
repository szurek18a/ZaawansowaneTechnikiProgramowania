// Zad496.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>

using namespace std;

int silnia(int n)
{
    if (n == 0) return 1;
    else return n * silnia(n - 1);
}
int D, n;
int main()
{
    cin >> D;
    for (int i = 0; i < D; i++)
    {
        cin >> n;
        if (n < 10)
        {
            cout << silnia(n) % 100 / 10 << " " << silnia(n) % 10 << endl;
        }
        else cout << "0 0" << endl;
    }
    return 0;
}

