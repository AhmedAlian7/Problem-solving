#include <iostream>
#include <queue>

using namespace std;

/*
    - Problem Statement
        Write a C++ program that removes all the odd values and replaces all even values 
        less than 10 with ‘0’ from a queue of integers Q while keeping all the other values 
        in the queue. It should return the modified queue.


    - Example Input/Output
        21 24 1 200 8 99 110
        24 200 0 110
*/

queue<int> evenOddQueue(queue<int> Q) {

    queue<int> temp;
    while(!Q.empty()) {
        int current = Q.front();
        Q.pop();
        if (!(current & 1) && current < 10) {
            temp.push(0);
        }
        else if (!(current & 1)) {
            temp.push(current);
        }
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
    q.push(21);
    q.push(24);
    q.push(1);
    q.push(200);
    q.push(8);
    q.push(99);
    q.push(110);


    
    Print(q);
    Print(evenOddQueue(q));
    return 0;
}



