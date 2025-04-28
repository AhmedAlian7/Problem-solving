#include <iostream>
#include <queue>

using namespace std;

/*

    2. Given a Queue Q, write a method that will find the max element in the queue.
    Use only the queue operations and do not use any data structure other than the queue.
    (Hint: You can use the STL's queue class)
*/

int maxQ(queue<int> Q) {

    int max = Q.front();
    Q.pop();
    while(!Q.empty()) {
        int current = Q.front();
        Q.pop();
        if (current > max) max = current;
    }

    return max;
}


int main() {
    queue<int> q;
    q.push(5);
    q.push(41);
    q.push(33);
    q.push(23);
    q.push(12);
    cout << maxQ(q);
    return 0;
}