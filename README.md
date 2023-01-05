# dotnet-tool-starterkit
Starter kit for dotnet tools on the cli. 

## Installation (linux)
Already implements a statically typed implementation of the chuck norris api

Install by running `./install-tool.sh`

Update the tool by running `./update-tool.sh`

Make sure ~/.dotnet/tools/ has been added to your $PATH on linux

The same script can be used for updating the tool if it is extended with further functionality.

## Installation (windows)
WIP


## Useage
Adding more commands is as simple as adding a new argument in Program.cs and an if-statement checking for it.
For example, to invoke the chucknorris api invoke this tool with the following parameter

```bash
chucknorris fetch
```

which matches this if-statement from Program.cs

```csharp
if (arguments == "fetch")
{
    RandomApi randomApi = new RandomApi();
    await randomApi.CallApi();
}
```

To rename the name of the tool simply edit the property *ToolCommandName* in the .csproj file

```
    <ToolCommandName>chucknorris</ToolCommandName>
```
