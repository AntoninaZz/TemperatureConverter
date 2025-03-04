# Temperature Converter (Windows Forms Application)

## Description
This project is a **Windows Forms Application** for converting temperatures between **Celsius, Fahrenheit, and Kelvin**. Users can select the input and output temperature scales and enter a value to convert.

## Features
- Convert temperatures between **Celsius (°C), Fahrenheit (°F), and Kelvin (K)**
- User-friendly Windows Forms interface
- Error handling for invalid input
- Instant selection and conversion functionality

## Technologies Used
- **C#** for core logic
- **Windows Forms (WinForms)** for graphical user interface
- **Event-driven programming** for UI interaction

## Key Methods
- `ConvertTemp(int Temp)` - Performs temperature conversion based on selected scales
- `txtTemp_TextChanged(object sender, EventArgs e)` - Updates the temperature value
- `btnConvert_Click(object sender, EventArgs e)` - Triggers conversion process
- `btnExit_Click(object sender, EventArgs e)` - Closes the application
