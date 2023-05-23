#include <iostream>
#include "Stack.hpp"
using namespace std;

Stack<char>operatorStack;
Stack<int>operandStack;

enum symtype {
    operand , 
    openparen ,
    closeparen,
    oprator  };

    