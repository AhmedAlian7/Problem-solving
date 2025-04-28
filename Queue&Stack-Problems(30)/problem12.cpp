#include <iostream>
#include <queue>

using namespace std;

/*
    - Problem Statement
        Write a C++ code for the function evenToFront(Q) which takes a queue of integers Q 
        and moves the first even element of the queue to the front position then returns 
        the modified queue. Use only queue operations and do not use any data structure 
        other than the queue.

    - Example Input/Output
        1 3 5 2 7 8 9
        2 1 3 5 7 8 9
*/

queue<int> evenToFront(queue<int> Q) {

    queue<int> temp;
    int firstEven;
    while(!Q.empty()) {
        int current = Q.front();
        Q.pop();
        if (current & 1) {
            temp.push(current);
        }
        else {
            firstEven = current;
            break;
        }
    }
    while(!Q.empty()) {
        temp.push(Q.front());
        Q.pop();
    }
    
    Q.push(firstEven);
    while(!temp.empty()) {
        Q.push(temp.front());
        temp.pop();
    }
    return Q;
}


/* Utility Function to print the Queue */
void Print(queue<int> q) {
    while (!q.empty()) {
        cout << q.front() << " ";
        q.pop();
    }
    cout << endl;
}

int main() {
    queue<int> q;
    q.push(5);
    q.push(2);
    q.push(3);
    q.push(2);
    q.push(1);
    
    Print(q);
    Print(evenToFront(q));
    return 0;
}



