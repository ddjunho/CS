#include <iostream>
using namespace std;
class Car
{
	int speed = 0;
	int gear = 0;
public:
	Car() {
		cout << "생성자입니다."<<endl;
		speed = 0;
		gear = 0;

	}
	Car(int speed, int gear) {
		cout << "생성자2입니다." << endl;
		this->speed = speed;
		this->gear = gear;

	}
	void view() {
		cout << "speed = " << speed << endl;
		cout << "gear = " << gear << endl;
	}
private:

};
class Taxi : public Car
{
	int meter = 2000;
public:
	Taxi(){
		cout << "Taxi입니다." << endl;

	}
	Taxi(int s) : Car(s, 2) {
		cout << "Taxi2입니다." << endl;

	}
	Taxi(int s, int t) : Car(s,t) {
		cout << "Taxi3입니다." << endl;

	}
	void show() {
		cout << "meter = " << meter << endl;
	}
private:

};

void main() {
	Taxi c1(3);
	c1.view();
	c1.show();
}
