# Visual Studio-ready project template for BFLAT C#

## Where it works?

* **Visual Studio 2026 (Create new project)**
* **Dotnet CLI (dotnet new bflat)**
* **Maybe something other compatible with** ```dotnet new install Template```

## What does that template?

* Visual Studio UI-based setting-up of BFLAT parameters (when creating)
* F5 out-of-the-box
* Clean .csproj (you can re-setting everything you set when created the project)
* Intellisense out-of-the-box

## What I must do to use this template?

1. Download [BFLAT](https://github.com/bflattened/bflat) *anywhere* on your PC
2. Add BFLAT directory as ```BFLAT_BIN``` in Environment Variables
3. Add BFLAT directory or ```%BFLAT_BIN%```\bflat.exe in ```%PATH%``` Environment Variable
4. Download or clone this repo
5. Run ```dotnet new install Template``` in root of this repository
6. **Make sure that there's no warning or errors from dotnet**
7. Open Visual Studio and be happy!

## I have troubles with using of this template, what can I try to do?

### ---Visual studio troubles---

1. **Start button shows "Start" instead of "BFlat_Native"**
	- If you accidently deleted ```Properties\launchSettings.json``` or builded not through VisualStudio - try to rebuild
2. **Intellisense doesn't work**
	- Usually it's trouble with Visual Studio that it don't see your ```%PATH%``` (or bflat inside it) and/or ```%BFLAT_BIN%```
3. **"Executable doesn't exist" when trying to run**
	- Usually it's trouble with ```Properties\launchSettings.json```:
		- As first - try rebuild;
		- As second (if first does nothing) modify .csproj (remove generation of JSON) and ```launchSettings.json``` (set absolute literal path without macroses)
4. **Build fails with "bflat is not recognized"**
	- Visual Studio don't see ```bflat.exe``` in your ```%PATH%```. If it works in CMD, but not in VS - try to add in system ```%PATH%```

### ---Dotnet CLI troubles---

1. **Template not found**
	- Try to run ```dotnet new uninstall Template``` in root, resign account, run ```dotnet new install Template``` in root

### ---Windows troubles---

1. **Environment Variables not applying**
	- Windows sometimes can't do "hot reload", so you need to try resign in account or restart windows.
2. **Execution Policy**
	- If you decide to add any helper scripts (.ps1), remind users to run Set-ExecutionPolicy RemoteSigned for their shell.
3. **Path too long**
	- Windows has a 260-character limit for paths. If your project is deep in folders, bflat or launchSettings might fail.
	- Enable Long Paths in Windows Registry or move your project closer to the drive root (e.g., C:\Users\\..\source)