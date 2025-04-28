#include <iostream>
#include <queue>

using namespace std;

/*
    - Problem Statement
       Write a C++ function replace(q, c, r) that takes a queue and two integers. 
       If any value is greater than ‘c’, it should be replaced with it. If any value 
       equals ‘c’, it should be replaced with ‘r’. Then return the modified queue.

    - Example Input/Output
        c=10, r=1
        2 11 3 15 10 4
        2 10 3 10 1 4
*/

queue<int> replaceQ(queue<int> q, int c, int r) {

    queue<int> temp;
    while (!q.empty()) {
        int current = q.front();
        q.pop();

        if (current > c) {
            temp.push(c);
        }
        else if (current == c) {
            temp.push(r);
        }
        else {
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
    q.push(2);
    q.push(11);
    q.push(3);
    q.push(15);
    q.push(10);
    q.push(4);


    
    Print(q);
    Print(replaceQ(q,10,1));
    return 0;
}



