# LedPow

A small WPF .NET project for building a simple LED-style display.

The goal is to create a compact display made of LED strips that can show changing values over time. The project is still in an early stage and is intended as a prototype for a CRT-like or scanline-style visualizer.

## What this project is about

The current idea is to build a display with multiple LED rows, where time moves horizontally or vertically and each row represents a signal or channel.

This is inspired by older CRT displays and signal traces, where light moves across a line and the pattern shows activity over time.

## Current status

This project is only a starting point. The basic structure is in place:

- a single LED element
- a strip of LEDs
- a canvas-based window that creates LED rows

## Project structure

- `LedPow/MainWindow.xaml` - main window layout
- `LedPow/MainWindow.xaml.cs` - creates the LED structures
- `LedPow/Led.cs` - individual LED behavior
- `LedPow/LedStrip.cs` - group of LEDs in one strip
- `LedPow/LedPow.csproj` - project configuration

## Planned direction

The next steps are to evolve this from a static LED grid into a time-based display:

- create multiple LED rows
- animate data over time
- shift values across the display
- visualize signal-like patterns in a CRT-inspired style
- make it look more like a trace display than a static panel

## Run the project

1. Open `LedPow.slnx` in Visual Studio.
2. Restore dependencies if needed.
3. Build the solution.
4. Run the app.

## Notes

This is a prototype and the design may change as the display behavior is refined. The goal is to keep the project simple, visual, and easy to extend.
