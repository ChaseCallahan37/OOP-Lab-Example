//Do not forget to add the using statement for the namespace
//that your class is in
using lab_demo;

//Instantiate a new Car object, making sure to explain how the arguments are passed
//to the constructor and assigned to the fields
Car myCar = new Car("Camry");

//Demonstrate how to increase the total number of owners the car has had by incrementing the field by 2
myCar.AddOwner();
myCar.AddOwner();

//Print out the car information using the ToString method
Console.WriteLine(myCar.ToString());