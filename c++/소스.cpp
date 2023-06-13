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
			cout << "���� : "<< it->name << endl;
			cout << "���� : " << it->price << "��" << endl;
			cout << "��� : " << it->stock << "��" << endl;
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

				cout << "������ �޴� : " << selectedMenu.name << endl;
				cout << "���� : " << selectedMenu.price << "��" << endl;
				cout << "���� : " << quantity << "��" << endl;
				cout << "�Ǹ� �Ϸ�" << endl;
				cout << endl;
			}
			else {
				cout << "��� �����մϴ�." << endl;
				cout << endl;
			}
		}
		else {
			cout << "��ȿ���� ���� �޴� �����Դϴ�." << endl;
			cout << endl;
		}
	}

	int getTotalSales() {
		return totalSales;
	}

	void BuyCount() {
		cout << "������ ǰ�� ����" << endl;
		for (const MenuItem& menuItem : menuItems) {
			cout << menuItem.name << ": " << menuItem.quantitySold << "��" << endl;
		}
	}
};

int main() {
	Machine m1;
	m1.addMenu("�ݶ�", 1500, 5);
	m1.addMenu("���̴�", 2000, 3);
	m1.addMenu("���� ��", 2500, 2);

	while (true) {
		cout << "���Ǳ� �޴�" << endl;
		m1.showMenu();

		cout << "���Ḧ �����ϼ��� (0�� �Է��ϸ� ����): ";
		int choice;
		cin >> choice;

		if (choice == 0) {
			cout << "���Ÿ� �����մϴ�." << endl;
			break;
		}

		cout << "������ ������ �Է��ϼ��� : ";
		int quantity;
		cin >> quantity;

		m1.sellMenu(choice, quantity);
	}

	cout << "�� ���ž� : " << m1.getTotalSales() << "��" << endl;
	m1.BuyCount();

	return 0;
}
