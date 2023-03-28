#include<iostream>
using namespace std;
class Animal {
public:
	void speak() {
		cout<<"格家府\n";
	}
};
class Dog : public Animal{
public:
	void speak() {
		cout << "俺格家府\n";
	}
};
class Cat : public Animal
{
public:
	void speak() {
		cout << "成格家府\n";
	}
};
int main() {
	/*Dog* d1;
	Cat c1;
	d1->speak();
	c1.speak();
	d1->Animal::speak();
	delete d1;*/
	Animal* pa = new Dog();
	pa->speak();
}