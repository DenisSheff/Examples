int firstDumbBell = 1;
int secondDumbBell = 2;
int thirdDumbBell = 6;
int fourthDumbBell = 8;
int fifthDumbBell = 4;

int maxNumber = firstDumbBell;

if (firstDumbBell > maxNumber) maxNumber = firstDumbBell;
if (secondDumbBell > maxNumber) maxNumber = secondDumbBell;
if (thirdDumbBell > maxNumber) maxNumber = thirdDumbBell;
if (fourthDumbBell > maxNumber) maxNumber = fourthDumbBell;
if (fifthDumbBell > maxNumber) maxNumber = fifthDumbBell;

Console.WriteLine("Max number is " + maxNumber + "kg");