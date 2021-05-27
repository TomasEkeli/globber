# Globber

got tired of not having to jump through hoops to test glob patterns on windows. this is a console
application called "globber" that takes a glob pattern and returns the files that match in the current
directory.

## how to build

download the code and buid it (you need the [dotnet sdk](https://dotnet.microsoft.com/download))

the simplest way is to run the following command (will build for windows x64 to a directory `out`)

```
dotnet publish -o out
```

i think most other platforms already have glob testers - so why would you even want this there?

take the `globber.exe` -file from `out` and put it somewhere on your path to get to use it from anywhere.


## how to use
you can use it like

```cmd
c:\temp> globber.exe *.md
```
to list all *.md files in temp.

or
```cmd
c:\somewhere> globber.exe *.md c:/temp
```

to do the same from the somwehere directory.

```cmd
c:\temp> globber.exe **/*.md
```

to get all *.md files under temp and any subdirectories

see [http://en.wikipedia.org/wiki/Glob_(programming)] for more info on globs

## dependencies

uses [dotnet glob](https://github.com/kthompson/glob/) and [powerargs](https://github.com/adamabdelhamed/powerargs)


