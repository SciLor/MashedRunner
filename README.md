# SciLor's Mashed Runner v5

![Screenshot](https://raw.githubusercontent.com/SciLor/MashedRunner/master/SciLorsMashedRunnerv4.jpg)

## ReadMe

You will need the .NET Framework 2.0
http://www.microsoft.com/download/en/details.aspx?id=19

SciLor's Mashed Runner allows you to run Mashed Fully Loaded and Mashed ;).

It bypasses the launcher of the game, so you can run the game without installation and any cd.
This way you may just copy the game onto an usb-stick and play it anywhere.

Additionally you can select the game's language, disable the intros and create a shortcut on your desktop for this launcher
with the click of a button.

## Additional
This is no crack, nocd or how you want to call it. The game implements the copy protection in the launcher (launch.exe),
but the game is in the "MFL.exe"/"MASHED.exe". The launcher runs the "MFL.exe"/"MASHED.exe" with different command line parameters,
that define the language and if it should show the settings.
If you run the "MFL.exe" directly the game will run in english and prompt for video/control settings on every statup.

This application replaces the launcher and runs the "MFL.exe"/"MASHED.exe" with the fitting parameters.

## Known Bugs

If you like my hard work PLEASE DONATE! :)
http://www.scilor.com/donate.html

## ChangeLog

### v5(2012-03-21)
- New: The old version of Mashed is now also supported (The one before Fully Loaded)

### v4(2012-01-14)
- Fix: Wrong language Portuese -> Italiano
- Fix: Various Errors.
- Enhancement: Create Registry entries if the game is not installed.
- Enhancement: NoCD Patch for the original launch.exe.
	There was any need for that, more or less interesting for people that want to write patches.
	Just take a look at the source, especially the "SearchAndReplace.cs"
	that implements the Search and Replace Engine of the dup2 patcher, so you can use its generated patterns
- Enhancement: Run launch.exe.

### v3(2011-12-23)
- Fix: Disabled looking comboboxes after using settings
- Fix: Low quality taskbar icon, when using a shortcut.
- Enhancement: Source code design, some classes etc.

### v2(2011-12-22)
- Feature: Disable Intro videos
- Enhancement: Less IO usage

### v1(2011-12-21)
- Initial Release


## Web
My Website: http://www.scilor.com/

SciLor's Mashed Runner Website: http://www.scilor.com/mashed-runner.html

Donation: http://www.scilor.com/donate.html
