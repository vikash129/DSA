#include <iostream>
using namespace std;
#include "Stack.hpp"

int main()
{
    Stack<int> roll(4);
    roll.push(34);
    roll.push(4);
    roll.push(3);

//  cout <<    roll.pop() << endl;
//  cout <<    roll.pop() << endl;
//  cout <<    roll.pop() << endl;

roll.push(6969);
 cout <<    roll.getTop() << endl;
 cout <<    roll.getBottom() << endl;

cout << "\nshowing stack\n";
    roll.show();

    return 0;
}