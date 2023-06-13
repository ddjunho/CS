#include <iostream>
#include <map>
#include <vector>
using namespace std;

struct MenuItem {
	string name;
	int price;
	int stock;
	int quantitySold;
};

class Machine {
	vector<MenuItem> menuItems;
	int totalSales;

public:
	Machine() {
		totalSales = 0;
	}

	void addMenu(string name, int price, int stock) {
		menuItems.push_back(MenuItem{ name, price, stock, 0 });
	}

	void showMenu() {
		for (auto it = menuItems.begin(); it != menuItems.end(); it++) {
			cout << "음료 : "<< it->name << endl;
			cout << "가격 : " << it->price << "원" << endl;
			cout << "재고 : " << it->stock << "개" << endl;
			cout << endl;
		}
	}

	void sellMenu(int choice, int quantity) {
		if (choice >= 1 && choice <= menuItems.size()) {
			MenuItem& selectedMenu = menuItems[choice - 1];
			if (selectedMenu.stock >= quantity) {
				selectedMenu.stock -= quantity;
				selectedMenu.quantitySold += quantity;
				int totalPrice = selectedMenu.price * quantity;
				totalSales += totalPrice;

				cout << "선택한 메뉴 : " << selectedMenu.name << endl;
				cout << "가격 : " << selectedMenu.price << "원" << endl;
				cout << "수량 : " << quantity << "개" << endl;
				cout << "판매 완료" << endl;
				cout << endl;
			}
			else {
				cout << "재고가 부족합니다." << endl;
				cout << endl;
			}
		}
		else {
			cout << "유효하지 않은 메뉴 선택입니다." << endl;
			cout << endl;
		}
	}

	int getTotalSales() {
		return totalSales;
	}

	void BuyCount() {
		cout << "구매한 품목 개수" << endl;
		for (const MenuItem& menuItem : menuItems) {
			cout << menuItem.name << ": " << menuItem.quantitySold << "개" << endl;
		}
	}
};

int main() {
	Machine m1;
	m1.addMenu("콜라", 1500, 5);
	m1.addMenu("사이다", 2000, 3);
	m1.addMenu("솔의 눈", 2500, 2);

	while (true) {
		cout << "자판기 메뉴" << endl;
		m1.showMenu();

		cout << "음료를 선택하세요 (0을 입력하면 종료): ";
		int choice;
		cin >> choice;

		if (choice == 0) {
			cout << "구매를 종료합니다." << endl;
			break;
		}

		cout << "구매할 개수를 입력하세요 : ";
		int quantity;
		cin >> quantity;

		m1.sellMenu(choice, quantity);
	}

	cout << "총 구매액 : " << m1.getTotalSales() << "원" << endl;
	m1.BuyCount();

	return 0;
}
