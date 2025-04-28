#include <iostream>
#include <queue>

using namespace std;

/*
    8. Write a C++ function that takes a queue of integers and moves all the zeros in the queue to the end 
    while maintaining the order of the other elements and returns the new queue. For example if the input 
    queue contains [0,1,0,3,12], the output queue will contain [1,3,12,0,0]. Use only queue functions and do
    not use any data structure other than queues. You can use the STL's queue class.
*/

queue<int> moveZerorsToEnd(queue<int> Q) {

    queue<int> temp;
    int zeros = 0;
    while(!Q.empty()) {
        int current = Q.front();
        if (current != 0) {
            temp.push(current);
        }
        else {
            zeros++;
        }
        Q.pop();
    }
    for (int i =0; i < zeros; ++i) {
        temp.push(0);
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
    q.push(0);
    q.push(7);
    q.push(4);
    q.push(0);
    q.push(1);
    
    Print(q);
    Print(moveZerorsToEnd(q));
    return 0;
}



