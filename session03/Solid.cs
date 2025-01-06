using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session03;

/***
 * 
	SOLID - OOP
	    Single Responsibility Principle		- SRP
	    Open/Closed Principle				- OCP
	    Linskov Subsititution Principle		- LSP
	    Interface Segregation Principle		- ISP
	    Dependency Inversion Principle		- DIP   

    DRY - Dont Repeat Yourself
    YAGNI - You ain't gonna need it
    KISS - Keep it simple, Stupid

*/

//SRP ❌
public class ReportManager
{
	public void GenerateReport()
	{
		//
	}
	public void SendEmail()
	{
		//
	}
}

//SRP ✔️
public class ReportGenerator
{
    public void GenerateReport()
    {
        //
    }
}

public class EmailSender
{
	public void SendEmail()
	{
	}
}


// OCP ❌
public class ReportGenerator2
{
    public void GenerateReport(string type)
    {
        if(type == "PDF")
		{
			//
		}
		if(type == "Excel"){
			//
		}
    }
}

// OCP ✔️
public interface IReportGenerator
{
	void GenerateReport();
}

public class PdfReportGenerator : IReportGenerator
{
    public void GenerateReport()
    {
        //
    }
}

public class ExelReportGenerator : IReportGenerator
{
    public void GenerateReport()
    {
       //
    }
}

public class XMLReportGenerator : IReportGenerator
{
    public void GenerateReport()
    {
        //
    }
}


//LSP ❌
public class Bird
{
	public virtual void Fly()
	{

	}
}

public class Hen : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }
}


public class LSPSample
{
	public void DoSomething(Bird b)
    {
		b.Fly();
    }

    public LSPSample()
    {
        this.DoSomething(new Bird());
        this.DoSomething(new Hen());
    }
}


//LSP ✔️
public class Bird_
{
}

public class Crow : Bird_
{
    public void Fly()
    {
        //
    }
}


//ISP ❌
public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class HumanWorker : IWorker
{
    public void Eat()
    {
        //
    }

    public void Sleep()
    {
        //
    }

    public void Work()
    {
        //
    }
}

public class RobotWorker : IWorker
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        //
    }
}


//ISP ✔️
public interface IWorkable
{
    void Work();    
}
public interface IEatable
{
    void Eat();
}
public interface ISleepable
{
    void Sleep();
}



public class HumanWorker_ : IWorkable, IEatable, ISleepable
{
    public void Sleep()
    {
        //
    }

    public void Work()
    {
        //
    }

    void IEatable.Eat()
    {
        //
    }
}

public class RobotWorker_ : IWorkable
{
    public void Work()
    {
        //
    }
}

//DIP
//Later


//Refactoring


public class Solid
{
}
