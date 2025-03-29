DerivedClass dc = new DerivedClass();
dc.PrintBaseHello();

class BaseClass
{
    public string Hello = "Hello From BaseClass";
}
class DerivedClass : BaseClass
{
    new public string Hello = "Hello From DerivedClass";

    public void PrintBaseHello()
    {
        string BaseHello = base.Hello;       // ใช้งานสมาชิกใน base class โดยคีย์เวิร์ด base
        System.Console.WriteLine(BaseHello);
    }
}