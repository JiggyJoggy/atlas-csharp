#!/usr/bin/env bash
name="0-new_project"
mkdir "$name"
cd "$name"
dotnet new console -n "$name"
