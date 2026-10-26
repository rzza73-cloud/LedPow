# LedPow

A small WPF .NET project for experimenting with LED-style text using a canvas of simulated LEDs.

The idea is to render uppercase ASCII letters as a pattern of lit LED pixels, similar to a digital display. The project is still in an early stage, but the foundation is already in place:

- a `Led` class for individual LED cells
- a `LedStrip` class for grouping LEDs
- a `MainWindow` that creates a grid of strips on a canvas

## Current status

This project is intentionally a prototype. It does not yet fully render letters, but the structure is ready for expanding toward:

- ASCII uppercase font patterns
- LED matrix rendering
- letter animation or scrolling text
- custom brightness / color effects

## Project structure

- `LedPow/MainWindow.xaml` — window layout
- `LedPow/MainWindow.xaml.cs` — app startup and LED strip creation
- `LedPow/Led.cs` — single LED behavior and visual state
- `LedPow/LedStrip.cs` — collection of LEDs for one strip
- `LedPow/LedPow.csproj` — project configuration

## Run the app

1. Open `LedPow.slnx` in Visual Studio.
2. Restore NuGet dependencies if prompted.
3. Build the solution.
4. Run the app.

## Planned next steps

- define a font map for uppercase letters
- convert characters into LED coordinates
- draw letters on the canvas using the existing LED grid
- add adjustable spacing, colors, and animation timing

## Example concept

A future version could display text like this:

```
  ███  ███  ███  ███  ███  ███  ███  ███
  █ █  █ █  █     █  █ █  █ █  █  █ █
  █ █  █ █  █     █  █ █  █ █  █  █ █
  █ █  ███  ███   █   ███  ███  ███
  █ █  █ █     █  █   █ █  █ █  █ █
  █ █  █ █     █  █   █ █  █ █  █ █
  ███  ███  ███  ███   ███  ███  ███
```

This README will continue to evolve as the LED letter rendering logic is implemented.
