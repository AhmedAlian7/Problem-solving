#include <iostream>
#include <stack>

using namespace std;

/*
        - Problem Statement: 
            Write a C++ program that reads a string from the user and checks if it's a palindrome 
            (reads the same backward as forward).

        - Example Input/Output: 
            abccba
            true
            abcabc
            false

*/

bool isPalindrome(string str) {

    stack<char> stk;
    for (char &c : str) {
        stk.push(c);
    }
    for (char &c : str) {
        if (stk.top() != c) {
            return false;
        }
        stk.pop();
    }
    return true;
}

int main() {
    cout << isPalindrome("abccba") << endl;
    cout << isPalindrome("abcabc");
    return 0;
}

