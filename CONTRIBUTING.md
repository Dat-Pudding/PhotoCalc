# How to contribute
There is a difference in development environment between for example the CLI client and the GUI clients. Because of that setting up the development environment for the version you want to contribute to will differ depending on the version/port.

|<h2>Table of contents</h2><ul><li>[Downloading the project](#downloading-the-project)</li><li>[Setting up the development environment](#setting-up-the-development-environment)</li><ul><li>[Setting up for WinCLI](#WinCLI-Setup)</li><li>[Setting up for WinGUI](#WinGUI-Setup)</li><li>[Setting up for Android](#Android-Setup)</li></ul><li>[Contributing](#contributing)</li></ul>|
|:----------------|


---

## Downloading the project
It's rather simple and straightforward:
1. Fork this repository 
2. Clone it onto your machine
3. Select the branch you want to contribute to on your Git client

---

## Setting up the development environment 
Jump right to the relevant setup process for you:
- [Setting up for WinCLI](#WinCLI-Setup)
- [Setting up for WinGUI](#WinGUI-Setup)
- [Setting up for Android](#Android-Setup)

### WinCLI Setup
blabla

### WinGUI Setup
blabla

### Android Setup
Since the Android version is built in the Unity engine there are some requirements to be fulfilled first (like installing Unity and Microsoft Visual Studio)

1. If not already installed, download and install the unity hub
2. Within then unity hub choose the most recent LTS version (as of now 2022.3)
3. import `{yourRepoPath}/PhotoCalc/unity_source/PhotoCalc Mobile/` as project into unity
4. Open the project through the Unity Hub
5. Make sure that the Scene named `GUI` is being shown in the hierarchy to your left
6. Navigate to `Assets/Scripts/` and double-click any C#-Script, you will be prompted to install MSVS or MSVSC.

After installing the IDE or setting up your unity Editor to use your own IDE you're good to go.

---

## Contributing 
Please stick to a couple of habits when committing pushes to your fork

- the commit summary has to be `[roughly what you did]``[which general area you worked on]
> **Example:** *fixed button in side bar*

- the commit description has to describe the worked-on details in key points 
> **Example:** *- drop-down list will refresh upon leaving camDbPage*