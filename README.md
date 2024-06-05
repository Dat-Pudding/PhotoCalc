# Who is this for?
This application is specifically for astro photographers.
Since a beginner usually isn't decked out with a tracking mount, means to create proper flats or a red flashlight, the android app is recommended for it's feature set specifically addressing these "hardware issues" for field-use. 
Not even more advanced amateurs might be able to say off-the-cuff which focal length they'd need to nicely fit their desired subject into the frame let alone beginners, that worry is also taken care of by the app.

# What can it do?
> ***NOTE:** There are differences in each version's capabilities and feature set, e.g. there's no need for field-use features on the desktop client*

Every version contains all formulae and accepts your setup's specifications as Inputs.
It will then proceed to present you the requested results.

## What can each version do specifically?
### Windows CLI
------------------------------------------
The CLI client was the very first iteration and features a basic menu system, by entering one of the shown options you'll get to the actual features.

It can calculate the longest exposure time for light frames with the wanted amount of star-trailing and will present the results of an approximational "Rule of 300", the old "Rule of 500" for reference as well as the simplified and the full NPF 
rules which both were developed by Frédéric Michaud from the Société Astronomique du Havre (SAH) - Thanks for the extraordinarily friendly permission to use them. 
After calculating it will give you the results in seconds (unit symbol: s ).

Also integrated is the capability to calculate the respective field of view along your sensor's (and thereby frame) short and long edge as well as the sensor's diagonal in relation to your focal length and sensor dimensions. 
These results will be presented in degrees (unit symbol: ° ).

#### Lore
- Since it only requires the command line and some minor processing power for the maths to work, it should run on any compatible Windows system no matter how weak the hardware is
- Will likely get ported to Linux first due to it's simplicity and lack of graphics
- rumor has it that a "Back" option is soon to be implemented

#### To-Do:
- fix the menu ("back" option)
- port to and test on linux
- find a way to port to and test on macOS

### Windows GUI
------------------------------------------
The GUI client can do everything the CLI client can do but puts a more comfortable user experience and less crude menu options in front of the maths instead of the CLI client's little black window.
Additionally the "Rule of 300" approximation is now a "Rule of your custom integer number" though 260 for full frame and 350 for APS-C crop cameras seem to be the most accurate ones that one can still easily memorise.

As of now you can already save sensor profiles but not read them in again, so in the near future you won't have to type in the dimensions each time you start the application.

#### Lore
- the Unity version is quite ugly, clunky and a PITA to work with, the all-new and improved version is currently WiP
- the Qt port is discontinued but for now still available for download

#### To-Do:
- get the profile system working (especially the ListView)
- port to and test on Linux
- find a way to port to and test on macOS/Apple chips

### Android
------------------------------------------
The Android client is (for now) the only version meant for the use in the field. Additionally to the calculations it features a mostly red UI that serves as an red flashlight and a function to cast a solid white across the screen for taking flats, both of these special features work best when the phone's (or tablet's) screen is set to full brightness.

#### Lore
- with _beta-v0.4.5_ the UI overhaul is done
- profile system (saving and loading camera/sensor specs) is available since _beta-v0.4.5_ as well

#### To-Do:
- entering the inputs in the database smoother/less clunky [WiP - almost done]
- get/make some proper button Icons going
- find a way to port to and test on iOS

# Current Roadmap
------------------------------------------
## June
### Android
- ~Complete Overhaul~ ✓
- ~adding basic profile system~ ✓

### WinGUI
- ~full wipe of previously built apps~ ✔
- rebuild of base functions
- rebuild of basic GUI

### WinCLI
- completing menus

## July
### Android
- polishing GUI
- improving profile system
  - by including quick saving/loading
  - and stream-lining normal saving/loading

### WinGUI
- complete rebuild
- implementation of basic profile system
- polishing GUI

### WinCLI
- check code for refactoring 
- starting the Linux port

## August
### Android
- fixing bugs
- further polishing

# Special Thanks
------------------------------------------
As mentioned before I want to thank especially Frédéric Michaud for permitting the use of his formulae.

And I also want to thank my long-term fiancée Nina for enduring my constant oversharing on the project and for bringing snacks when I forgot to eat again
