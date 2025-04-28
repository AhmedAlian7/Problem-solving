#include <iostream>
#include <queue>

using namespace std;

/*

    1. Write the C++ code for the function moveToFront(Q,k) which takes a queue of integers Q and moves
    the kth element (element at position k) of a queue to the front position then returns the modified queue. 
    Use only queue operations and do not use any data structure other than the queue.

*/

queue<int> moveToFront(queue<int> Q, int k) {

    if (k == 1) return Q;
    queue<int> tempQ;
    int goal;
    int size = Q.size();
    for (int i = 1; i <= size; i++)
    {
        int current = Q.front();
        Q.pop();

        if (i == k) {
            goal = current;
        }
        else {
            tempQ.push(current);
        }
    }
    Q.push(goal);

    while (!tempQ.empty()) {
        Q.push(tempQ.front());
        tempQ.pop();
    }
    
    return Q;
}


/* Utility Function to print the Queue */
void Print(queue<int>& q) {
    while (!q.empty()) {
        cout << q.front() << " ";
        q.pop();
    }
}

int main() {
    queue<int> q;
    q.push(5);
    q.push(4);
    q.push(3);
    q.push(2);
    q.push(1);
    

    int k = 3;
    q = moveToFront(q, k);
    Print(q);
    return 0;
}



