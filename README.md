# Coffee Machine

## Description

The **Coffee Machine** project is a .NET application designed to build a coffee vending machine using the **Test-Driven Development (TDD)** methodology. The project leverages **xUnit** for writing and running tests. The primary goal is to provide a customizable coffee experience while adhering to clean code principles and robust testing practices.

---

## Features

- **Cup Size Selection**:
  - Small: 3 Oz.
  - Medium: 5 Oz.
  - Large: 7 Oz.
- **Sugar Quantity**:
  - Allows users to select the desired number of teaspoons.
- **Notifications**:
  - Displays error messages if cups, sugar, or coffee are unavailable.
- **Final Step**:
  - The machine dispenses the customized coffee cup.

---

## User Story

**As a**: Coffee consumer  
**I want to**: Get a cup of coffee  
**So that I can**: Mitigate sleepiness  

### Acceptance Criteria

1. The user can select one of three cup sizes: Small, Medium, and Large.
2. The user can select the quantity of sugar.
3. Clear messages are displayed if any supplies are missing: cups, sugar, or coffee.

---

## System Components

- **Cups**: Available in three sizes.
- **Coffee Maker**: Provides the required coffee based on the selection.
- **Sugar Dispenser**: Manages the selected quantity of sugar.

---

## How to Run

1. Clone this repository:
   ```bash
   git clone [<repository-url>](https://github.com/rachelyperezdev/MaquinaCafe.git)
   cd MaquinaCafe

+ Ensure you have the .NET SDK installed. You can verify using:
  ```bash
   dotnet --version

+ Build the solution:
  ```bash
   dotnet build

+ Build the solution:
  ```bash
   dotnet build

+ Run the tests using xUnit:
  ```bash
   dotnet test
