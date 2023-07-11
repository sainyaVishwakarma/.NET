namespace person;
public class Person{
    private int pid;
    private string fname;
    private string lname;
    private string mobile;
    private string email;
    private DateTime bdate;

    public Person(){
        Console.WriteLine("in default constructor");
        this.pid=1;
        this.fname="sainya";
        this.lname="vishwakarma";
        this.mobile="6388556507";
        this.email="1605.sainya@gmail.com";
        this.bdate= new DateTime(2002,05,16);

    }

    public Person(int pid,string fn,string ln,string mob,string email,DateTime bdt){
        Console.WriteLine("in parameterized constructor");
        this.pid=pid;
        this.fname=fn;
        this.lname=ln;
        this.mobile=mob;
        this.email=email;
        this.bdate=bdt;

    }

    public int Pid{
        get{return this.pid;}
        set{this.pid=value;}
    }

    public string Fname{
        get{return this.fname;}
        set{this.fname=value;}
    }

    public string Lname{
        get{return this.lname;}
        set{this.lname=value;}
    }

    public string Mobile{
        get{return this.mobile;}
        set{this.mobile=value;}
    }

    public string Email{
        get{return this.email;}
        set{this.email=value;}
    }

    public DateTime Bdate{
        get{return this.bdate;}
        set{this.bdate=value;}
    }

    public override string ToString(){
        return this.pid+" "+this.fname+" "+this.lname+" "+this.mobile+" "+this.email+" "+this.bdate;
    }
}