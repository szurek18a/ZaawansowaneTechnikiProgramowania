// Zad438.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include<iostream>
#include<cstdlib>
using namespace std;

bool czy_pierwsza(int n)
{
	if (n < 2)
		return false;

	for (int i = 2; i * i <= n; i++)
		if (n % i == 0)
			return false;
	return true;
}

int main()
{
	int n, liczba;

	cout << "Podaj liczbe testow: ";
	cin >> n;
	
	for (int i = 0; i < n; i++)
	{
		cin >> liczba;

		if (czy_pierwsza(liczba))
			cout << "Liczba " << liczba << " jest pierwsza" << endl;
		else
			cout << "Liczba " << liczba << " nie jest pierwsza" << endl;
	}

	return 0;
}

