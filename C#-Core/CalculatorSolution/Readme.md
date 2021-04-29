# Calculator Project

### Short Introduction
This Project was built as part of the C#SDET course from Sparta Global. The primary aim is to build an integer calculator with at least basic arithmetic functions, attached to buttons, much like a regular calculator. 

## Contents

1. [CalculatorApp](# CalculatorApp)
	1. [Grid](# MathLib)
	2. [Number Buttons](# MathLib)
	3. [Other Functional Buttons](# MathLib)
	4. [Parsing String](# MathLib)
	5. [Calculate Method](# MathLib)
	6. [Testing](# MathLib)
	
2. [MathLib](# MathLib)
    1. [Addition](# Addition)
    1. [Subtraction](# Subtraction)
    1. [Multiplication](# Multiplication)
    1. [Division](# Division)
    2. [Modulus](# Modulus)
    2. [Testing](# MathLibTesting)

3. [Retrospective](# CalculatorApp)
	1. [Final Product](# MathLib)
	2. [Testing](# MathLib)
	3. [Review](# MathLib)


## MathLib  
This is a static class containing all of the arithmetic functions.

#### Addition
```csharp
public static int Add(int a, int b)
        {
            return a + b;
        }
```
#### Subtraction
```csharp
public static int Subtract(int a, int b)
        {
            return a - b;
        }
```

#### Multiplication
```csharp
public static int Multiply(int numA, int numB)
        {
            return numA*numB;
		}	
```

#### Division
```csharp
public static int Divide(int numA, int numB)
        {
            return numA / numB;
        }
```

#### Modulus
```csharp
public static int Modulus(int numA, int numB)
        {
            return numA % numB;
        }
```

## Calculator App
[CalculatorImage](Images/CalculatorImage)