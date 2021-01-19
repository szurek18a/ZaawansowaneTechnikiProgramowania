// Zad1211.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
using namespace std;

int main()
{
	long long number;
	cin >> number;
	if (number == 0)
	{
		cout << number;
		return 0;
	}
	if (number == 2 || number == 1)
	{
		cout << "NIE" << endl;
		return 0;
	}
	for (long long i = 1; i <= number; i += 2)
	{
		cout << i << " ";

	}
	for (long long i = 0; i <= number; i += 2)
	{
		if (i != number)
		{
			cout << i << " ";
		}
		else cout << i;
	}

	return 0;
}
