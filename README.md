
# Car Production Program

## Overview
This C# console application allows users to create and manage car objects. Users can input various details about the car, including its serial number, brand, model, color, and the number of doors. The program continues to prompt the user for additional car entries until they choose to exit.

## Features
- User-friendly prompts for car details.
- Error handling for input validation, especially for the number of doors.
- Option to continue creating new cars or exit the program.
- Stores created car objects in a list for potential future use.

## Requirements
- .NET Framework or .NET Core installed.
- A C# compatible development environment (e.g., Visual Studio, Visual Studio Code).

## Usage
1. Run the application.
2. When prompted, enter 'e' to create a car or 'h' to exit.
3. Follow the prompts to input the car's details:
   - Serial number
   - Brand
   - Model
   - Color
   - Number of doors (must be a valid integer)
4. After creating a car, you will be asked if you want to create another car. Enter 'e' to continue or 'h' to exit.

## Code Structure
- **Program Class**: Contains the main logic for user interaction and car creation.
- **Araba Class**: Represents a car with properties like production date, serial number, brand, model, color, and the number of doors.

## Example
```
Araba uretmek ister misiniz? Eger cevabiniz evetse 'e', hayirsa 'h' harfine basiniz.
e
Arabaniz uretilmeye basladi..
Arabanizin seri numarasini giriniz: ABC123
Arabanizin markasini giriniz: Toyota
Arabanizin modelini giriniz: Corolla
Arabanizin rengini giriniz: Mavi
Arabanizin kapi sayisini giriniz: 4
Baska araba uretmek istiyor musunuz? Eger cevabiniz evetse 'e', hayirsa 'h' harfine basiniz.
h
Araba uretimi yapilmiyor..
```

## Notes
- Ensure valid input for the number of doors. The application will prompt you again if an invalid input is entered.
- The program does not persist data after exit; each run is independent.
