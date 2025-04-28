#include <iostream>
#include <stack>

using namespace std;

/*

   5. Write a C++ function moveToTop(stack, v) that takes a stack of integers and a value v and moves this value to the top 
   of the stack, then return the modified stack. Do not use any data structures other than stacks. You can use the stack STL 
   container.


*/

stack<int> moveToTop(stack<int> stk, int val) {

    stack<int> temp;
    while (!stk.empty()) {
        int current = stk.top();

        if (current != val) {
            temp.push(current);
        }
        stk.pop();
    }

    while (!temp.empty()) {
        stk.push(temp.top());
        temp.pop();
    }
    stk.push(val);
    
    return stk;
}


/* Utility Function to print the Queue */
void Print(stack<int>& q) {
    while (!q.empty()) {
        cout << q.top() << " ";
        q.pop();
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
    q = moveToTop(q, k);
    Print(q);
    return 0;
}



