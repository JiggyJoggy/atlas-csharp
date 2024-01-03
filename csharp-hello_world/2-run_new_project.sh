#!/usr/bin/env bash
dotnet new console -n "0-new_project"
dotnet build "0-new_project"
cd "0-new_project"
dotnet run "0-new_project"
