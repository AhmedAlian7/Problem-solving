#include <iostream>
#include <queue>

using namespace std;

/*

    3. Write the C++ code for the function dequeNth(Q,n) that removes the nth value from a queue of integers Q while keeping 
    all the other values in the queue. It should return the modified queue.
    For example: if the queue contains the values 2,5,6,8,9 (assuming that 2 is the front of the queue) and you call 
    dequeNth(Q, 2) it should remove the value (5) and the queue should be 2,6,8,9.

    Note: Use only the queue operations and do not use any data structure other than the queue. 
    (Hint: You can use the STL's queue class).
*/

queue<int> dequeNth(queue<int> Q, int n) {

    queue<int> tempQ;
    int Qsize = Q.size(); 
    for (int i = 1; i <= Qsize; i++) {
        int current = Q.front();
        Q.pop();

        if (i != n) {
            tempQ.push(current);
        }
    }

    return tempQ;
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
    q = dequeNth(q, k);
    Print(q);
    return 0;
}