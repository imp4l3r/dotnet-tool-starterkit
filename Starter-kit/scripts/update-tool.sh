#!/bin/bash

dotnet pack
dotnet tool update dotnet-tool-starterkit --global --add-source ./nupkg --version 1.0.0
