#include<iostream>
#include"Çì´õ.h"

int main() {
	Car c1;/*
	c1.speedch(222);
	c1.view();*/
	Car* c2 = new Car();
	c2->view();
	delete c2;
	c1.view();
	return 0;
}