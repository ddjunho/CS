#include<iostream>
using namespace std;
class Animal {
public:
	void speak() {
		cout<<"목소리\n";
	}
};
class Dog : public Animal{
public:
	void speak() {
		cout << "개목소리\n";
	}
};
class Cat : public Animal
{
public:
	void speak() {
		cout << "냥목소리\n";
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
