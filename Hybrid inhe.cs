using System;

namespace Inheritance Demo

class Device

public string DeviceName { get; set; }

public void Display DeviceInfo()

Console.WriteLine($"Device Name: (DeviceName)");

interface ICanPrint

void Print();

interface ICanScan

void Scan(); }

class Printer: Device, ICanPrint

public void Print()

Console.WriteLine("Printing document.");

1

class Scanner: Device, ICanScan

public void Scan()

Console.WriteLine("Scanning document.");

class Multifunction Printer: Device, ICanPrint, ICanScan

1

public void Print()

1 Console.WriteLine("Multifunction Printer is printing.");

1

public void Scan()

Console.WriteLine("Multifunction Printer is scanning.");

1

internal class Program

static void Main(string[] args)

Printer printer new Printer (DeviceName = "HP LaserJet" }; printer Display DeviceInfo();

printer.Print();

Scanner scanner = new Scanner { DeviceName "Canon ScanJet" ); scanner Display DeviceInfo();

scanner.Scan();

mfp.Display DeviceInfo();

Multifunction Printer mfp = new Multifunction Printer (DeviceName = "Vivo User" );

mfp.Print();

mfp.Scan();

Console.ReadLine();
}}}
