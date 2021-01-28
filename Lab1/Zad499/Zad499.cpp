// Zad499.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;
int potegowanie(int a, int b);
int main()
{
    int D;
    unsigned int a, b;
    cin >> D;
    for (int i = 1; i <= D; i++)
    {
        cin >> a >> b;

        switch (a % 10)
        {
        case 0: case 1: case 5: case 6:
        {
            cout << a % 10;
        }
        break;

        case 2:
        {
            if (b % 4 == 1) cout << 2;
            if (b % 4 == 2) cout << 4;
            if (b % 4 == 3) cout << 8;
            if (b % 4 == 0) cout << 6;

        }
        break;

        case 3:
        {
            if (b % 4 == 1) cout << 3;
            if (b % 4 == 2) cout << 9;
            if (b % 4 == 3) cout << 7;
            if (b % 4 == 0) cout << 1;

        }
        break;

        case 4:
        {
            if (b % 2 == 0) cout << 6;
            else cout << 4;
        }
        break;

        case 7:
        {
            if (b % 4 == 1) cout << 7;
            if (b % 4 == 2) cout << 9;
            if (b % 4 == 3) cout << 3;
            if (b % 4 == 0) cout << 1;
        }
        break;

        case 8:
        {
            if (b % 4 == 1) cout << 8;
            if (b % 4 == 2) cout << 4;
            if (b % 4 == 3) cout << 2;
            if (b % 4 == 0) cout << 6;
        }
        break;

        case 9:
        {
            if (b % 2 == 0) cout << 1;
            else cout << 9;
        }
        break;
        }
        cout << endl;
    }
    return 0;
}

