#include <iostream>

using namespace std;

int main() {
    char op;
    double num1, num2;

    cout << "Tere tulemast kalkulaatorisse!" << endl;
    cout << "Kasutage operaatorit (+, -, *, /) ja kahte numbrit aritmeetilise toimingu sooritamiseks." << endl;

    cout << "Sisestage operaator (+, -, *, /): ";
    cin >> op;

    cout << "Sisestage kaks numbrit: ";
    cin >> num1 >> num2;

    switch(op) {
        case '+':
            cout << num1 << " + " << num2 << " = " << num1 + num2 << endl;
            break;

        case '-':
            cout << num1 << " - " << num2 << " = " << num1 - num2 << endl;
            break;

        case '*':
            cout << num1 << " * " << num2 << " = " << num1 * num2 << endl;
            break;

        case '/':
            if(num2 == 0) {
                cout << "Viga: nulliga jagamine" << endl;
            } else {
                cout << num1 << " / " << num2 << " = " << num1 / num2 << endl;
            }
            break;

        default:
            cout << "Viga: vale operaator" << endl;
            break;
    }

    return 0;
}
