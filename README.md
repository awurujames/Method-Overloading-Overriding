# Method-Overloading-Overriding

Method Overloading is the common way of implementing polymorphism. C# can distinguish the methods with different method signatures. i.e. the methods can have the same name but with different parameters list (i.e. the number of the parameters, order of the parameters, and data types of the parameters) within the same class.

Overloaded methods are differentiated based on the number and type of the parameters passed as arguments to the methods.
You can not define more than one method with the same name, Order and the type of the arguments. It would be compiler error.
The compiler does not consider the return type while differentiating the overloaded method. But you cannot declare two methods with the same signature and different return type. It will throw a compile-time error. If both methods have the same parameter types, but different return type, then it is not possible.
Why do we need Method Overloading ??

If we need to do the same kind of the operation in different ways i.e. for different inputs. In the example described below, we are doing the addition operation for different inputs. It is hard to find many different meaningful names for single action.

Different ways of doing overloading methods-
Method overloading can be done by changing:
?
The number of parameters in two methods.
The data types of the parameters of methods.
The Order of the parameters of methods.
By changing the Number of Parameters

                    METHOD OVERRIDING

Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class. Creating a method in the derived class with the same signature as a method in the base class is called as method overriding.
In simple words, Overriding is a feature that allows a subclass or child class to provide a specific implementation of a method that is already provided by one of its super-classes or parent classes. When a method in a subclass has the same name, same parameters or signature and same return type(or sub-type) as a method in its super-class, then the method in the subclass is said to override the method in the super-class. Method overriding is one of the ways by which C# achieve Run Time Polymorphism(Dynamic Polymorphism).

The method that is overridden by an override declaration is called the overridden base method. An override method is a new implementation of a member that is inherited from a base class. The overridden base method must be virtual, abstract, or override.

class base_class
{
public void gfg();
}

class derived_class : base_class
{
public void gfg();
}

class Main_Method
{
static void Main()
{
derived_class d = new derived_class();
d.gfg();
}
}

Here the base class is inherited in the derived class and the method gfg() which has the same signature in both the classes, is overridden.

In C# we can use 3 types of keywords for Method Overriding:

virtual keyword: This modifier or keyword use within base class method. It is used to modify a method in base class for overridden that particular method in the derived class.
override: This modifier or keyword use with derived class method. It is used to modify a virtual or abstract method into derived class which presents in base class.
class base_class
{
public virtual void gfg();
}

class derived_class : base_class
{
public override void gfg();
}
class Main_Method
{
static void Main()
{
derived d_class = new derived_class();
d.gfg();

      base_class b = new derived_class();
        b.gfg();

}
}
Here first, d refers to the object of the class derived_class and it invokes gfg() of the class derived_class then, b refers to the reference of the class base and it hold the object of class derived and it invokes gfg() of the class derived. Here gfg() method takes permission from base class to overriding the method in derived class.
