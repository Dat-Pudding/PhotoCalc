# PhotoCalc on GitHub
Welcome to this repository. Here's a quick overview:

|<h2>Table of contents</h2><ul><li>[Who is this for?](#who-is-this-for?)</li><ul><li>[Bare Minimum Setup](#minimum-requirements)</li><li>[Ideal Setup](#recommended-requirements)</li><li>[Beyond Ideal Setups](#setups-beyond-the-recommended)</li></ul><li>[Capabilities](#what-can-it-do?)</li><li>[Version-specific capabilities](#what-can-each-version-do?)</li><ul><li>[Desktop CLI](#desktop-cli)</li><li>[Desktop GUI](#desktop-gui)</li><li>[Mobile](#mobile)</li></ul><li>[Roadmap](#current-roadmap)</li><li>[Thanks](#thanks)</li><li>[Special Thanks](#special-thanks)</li></ul>|
|:--|

## Who is this for?
This application is specifically for astro photographers - this doesn't mean that it's not useful for other genres.

Since a beginner usually isn't decked out with a tracking mount, means to create proper flats or a red flashlight, the android app is recommended for it's feature set specifically addressing these "hardware issues" for field-use. 

Not even more advanced amateurs might be able to say off-the-cuff which focal length they'd need to nicely fit their desired subject into the frame let alone beginners, that's also taken care of by the app.

### Minimum Requirements
For this app to be useful you'll need at least:
- some sort of camera
> *phone sensor support is not quite there yet*
- some way to hold the camera still enough for the light frames

### Recommended Requirements 
To fully profit of all functions you'll need:
- a system camera
- lenses (at least one)
- tripod (as rigid as possible)
- intervalometer

### Setups beyond the recommended
As soon as you add a tracker (and autoguider) to your setup the exposure time calculations will become less relevant if still relevant at all.

Even if you've outgrown most of its features the Field of View calculations can still help setting up the correct custom profiles in Stellarium (which by then you'll likely already own) or other similar apps that let you set specific viewports to visually pre-check your framing

---

## What can it do?
> ***NOTE:** There are differences in each version's capabilities and feature set, e.g. there's no need for field-use features on the desktop client*

Every version contains all formulae and accepts your setup's specifications as Inputs.
It will then display the results.

They can calculate the longest exposure time for light frames to achieve the desired amount of star-trailing and will display the results of an approximational "Rule of 300", the old "Rule of 500" for reference as well as the simplified and the full NPF 
rules. 

Of which the last two were both developed by Frédéric Michaud from the Société Astronomique du Havre (SAH) - [thanks](#special-thanks) for the extraordinarily friendly permission to use them.

After calculating it will output the four results in seconds (format: `#,###s`).

Also integrated is the capability to calculate the respective field of view - sometimes also referred to as "viewing angle" - along your sensor's short and long edges as well as the sensor's diagonal in relation to your focal length and the sensor's physical dimensions. 

These results will be displayed in degrees (format: `###,##°` ).

As of now, only the Android client offers a fully functional profile system, this feature will soon be implemented into the other versions as well. 

Of course it will be integrated into every port.

---

## What can each version do specifically?
### Desktop CLI
The CLI client was the very first iteration and features a basic menu system. By entering one of the shown options you can navigate to the specified functionality.

### Desktop GUI
> ***NOTE:** The desktop GUI version is currently being completely re-worked, therefore the following description is off by quite a margin.*

~The GUI client can do everything the CLI client can do but puts a more comfortable user experience and less crude menu options in front of the maths instead of the CLI client's little black window.
Additionally the "Rule of 300" approximation is now a "Rule of your custom integer number" though 260 for full frame and 350 for APS-C crop cameras seem to be the most accurate ones that one can still easily memorise.~

~As of now you can already save sensor profiles but not read them in again, so in the near future you won't have to type in the dimensions each time you start the application.~

### Mobile
The Android client is (for now) the only version meant for the use in the field. If the stars align and I can get my hands on an Apple device for development and testing, a future iOS version is planned.

Additionally to the calculations it features a mostly red UI that serves as an red flashlight and a function to cast a solid white across the screen for taking flats, both of these special features work best when the phone's (or tablet's) screen is set to full brightness.

---

## Current Roadmap
> ***NOTE:** Version numbers that go unmentioned on the roadmap will contain only minor changes to the last mentioned version for that operating system such as implemented but untested and inaccessible new features or accessable but incomplete or broken functionality*

### August
#### Android v0.5.0
- [ ] polishing GUI
- [x] improving profile system
  - [x] ~stream-lining normal saving/loading~
  - [x] ~adding a remove button for saved profiles~
#### WinGUI v0.4.6
- [ ] implementation of basic profile system
- [ ] complete rebuild
  - [x] of base functions
  - [ ] of basic GUI
#### WinCLI v0.2.0
- [ ] completing menus
- [ ] check code for refactoring 
- [ ] starting the Linux port

### September
#### Android v0.5.1
- [ ] fixing bugs
- [ ] further polishing
- [ ] make packages of sensor profiles exportable
#### WinGUI v0.5.0
- [ ] polishing GUI
- [ ] implementing basic profile system
#### WinCLI v0.2.1
- [ ] design and integrate profile system
- [ ] "finishing" Linux port
#### LinuxCLI v0.2.1
- [ ] fix possible issues from port
- [ ] populate for various distros

### October
#### Android v0.5.5
- [ ] fixing bugs
- [ ] further polishing
- [ ] make packages of sensor profiles importable
#### WinGUI v0.5.2
- [ ] polishing GUI
- [ ] improving profile system
  - [ ] stream-lining normal saving/loading
- [ ] starting the Linux port
#### WinCLI v0.2.4
- [ ] improve menus
#### LinuxCLI v0.2.4
- [ ] improve menus
- [ ] fix possible issues from port
- [ ] design and integrate profile system
- [ ] if necessary populate for various distros

### November 
#### Android v0.5.7
- [ ] fixing bugs
- [ ] further polishing
- [ ] integrating quick saving 
#### WinGUI v0.5.4
- [ ] polishing GUI
- [ ] improving profile system
  - [ ] including quick saving/loading
- [ ] "finishing" the Linux port
#### WinCLI v0.2.5
- [ ] improve menus
- [ ] design and integrate profile system
#### LinuxCLI v0.2.5
- [ ] improve menus
- [ ] fix possible issues from port
- [ ] design and integrate profile system
- [ ] if necessary populate for various distros

### December
#### Android v0.5.9
- [ ] fixing bugs
- [ ] further polishing
- [ ] integrating quick loading
#### WinGUI v0.5.5
- [ ] polishing GUI
- [ ] make packages of sensor profiles exportable
#### LinuxGUI v0.5.5
- [ ] polishing GUI
- [ ] make packages of sensor profiles exportable
#### WinCLI v0.2.8
- [ ] improve menus
- [ ] design and integrate profile system
#### LinuxCLI v0.2.8
- [ ] improve menus
- [ ] fix possible issues from port
- [ ] design and integrate profile system
- [ ] if necessary populate for various distros

### Future
#### Android v1.0.0
- [ ] including quick saving/loading
- [ ] including special options to accommodate for phone sensor/camera profiles
- [ ] *maybe I can get my hands on iOS hardware*
  - *if acquired: prepare iOS port*

#### WindowsGUI v1.0.0
- [ ] including quick saving/loading
- [ ] including special options to accommodate for phone sensor/camera profiles

#### LinuxGUI v1.0.0
- [ ] including quick saving/loading
- [ ] including special options to accommodate for phone sensor/camera profiles

#### WinCLI v0.5.0
- [ ] refining menus
- [ ] including special options to accommodate for phone sensor/camera profiles

#### LinuxCLI v0.5.0
- [ ] refining menus
- [ ] including special options to accommodate for phone sensor/camera profiles

---

## Thanks
*So far there's no one to thank*

---

## Special Thanks
As mentioned before I want to thank especially Frédéric Michaud for permitting the use of his formulae.

And I also want to thank my fiancée Nina for enduring my constant oversharing on the project and for bringing snacks when I forgot to eat again
