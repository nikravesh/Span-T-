# SpanCsvParser

**A high-performance CSV parser in C# using `Span<T>`**

This project demonstrates how to use `Span<T>` to efficiently parse CSV files **without allocating extra memory**, and compares it with the traditional `string.Split` method using BenchmarkDotNet.

---

## Features

* Parse CSV lines using **`Span<T>`** for zero-allocation, high-performance parsing.
* Compare performance with **`string.Split`** using BenchmarkDotNet.
* Safe, memory-efficient, and suitable for **large CSV files**.
* Minimalistic, easy to extend for real-world use cases.

---

##  Project Structure

```
Span.PracticalSample/
 ├── Program.cs          # Benchmark runner
 ├── CsvParser.cs        # Span<T> and string-based parsing
 ├── BenchmarkCsv.cs     # BenchmarkDotNet tests
 └── data.csv            # Sample CSV data
```

---

##  Usage

### 1. Clone the repository

```bash
git clone https://github.com/nikravesh/Span-T-.git
cd SpanCsvParser
```

### 2. Install BenchmarkDotNet

```bash
dotnet add package BenchmarkDotNet
```

### 3. Run the benchmark

```bash
dotnet run -c Release
```

You’ll see a benchmark comparing **Span parsing** vs **string.Split parsing**.

---

## 🔹 Example CSV (`data.csv`)

```
Alice,30,Developer
Bob,25,Designer
Charlie,40,Manager
David,35,Tester
Eve,28,Analyst
```

---

##  Benchmark Example Output

| Method             |   Mean | Allocated |
| ------------------ | -----: | --------: |
| SpanParsing        |  50 ns |       0 B |
| StringSplitParsing | 250 ns |     240 B |

**Result:** `Span<T>` parsing is faster and allocates **no additional memory**, making it ideal for high-performance applications.

---

## 🔹 When to Use Span<T>

* Parsing large CSV, JSON, or log files.
* High-performance applications (finance, IoT, game engines).
* Reducing memory allocations in critical code paths.

---

##  References

* [Span<T> documentation](https://learn.microsoft.com/en-us/dotnet/api/system.span-1)
* [BenchmarkDotNet documentation](https://benchmarkdotnet.org/)

---

💡 This project is designed as a **learning example** and a template for building **high-performance parsers** in .NET.
