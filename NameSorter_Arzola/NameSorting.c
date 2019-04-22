// NameSorting.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Name { // creates structure of arrays
	char firstName[20];
	char lastName[20];
};

FILE *file;

int main() {
	// Local variables
	struct Name names[200];
	int first = 1;
	int k = 0;
	int n = 0;
	int c;
	errno_t err;

	fopen_s(&file, "names.txt", "r");  // read in text document
	if (err == 0)
	{
		printf("The file 'names.txt' was opened\n");
	}
	else
	{
		printf("The file 'names.txt' was not opened\n");
	}

	if (file) {
		while ((c = getc(file)) != EOF) {
			putchar(c);
			if (c == '\n') {
				k++;
				n = 0;
				first = 1;
			}
			else if (c == ',') {
				n = 0;
				first = 0;
			}
			else if (c == ' ') {
			}
			else if (first) {
				names[k].lastName[n] = (char)c; //sorts names by last name first
				n++;
			}
			else {
				names[k].firstName[n] = (char)c; // sorts names by first name first
				n++;
			}

		}
	}
	printf("\n\n");

	char firstLetter = 'A'; //alphabatizes 
	char lastLetter = 'Z';
	while (firstLetter < lastLetter) {
		for (int i = 0; i < (k + 1); i++) {
			if (names[i].firstName[0] == firstLetter) {
				printf("%s %s\n", names[i].firstName, names[i].lastName); //prints names
			}
		}
		firstLetter++;
	} // prints both first names first and last names first

	system("pause");
	return 0; // end main
}