# How to contribute
There is a difference in development environment between for example the CLI client and the GUI clients. Because of that setting up the development environment for the version you want to contribute to will differ depending on the version/port.

## For first-timers:
Don't worry if this is your first time contributing, just focus on the issues labeled `good first issue` and feel free to ask potential questions in the issue comments of the issue you want to work on.
I try my best to keep the repository, the issues and the code beginner-friendly and readable should nonetheless any questions arise feel free to ask away.


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
> Will come later down the line
Since it's technically almost complete the integration of the full project for contributions is not a priority right now. First the desktop GUI-client needs to be re-instantiated.

### WinGUI Setup
> Will come later this month
Since there currently is no desktop GUI-client being worked on you cannot contribute to this branch

### Android Setup
Since the Android version is built in the Unity engine there are some requirements to be fulfilled first (like installing Unity and Microsoft Visual Studio)

1. If not already installed, download and install the unity hub
2. Within then unity hub choose the most recent LTS version (as of now 2022.3)
3. import `{yourRepoPath}/PhotoCalc/unity_source/PhotoCalc/` as project "from disk" into Unity Hub
4. Open the project through the Unity Hub
5. In the unity Editor navigate to `Assets/Scenes` and open the Scene named `GUI` with a double-click
6. Unity will prompt you to install `TMPro`, in that pop-up just select "TMPro Essentials"
7. In the Unity Editor navigate to `Assets/Scripts/` and double-click any C#-Script, you should be prompted to install MS Visual Studio or Visual Studio Code.

After installing the IDE or setting up your unity Editor to use your own IDE you're good to go.

---

## Contributing 
Please stick to a couple of habits when committing pushes to your fork. And be explicit with your naming in code for all things like `variables`, `functions/methods`, `classes/structs` et cetera.

- the commit summary has to be `[roughly what you did]` `[which general area you worked on]`
> **Example:** *fixed non-working buttons in side bar*

- the commit description has to describe the worked-on details in key points
- the description also has to directly address the issues it's resolving
> **Example:** *- drop-down list will refresh upon leaving camDbPage* **and in the next line** *- resolves issue #123*

Besides that just make sure you only ever commit towards the specific branch you have been working on and only ever set a PR to that specific branch. Do Not open a PR to master as these PRs will likely just be closed.
