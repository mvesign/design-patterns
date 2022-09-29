using DesignPatterns.Structural.Composite;

var flWheel = new OrderItem("Front-left wheel", 10);
var frWheel = new OrderItem("Front-right wheel", 10);
var blWheel = new OrderItem("Back-left wheel", 10);
var brWheel = new OrderItem("Back-right wheel", 10);

var leftDoor = new OrderItem("Left door", 30);
var rightDoor = new OrderItem("Right door", 30);

var frame = new OrderItem("Frame", 100);
var engine = new OrderItem("Engine", 100);
var steeringWheel = new OrderItem("Steering wheel", 50);

var car = new OrderItem("Car");

car.Add(frame, engine, steeringWheel);
frame.Add(flWheel, frWheel, blWheel, brWheel, leftDoor, rightDoor);

car.PrintReceipt();