#include <iostream>
#include <queue>

using namespace std;

/*
    6. Write a C++ boolean function that takes two queues and returns true of the two queues are identical 
    (contain the same values in the same positions), false otherwise. Use only queue functions and do not use 
    any data structure other than queues. You can use the STL's queue class.
*/

bool identical(queue<int> q1, queue<int> q2) {
    if (q1.size() != q2.size()) return false;

    for (int i =0; i < q1.size(); ++i) {
        if (q1.front() != q2.front()) {
            return false;
        }
        q1.pop(); q2.pop();
    }
    return true;
}

int main() {
    queue<int> q1;
    q1.push(5);
    q1.push(2);
    q1.push(0);
    
    queue<int> q2;
    q2.push(5);
    q2.push(2);
    q2.push(0);

    cout << identical(q1,q2);
    return 0;
}

