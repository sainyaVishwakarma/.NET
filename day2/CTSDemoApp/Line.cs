namespace Drawing;

//concrete class
public class Line:Shape{
    public Point startPoint;
    public Point endPoint;

   public const double PI=3.14;

     public Line(string c,int w,Point sp, Point ep):base(c,w){
        this.startPoint=sp;
        this.endPoint=ep;
    }

    public override void Draw(){
        Console.WriteLine("Drawing line");
        Console.WriteLine(this.color+" "+this.width+" ("+this.startPoint.x+","+this.startPoint.y+") , ("+this.endPoint.x+","+this.endPoint.y+")");
    }

    public override void Display(){
        base.Display();
         Console.WriteLine(" ("+this.startPoint.x+","+this.startPoint.y+") , ("+this.endPoint.x+","+this.endPoint.y+")");
    }
}