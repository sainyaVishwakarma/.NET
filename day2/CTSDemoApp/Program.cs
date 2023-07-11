// See https://aka.ms/new-console-template for more information
using Drawing;
using TeamBuilding;
Point startPoint=new Point(2,5);
Point endPoint=new Point(3,9);

Point startPoint1=new Point(35,54);
Point endPoint1=new Point(12,24);

Line l1=new Line("red",7,startPoint,endPoint);
Line l2=new Line("black",2,startPoint,endPoint1);
l1.Draw();
l2.Draw();

Shape s1=l1;
Shape s2=l2;

l1.Draw();
l2.Draw();
l2.Display();
Leader ldr1=Leader.GetLeader();
Leader ldr2=Leader.GetLeader();
Leader ldr3=Leader.GetLeader();

Console.WriteLine("count= "+Leader.count);

