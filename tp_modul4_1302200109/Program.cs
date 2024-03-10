// See https://aka.ms/new-console-template for more information
using System;

// Interface untuk state
public interface State
{
    void Open();
    void Lock();
}

// Implementasi state terkunci
public class LockedState : State
{
    public void Open()
    {
        Console.WriteLine("Pintu terkunci.");
    }

    public void Lock()
    {
        Console.WriteLine("Pintu sudah terkunci.");
    }
}

// Implementasi state terbuka
public class UnlockedState : State
{
    public void Open()
    {
        Console.WriteLine("Pintu sudah terbuka.");
    }

    public void Lock()
    {
        Console.WriteLine("Pintu dikunci.");
    }
}

public class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        // State awal adalah terkunci
        currentState = new LockedState();
    }

    public void ChangeState(State newState)
    {
        currentState = newState;
    }

    // Method untuk membuka pintu
    public void Open()
    {
        currentState.Open();
    }

    // Method untuk mengunci pintu
    public void Lock()
    {
        currentState.Lock();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();

        // Pintu awalnya terkunci
        doorMachine.Open(); // Output: Pintu terkunci. Tidak bisa dibuka.

        // Membuka pintu
        doorMachine.ChangeState(new UnlockedState());
        doorMachine.Open(); // Output: Pintu sudah terbuka.

        // Mengunci pintu
        doorMachine.Lock(); // Output: Pintu dikunci.
        doorMachine.Open(); // Output: Pintu terkunci. Tidak bisa dibuka.
    }
}
