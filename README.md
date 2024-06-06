# Who is this for?
This application is specifically for astro photographers.
Since a beginner usually isn't decked out with a tracking mount, means to create proper flats or a red flashlight, the android app is recommended for it's feature set specifically addressing these "hardware issues" for field-use. 

Not even more advanced amateurs might be able to say off-the-cuff which focal length they'd need to nicely fit their desired subject into the frame let alone beginners, that worry is also taken care of by the app.

------------------------------------------
# What can it do?
> ***NOTE:** There are differences in each version's capabilities and feature set, e.g. there's no need for field-use features on the desktop client*

Every version contains all formulae and accepts your setup's specifications as Inputs.
It will then proceed to present you the requested results.

As of now only the Android client offers a fully functional profile system, this feature will soon be implemented into the other versions as well. Of course it will be integrated into every ported client version too.

------------------------------------------
# What can each version do specifically?
### Windows CLI
The CLI client was the very first iteration and features a basic menu system, by entering one of the shown options you'll get to the actual features.

It can calculate the longest exposure time for light frames with the wanted amount of star-trailing and will present the results of an approximational "Rule of 300", the old "Rule of 500" for reference as well as the simplified and the full NPF 
rules which both were developed by Frédéric Michaud from the Société Astronomique du Havre (SAH) - Thanks for the extraordinarily friendly permission to use them. 
After calculating it will give you the results in seconds (unit symbol: s ).

Also integrated is the capability to calculate the respective field of view along your sensor's (and thereby frame) short and long edge as well as the sensor's diagonal in relation to your focal length and sensor dimensions. 
These results will be presented in degrees (unit symbol: ° ).

#### Lore
- Since it only requires the command line and some minor processing power for the maths to work, it should run on any compatible Windows system no matter how weak the hardware is
- Will likely get ported to Linux first due console/terminal-based functionality 
- rumor has it that a "Back" option is soon to be implemented
#### To-Do:
- fix the menu ("back" option)
- port to and test on linux
- find a way to port to and test on macOS


### Windows GUI
The GUI client can do everything the CLI client can do but puts a more comfortable user experience and less crude menu options in front of the maths instead of the CLI client's little black window.
Additionally the "Rule of 300" approximation is now a "Rule of your custom integer number" though 260 for full frame and 350 for APS-C crop cameras seem to be the most accurate ones that one can still easily memorise.

As of now you can already save sensor profiles but not read them in again, so in the near future you won't have to type in the dimensions each time you start the application.

#### Lore
- the Unity version was ugly, clunky and barely usable, it now got wiped and the all-new and improved version is currently WiP
- the Qt port is discontinued but for now still available for download to provide *some* desktop client
#### To-Do:
- rebuild the entire thing
- set up the basic profile system working
- port to and test on Linux
- find a way to port to and test on macOS/Apple chips


### Android
The Android client is (for now) the only version meant for the use in the field. Additionally to the calculations it features a mostly red UI that serves as an red flashlight and a function to cast a solid white across the screen for taking flats, both of these special features work best when the phone's (or tablet's) screen is set to full brightness.

#### Lore
- with update _beta-v0.4.5_ the UI's entire look and feel has got a complete makeover 
- you can save and load your camera/sensor specifications into and out of the profile system from version _beta-v0.4.5_ onwards
#### To-Do:
- get/make some proper button Icons going
- find a way to port to and test on iOS

------------------------------------------
# Current Roadmap
> ***NOTE:** Version numbers that go unmentioned on the roadmap will contain only minor changes to the last mentioned version for that operating system*
## June
### Android v0.4.6
- [✓] ~Complete Overhaul~ 
- [✓] ~adding basic profile system~ 
### WinGUI v0.4.4
- [✓] ~full wipe of previously built apps~ 
- [ ] complete rebuild
  - [ ] of base functions
  - [ ] of basic GUI
### WinCLI v0.0.0
- [ ] completing menus

## July
### Android v0.5.0
- [ ] polishing GUI
- [ ] improving profile system
  - [ ] by including quick saving/loading
  - [ ] and stream-lining normal saving/loading
    - [ ] e.g. adding a remove button for saved profiles
### WinGUI v0.4.6
- [ ] implementation of basic profile system
- [ ] polishing GUI
### WinCLI v0.0.0
- [ ] check code for refactoring 
- [ ] starting the Linux port

## August
### Android v0.5.1
- [ ] fixing bugs
- [ ] further polishing
- *maybe I can get my hands on iOS hardware*
  - *if acquired: prepare iOS port*
### WinGUI v0.5.0
- [ ] polishing GUI
- [ ] improving profile system
  - [ ] by including quick saving/loading
  - [ ] and stream-lining normal saving/loading
- [ ] starting the Linux port
### WinCLI v0.0.0
- [ ] finished
### LinuxCLI v0.0.0
- [ ] fix possible issues from port
- [ ] if necessary populate for various distros
- [ ] finished

------------------------------------------
# Special Thanks
As mentioned before I want to thank especially Frédéric Michaud for permitting the use of his formulae.

And I also want to thank my long-term fiancée Nina for enduring my constant oversharing on the project and for bringing snacks when I forgot to eat again
