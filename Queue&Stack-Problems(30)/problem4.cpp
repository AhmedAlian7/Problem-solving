#include <iostream>
#include <stack>

using namespace std;

/*

    4. Write the C++ code for the function popNth(S,n) that removes the nth value from a stack of integers S while keeping all 
    the other values in the stack. It should return the modified stack.
    For example: if the stack contains the values 2,5,6,8,9 (assuming that 9 is the top of the stack) and you call 
    popNth(S, 2) it should remove the value (8) and the stack should be 2,5,6,9.

    Note: Use only the stack operations and do not use any data structure other than the stack. 
    (Hint: You can use the STL's stack class).
*/

stack<int> popNth(stack<int> S, int n) {

    stack<int> tempS;
    int size = S.size(); 
    for (int i = 1; i <= size; i++) {
        int current = S.top();
        S.pop();

        if (i != n) {
            tempS.push(current);
        }
    }

    while (!tempS.empty()) {
        S.push(tempS.top());
        tempS.pop();
    }
    return S;
}

/* Utility Function to print the Queue */
void Print(stack<int>& s) {
    while (!s.empty()) {
        cout << s.top() << " ";
        s.pop();
    }
}

int main() {
    stack<int> q;
    q.push(5);
    q.push(4);
    q.push(3);
    q.push(2);
    q.push(1);
    

    int k = 3;
    q = popNth(q, k);
    Print(q);
    return 0;
}