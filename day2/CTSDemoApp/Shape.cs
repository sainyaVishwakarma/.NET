namespace Drawing;

// abstract class
public abstract class Shape{
    public string color;
    public int width; 

    public Shape(){
        this.color="blue";
        this.width=5;
    }

      public Shape(string c,int w){
        this.color=c;
        this.width=w;
    }

    public abstract void Draw();

    public virtual void Display(){
        Console.WriteLine(this.width+" "
        +this.color);
    }
}