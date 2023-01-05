# dotnet-tool-starterkit
Starter kit for dotnet tools on the cli. 

## Installation (linux)
Already implements a statically typed implementation of the chuck norris api

To install the tool go to the dotnet-tool-starterkit directory and execute the `scriptwrapper.sh` script by invoking it with the following arguments:

```bash
./scriptwrapper.sh install
```

To update the tool after having made modifications to it run the following script
```bash
./scriptwrapper.sh update
```

Make sure ~/.dotnet/tools/ has been added to your $PATH on linux


## Installation (windows)
- [ ] TODO Write ScriptWrapper in powershell
- [ ] TODO Write Install tool script  
- [ ] TODO Write Update tool script  


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
