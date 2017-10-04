csc.exe /t:exe /reference:System.Core.dll /out:closure.exe Program.cs

@echo off

if errorlevel 1 (
    pause
    exit
)

start closure.exe