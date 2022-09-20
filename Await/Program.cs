﻿using System.Runtime.CompilerServices;
public static class BoolExtensions
{
    public static BoolAwaiter GetAwaiter(this bool value) => new BoolAwaiter(value);
}

public class BoolAwaiter : INotifyCompletion
{
    private readonly bool _value;
    public BoolAwaiter(bool value) => _value = value;

    public bool IsCompleted => true;
    public void OnCompleted(Action continuation) { } 
    public bool GetResult() => _value;
}
class Program
{
    public static async Task Main (String [] args)
    {
        await (await await false && await true);
    }
}

