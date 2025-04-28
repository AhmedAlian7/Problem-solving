#include <iostream>
#include <queue>

using namespace std;

/*

    7. Write a C++ function replace(q, v1, v2) that takes a queue and two values and replaces all occurrences 
       of the first value with the second value then returns the modified queue.
       Use only queue functions and do not use any data structure other than queues.
       You can use the STL's queue class. 



*/

queue<int> replace(queue<int> Q, int v1, int v2) {

    queue<int> temp;
    while(!Q.empty()) {
        int current = Q.front();
        if (current == v1) {
            temp.push(v2);
        }
        else {
            temp.push(current);
        }
        Q.pop();
    }
    return temp;
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
    Print(replace(q, 2,7));
    return 0;
}



