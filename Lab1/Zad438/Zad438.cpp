// Zad438.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include<iostream>
#include<cstdlib>
using namespace std;

int main()
{
    int n, number, mod;
    cin >> n;

    for (int i = 0; i < n; i++)
    {
        cin >> number;

        if (number < 2) cout << "NIE" << endl;
        else if (number == 2) cout << "TAK" << endl;
        else
        {
            for (int j = 2; j < number; j++)
            {
                mod = number % j;
                if (mod == 0)
                {
                    cout << "NIE" << endl;
                    break;
                }
            }
            if (mod == 1)
            {
                cout << "TAK" << endl;
            }
        }
    }

    return 0;
}

