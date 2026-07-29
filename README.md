# Artificial Neural Networks Project

A Windows Forms application that demonstrates a basic artificial neural network for recognizing manually entered 5x7 pixel letter patterns.

## Overview

This project is implemented in C# with .NET 7 (`net7.0-windows`) and includes:

- A clickable 5x7 grid (35 inputs) for drawing a character pattern.
- Recognition flow for the letters **A, B, C, D, E**.
- Configurable training parameters from the UI:
  - Error threshold (`Hata Oranı`)
  - Learning rate (`Öğrenme Oranı`)
  - Momentum (`Momentum Oranı`)
- Support for:
  - Generating random weights
  - Saving generated weights to text files
  - Loading weights from text files and evaluating inputs

## Project Structure

- `/WinFormsApp1/WinFormsApp1.sln` — Visual Studio solution.
- `/WinFormsApp1/WinFormsApp1/WinFormsApp1.csproj` — WinForms project file.
- `/WinFormsApp1/WinFormsApp1/Form1.cs` — UI event handling and user workflow.
- `/WinFormsApp1/WinFormsApp1/YapaySinirAgi.cs` — Neural network logic (forward/backward calculations, weight I/O).

## Requirements

- Windows (WinForms target: `net7.0-windows`)
- .NET 7 SDK

## Running the Application

From the repository root:

```bash
dotnet run --project /home/runner/work/Artificial-Neural-Networks-Project/Artificial-Neural-Networks-Project/WinFormsApp1/WinFormsApp1/WinFormsApp1.csproj
```

Or open `/home/runner/work/Artificial-Neural-Networks-Project/Artificial-Neural-Networks-Project/WinFormsApp1/WinFormsApp1.sln` in Visual Studio and run the project.

## Weight Files

The application reads/writes the following files in its working directory:

- `giris_katmani_agirliklari.txt`
- `ara_katmani_esik_agirliklari.txt`
- `cikis_katmani_esik_agirliklari.txt`
- `cikis_katmani_agirliklari.txt`

## Notes

- UI labels and button text are in Turkish.
- The predefined training patterns in the source correspond to 5 letters: A, B, C, D, E.
