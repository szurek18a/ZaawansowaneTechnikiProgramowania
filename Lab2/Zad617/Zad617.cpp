#include <iostream> 
#include <cstring>  
using namespace std;
#define T_SIZE 1001  

string string_merge(char*, char*);

int main()
{
    int t, n;
    char S1[T_SIZE], S2[T_SIZE];
    string S;
    cin >> t;
    cin.getline(S1, T_SIZE);
    while (t) {
        cin.getline(S1, T_SIZE, ' ');
        cin.getline(S2, T_SIZE);
        S = string_merge(S1, S2);
        cout << S << endl;
        t--;
    }
    return 0;
}

string string_merge(char* s1, char* s2) {
    string result = "";

    while (*s1 != 0 && *s2 != 0) {
        result += *s1;
        result += *s2;
        s1++;
        s2++;
    }
    return result;
}