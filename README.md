🔢 Recursive GCD Calculator (C#)

A minimal, clean, and efficient implementation of the Euclidean Algorithm for computing the
Greatest Common Divisor (GCD) of two integers using recursion in C#.

This project is ideal for practicing recursion, algorithms, numerical computation, and building simple console applications.


---

✨ Features

✔️ Fully recursive implementation of the Euclidean Algorithm

✔️ Supports both positive and negative integers

✔️ Input validation and error handling

✔️ Clean, readable, and well-structured C# code

✔️ Perfect for learning or academic projects



---

🧠 Algorithm Concept (Recursive Euclid)

The Euclidean Algorithm is based on a simple mathematical rule:

> GCD(a, b) = GCD(b, a % b)
And if b equals zero:
GCD(a, 0) = a



This makes recursion a natural fit for implementing GCD.


---

🧩 Project Structure

📁 RecursiveGCD
 ├── Program.cs      // Entry point (Main)
 └── README.md        // Project documentation


---

📌 Core Recursive Function

static long Gcd(long a, long b)
{
    if (b == 0) 
        return a;
    return Gcd(b, a % b);
}


---

▶️ How to Run

Requirements

.NET SDK 6 or later


Execute the program

dotnet run

The program will prompt you to enter two integers and will display the computed GCD.


---

🧪 Sample Execution

Input:

First number: 120
Second number: 84

Output:

GCD(120, 84) = 12


---

📚 Why Use Recursion?

Produces clean and elegant code

Follows the mathematical definition of the Euclidean Algorithm

Helps strengthen understanding of recursive problem-solving

Great for academic and demonstration purposes



---

🛠️ About

This project was created for learning purposes and to demonstrate recursive algorithm design in C#.
If you’d like to extend it with a GUI, multi-number GCD, or a comparison between recursive and iterative performance, feel free to ask!

