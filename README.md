# Who is this for?
This application is specifically for freshly starting-out astro photographers while also providing useful features for intermediate amateurs.
Since the average beginner isn't decked out with a tracking mount, means to create proper flats or a red light source for use as a flashlight, the android app is recommended for it's feature set specifically addressing these "hardware issues" for field-use. 
Not even more advanced amateurs might be able to say off-the-cuff which focal length they'd need to nicely fit their desired subject into the frame let alone beginners.

# What can it do?
> ***NOTE:** There are differences in each version's capabilities and feature set, e.g. there's no need for field-use features on the desktop client*

Every version contains a bunch of specific formulae and accepts your setup's specifications as Inputs.
It will then proceed to present you the requested results.

## What can each version do specifically?
### Windows CLI
------------------------------------------
The CLI client was the very first iteration of this application and features a basic menu system, by entering one of the shown options you'll get to the actual feature.

It can calculate the maximum exposure time for light frames with the wanted amount of star-trailing and will present the results of an approximational "Rule of 300", the old "Rule of 500" for reference as well as the simplified and the full NPF 
rules which both were developed by Frédéric Michaud from the Société Astronomique du Havre (SAH). After calculating it will give you the results in seconds.

Also integrated is the capability to calculate the respective field of view along your sensor's (and thereby frame) short and long edge as well as the sensor's diagonal in relation to your focal length. These results will be presented in degrees (unit symbol: ° ).

#### Lore
- Since it only requires the command line and some minor processing power for the maths to work, it should run on any compatible Windows system no matter how weak the hardware is
- Will likely get ported to Linux first due to it's simplicity and lack of graphics
- rumor has it that a "Back" option is soon to be implemented

#### To-Do:
- fix the menu ("back" option)
- consolidate functions in code
- port to and test on linux
- find a way to port to and test on macOS

### Windows GUI
------------------------------------------
The GUI client can do everything the CLI client can do but puts a more comfortable user experience and less crude menu options in front of the maths instead of the CLI client's little black window.
Additionally the "Rule of 300" approximation is now a "Rule of your custom integer number" though 260 for full frame and 350 for APS-C crop cameras seem to be the most accurate ones that a normal person can still easily memorise.

As of now you can already save sensor profiles but bot read them in again, so in the near future you won't have to type in the dimensions each time you start the application.

#### Lore
- the Unity version just serves as example for "How **NOT** to design a desktop UI" - it's just clunky, ugly and disgusting to use
- the Qt port already has some UI elements that aren't fully fitted with the intended features but is already superior to the Unity version in every regard

#### To-Do:
- get the profile system working (especially the ListView)
- port to and test on Linux
- find a way to port to and test on macOS/Apple chips

### Android
------------------------------------------
The Android client is (for now) the only version meant for the use in the field. Additionally to the calculations it features a mostly red UI that serves as an red flashlight and a dedicated solid white across the screen for taking flats in a pinch, both of these
AddOns to the base functionality work best when the phone's screen is set to full brightness.

#### Lore
- will get a complete overhaul GUI-wise
- will definitely get cut off Unity at some point

#### To-Do:
- make the UI and especially entering the inputs smoother/less clunky
- get/make some proper button Icons going
- find a way to port to and test on iOS
