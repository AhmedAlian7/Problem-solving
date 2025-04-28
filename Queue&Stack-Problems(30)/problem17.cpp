#include <iostream>
#include <stack>

using namespace std;

/*
        - Problem Statement: 
            Write a C++ program that duplicates characters using a stack. 
            The program should allow the user to add characters and the number 
            of times to repeat each of them. Assume the user inputs a series of
            characters and then inputs a number from '1' to ‘9’ to repeat the characters.

        - Example Input/Output: 
            3a2b1c
            a a a b b c
*/

stack<char> repeat(stack<char> stk) {

    stack<char> temp;
    
    // Reverse the stack into temp
    while (!stk.empty()) {
        temp.push(stk.top());
        stk.pop();
    }

    int duplicates = 0;
    
    while (!temp.empty()) {
        char current = temp.top();
        temp.pop();
        
        if (current >= '0' && current <= '9') {
            duplicates = current - '0';  // Set how many times to duplicate
        } 
        else {
            for (int i = 0; i < duplicates; ++i) {
                stk.push(current);
            }
        }
    }
    
    return stk;
}


/* Utility Function to print the Queue */
void Print(stack<char> s) {
    while (!s.empty()) {
        cout << s.top() << " ";
        s.pop();
    }
    cout <<endl;
}
int main() {

    stack<char> s;
    string input = "3a2b1c";

    for (char ch : input) {
        s.push(ch);
    }
    

    Print(s);
    Print(repeat(s));

    return 0;
}
