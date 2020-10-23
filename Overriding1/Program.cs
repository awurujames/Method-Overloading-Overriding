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