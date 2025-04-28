#include <iostream>
#include <stack>

using namespace std;

/*
        - Problem Statement: 
            Write a C++ program that uses a stack to convert a decimal number to binary. 
            The program should read an integer from the user and print its binary representation 
            using a stack to reverse the order of the binary digits as they are calculated.

        - Example Input/Output: 
            13
            1101
            30
            11110
*/

string decimalToBinary(int n) {

    stack<bool> stk;
    while (n >0) {
        stk.push(n%2);
        n/=2;
    }
    string binary = "";
    while (!stk.empty()) {
        binary += stk.top() ? '1' : '0';
        stk.pop();
    }
    return binary;
}

int main() {
    cout << decimalToBinary(30);
    return 0;
}

