using System;

interface IBaseClass1
{
    void Method1();
}

interface IBaseClass2
{
    void Method2();
}

class BaseClass1 : IBaseClass1
{
    public BaseClass1()
    {
        Console.WriteLine("This is BaseClass1");
    }

    public void Method1()
    {
        Console.WriteLine("Method1 from BaseClass1");
    }
}

class BaseClass2 : IBaseClass2
{
    public BaseClass2()
    {
        Console.WriteLine("This is BaseClass2");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 from BaseClass2");
    }
}

class DerivedClass : BaseClass1, IBaseClass2
{
    public DerivedClass() : base()
    {
        Console.WriteLine("This is DerivedClass");
    }

    // กำหนดการใช้งาน Method2 ของ IBaseClass2 ที่ DerivedClass ไม่ได้สืบทอดโดยตรง
    public void Method2()
    {
        Console.WriteLine("Method2 from DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();  // การสร้างออบเจกต์
        dc.Method1();  // เรียก Method1 จาก BaseClass1
        dc.Method2();  // เรียก Method2 จาก DerivedClass
    }
}
