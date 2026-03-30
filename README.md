# 🧮 Calculator Engine

A console-based calculator built with C# and .NET, following clean structure, interface-based design, and unit testing principles.

---

## 🚀 Features

* Basic operations: +, -, *, /
* Advanced operations: Power, Square Root, Modulus
* Error handling (e.g., divide by zero)
* Input validation
* Calculation history
* Unit tested with xUnit

---

## 📁 Project Structure

* `CalculatorEngine` → Main calculator (logic + console UI)
* `CalculatorEngine.Tests` → Unit tests
* `CalculatorEngine.OperationsRunner` → Demonstrates polymorphism using `IOperation`

---

## ▶️ How to Run

### Run Calculator

```bash
cd CalculatorEngine
dotnet run
```

### Run Operations (Polymorphism Demo)

This project contains:

* `IOperation` interface
* `AddOperation`
* `MultiplyOperation`

It demonstrates how multiple implementations can be executed through a single interface.

```bash
cd CalculatorEngine.OperationsRunner
dotnet run
```

---

## 🧠 Concepts Used

* Interfaces & Abstraction
* Polymorphism
* Clean structure
* Unit testing
