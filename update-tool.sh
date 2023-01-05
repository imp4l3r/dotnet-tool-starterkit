#!/bin/bash

dotnet pack

dotnet tool update printer --global --add-source ./nupkg --version 1.0.0