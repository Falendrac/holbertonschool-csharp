#!/usr/bin/env bash
# Initialize a new C# project, build and run it
dotnet new console -o 2-new_project
dotnet build 2-new_project
dotnet run --project 2-new_project
