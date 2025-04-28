#include <iostream>
#include <queue>

using namespace std;

/*
   - Problem Statement:
        Write a C++ program that simulates a traffic signal using a queue to manage vehicles 
        at an intersection. The vehicles are represented by any character (except ‘r’, ‘g’, ‘y’).
        The queue reads a series of inputs where each input can either be a vehicle or a signal 
        ('r' for red, 'g' for green, 'y' yellow). When 'r' is entered, no vehicles should move. 
        When 'g' is entered, up to three vehicles can move (leave the queue). When 'y' is entered, 
        only one vehicle can move and leave the queue. The output should display the vehicles left in the queue.

    - Example Input/Output:
        abcdgeyfr
        ef
*/

queue<char> trafficSignal(queue<char> q) {

    queue<char> temp;
    while (!q.empty()) {
        char current = q.front(); 
        q.pop();
        
        if (current == 'r' || current == 'g' || current == 'y') {

            if (current == 'g') {
                for (int i =0; i < 3; ++i) {
                    if (temp.empty()) {
                        break;
                    }
                    else {
                        temp.pop();
                    }
                }
            }
            else if (current == 'y') {
                if (!temp.empty()) {
                    temp.pop();
                }
            }
        }
        else {
            temp.push(current);
        }
    }
    return temp;
}


/* Utility Function to print the Queue */
void Print(queue<char> q) {
    while (!q.empty()) {
        cout << q.front() << " ";
        q.pop();
    }
    cout << endl;
}

int main() {
    queue<char> q;
    q.push('a');
    q.push('b');
    q.push('c');
    q.push('d');
    q.push('g');
    q.push('e');
    q.push('y');
    q.push('f');
    q.push('r');

    Print(q);
    Print(trafficSignal(q));
    return 0;
}



