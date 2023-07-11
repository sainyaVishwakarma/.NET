namespace stud;
using person;

public class Student:Person{
    private int m1;
    private string course;

    public Student():base(){
        this.m1=85;
        this.course="dac";
    }

    public Student(int pid,string fn,string ln,string mob,string email,DateTime bdt,int m1,string c):base(pid,fn,ln,mob,email,bdt){
        this.m1=m1;
        this.course=c;
    }

    public int M1{
        get{return this.m1;}
        set{this.m1=value;}
    }

    public string Course{
        get{return this.course;}
        set{this.course=value;}
    }

    public override string ToString(){
        return base.ToString()+" "+this.m1+" "+this.course;
    }
}