#include <iostream>
using namespace std;

/*Program that asks the user to enter a text iteratively until he/she types 
  a text with no 'a' or 'A' symbols in it.*/

int main() {
    string text;
    bool isItA;
    
    do
    {
        cout << "Type any text: ";
        cin >> text;
        isItA = false;
        for (unsigned int i=0 ; i < text.length() ; i++)
        {
            if (text [i] == 'a')
            {
                isItA = true;
            }
        }
    } while (isItA == true);
}

