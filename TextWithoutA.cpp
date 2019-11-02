#include <iostream>
using namespace std;

int main() {
    string text;
    bool isItA;
    do
    {
        cout<< "Type any text: ";
        cin>> text;
        isItA = false;
        for (unsigned int i=0 ; i<text.length() ; i++)
        {
            if (text [i]=='a')
            {
                isItA=true;
            }
        }
    } while (isItA == true);
}
