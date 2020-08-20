// ConsoleApplication3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;


int main()
{
    const int NUMS = 5;
    const int COMBINEDSIZE = 10;

    int firstIntegers[NUMS] = { 1, 2, 3, 4, 5 };
    int secondIntegers[NUMS] = { 6, 7, 8, 9, 10 };
    int combinedArray[COMBINEDSIZE];

    for (int i = 0; i < COMBINEDSIZE; i++)
    {
        if (i < 5)
        {
            combinedArray[i] = firstIntegers[i];
        }
        if (i >= 5)
        {
            combinedArray[i] = secondIntegers[i - NUMS];
        }
    }

    for (int i = 0; i < COMBINEDSIZE; i++)
        cout << combinedArray[i];

    return 0;
}

