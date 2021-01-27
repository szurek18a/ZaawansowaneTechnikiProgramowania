// Zad567.cpp : Ten plik zawiera funkcję „main”. W nim rozpoczyna się i kończy wykonywanie programu.
//

#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	istreambuf_iterator<char> eos;
	string input(istreambuf_iterator<char>(cin), eos);
	
	string output;

	cin >> input;

	int dlugosc = input.length();
	char litera;
	char poprzedniaLitera;

	int sytuacja = 0;
	// 0 - norma, 1-może komentarz, 2-komentarz krótki, 3-komentarz długi, 4-może odkomentowanie

	for (int i = 0; i < dlugosc; i++)
	{
		litera = input[i];

		switch (sytuacja)
		{
		case 0:
			if (litera == '/')
			{
				poprzedniaLitera = litera;
				sytuacja = 1;
			}
			else
			{
				output = output + litera;
			}
			break;
		case 1:
			if(litera == '/')
			{ 
				sytuacja = 2;
			}
			else if (litera == '*')
			{
				sytuacja = 3;
			}
			else
			{
				sytuacja = 0;
				output = output + poprzedniaLitera + litera;
			}		
			break;

		case 2:
			if (litera == '\n')
			{
				sytuacja = 0;
				output = output + litera;
			}
			break;

		case 3:
			if (litera == '*')
				sytuacja = 4;
			break;
			
		case 4:
			if (litera == '/')
				sytuacja = 0;
			else
				sytuacja = 3;
			break;

		}

	}

	cout << output;
	return 0;
}

