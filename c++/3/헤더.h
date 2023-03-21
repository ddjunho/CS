#pragma once
using namespace std;
class Car {
private:
	int speed;
	int gear = 10;
	string color = "red";
public:

	Car() {
		cout << "생성자 입니다.\n--------------\n\n" ;
	}
	~Car() {
		cout << "\n\n--------------\n안녕히 가세요.";
	}
	void speedup() {
		speed += 10;
	}
	void speedch(int s) {
		if (s > 100)
			speed = 100;
		else
			speed = s;
	}
	void view() {
		cout << speed << endl;
		cout << gear << endl;
		cout << color << endl;
	}

};