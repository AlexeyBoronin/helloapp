using mylib;

Human ted=new("Ted");
ted.Print();

class State
{
    string defaultVar = "default";//private
    private string privateVar = "private";
    protected private string protectedprivateVar = "protected private";
    protected string protectedVar = "protected";
    internal string internalVar = "internal";
    protected internal string protectedinternalVar = "protected internal";
    public string publicVar = "public";
    

    void Print() => Console.WriteLine(defaultVar);//private
    private void PrintPrivate() => Console.WriteLine(privateVar);
    protected private void PrintProtectedPrivate() => Console.WriteLine(protectedprivateVar);
    protected void PrintProtected() => Console.WriteLine(protectedVar);
    internal void PrintInternal() => Console.WriteLine(internalVar);
    protected internal void PrintProtectedInternal() => Console.WriteLine(protectedinternalVar);
    public void PrintPublic() => Console.WriteLine(publicVar);
}
class StateConsumer
{
    public void PrintState()
    {
        State state = new State();
        //переменные
        Console.WriteLine(state.defaulVar);//нет доступа т.к. модификатор private
        Console.WriteLine(state.privateVar);//нет доступа т.к. модификатор private
        Console.WriteLine(state.protectedprivateVar);//нет доступа т.к. класс StateConsumer не наследник State
        Console.WriteLine(state.internalVar);//доступ есть, т.к. классы находятся в одной сборке
        Console.WriteLine(state.protectedinternalVar);//доступ есть, т.к. находится в одном проекте
        Console.WriteLine(state.publicVar);
        //методы
        state.Print();//нет доступа т.к. модификатор private
        state.PrintPrivate();//нет доступа т.к. модификатор private
        state.PrintProtectedPrivate();//нет доступа т.к. класс StateConsumer не наследник State
        state.PrintProtected();//нет доступа т.к. класс StateConsumer не наследник State
        state.PrintInternal();//доступ есть, т.к. классы находятся в одной сборке
        state.PrintProtectedInternal();//доступ есть, т.к. находится в одном проекте
        state.PrintInternal();
        state.PrintPublic();
    }
}