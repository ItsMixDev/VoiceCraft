## About

This application lets you play Minecraft in a new way! Now the keyboard and mouse are no longer needed if you have a microphone. Now you can control the character with some simple voice commands, such as: "walk", "stop", "eat", "attack", "dig", etc., which can be customized. The application will automatically connect to the audio input device specified by the default, switching between devices in the app is unrequired! It supports **English** and **Russian(Русский)** languages!

>NOTE: This application only works on the Java Edition version of Minecraft, and also quality and speed of command recognition may depend on the CPU performance!

## Installation and Usage

1. Download the latest release from https://github.com/ItsMixDev/VoiceCraft/releases
2. Extract installed zip into a folder
3. VoiceCraft is based on the Microsoft Speech Recognition Platform, so you need to install the following stuff too:
   - [x] [Microsoft Speech Platform - Server Runtime (x86)](https://github.com/ItsMixDev/VoiceCraft/raw/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20(x86).msi)
   - [x] [Microsoft Speech Platform - Server Runtime Languages](https://github.com/ItsMixDev/VoiceCraft/tree/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20Languages) <-- Install `MSSpeech_SR_en-US_TELE.msi` or `MSSpeech_SR_ru-RU_TELE.msi` if you speak Russian. 
4. Launch the Minecraft, then go to `Options > Controls > Mouse Settings`, and set the `Raw Input: ON` as in the example:

   ![Guide](https://user-images.githubusercontent.com/83579961/117535465-8dc53e00-affe-11eb-9b0e-bc48878f19cd.png)

5. Launch VoiceCraft and select your language voice command package or use the default ones
6. Click on the `START` button or press `F8` to start speech recognition
7. Try to survive using only voice control commands ;)

## FAQ

1. **Some files are being deleted and/or my anti-virus is detecting VoiceCraft as malware. What do I do?**

If your antivirus software is blocking the VoiceCraft application, this may be because VoiceCraft has access to controls with which it manages the game. Just add an exception to your anti-virus for `voicecraft.exe` (or the folder it is in) to solve the problem.

2. **I can see errors when I'm launching the app and/or starting speech recognition. What do I do?**

First of all, you need to check if the `Microsoft Speech Platform - Server Runtime (x86)` is installed on your computer, otherwise, you can download and install it from [here](https://github.com/ItsMixDev/VoiceCraft/raw/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20(x86).msi). If you can't start speech recognition, read the error message and try to install a required language pack
from [here](https://github.com/ItsMixDev/VoiceCraft/tree/master/Microsoft%20Speech%20Recognition/Microsoft%20Speech%20Platform%20-%20Server%20Runtime%20Languages).

3. **How can I customize an existing or write my own voice commands?**

You can easily create your own voice command package in a convenient and simple editor embedded in the application if your language is supported by the Microsoft Speech Platform. To open the editor you can open an `Editor` page or click on the `EDIT` button on the main page.

4. **How can I import/export voice command packages?**

You can import any voice command packs by clicking on the `ADD` button on the main page and selecting *.vcc* files. You can find these files in the packages folder, which path is written on the main page, and export them.

5. **How to increase recognition quality on bad microphones?**

Use a special track bar on the main page to change the 'recognition confidence' value until you have good and accurate recognition! Making it lower than 10% or higher than 90% is not recommended because it will reduce recognition accuracy!

6. **Does this work for Mac or Linux?**

Actually no! Because the Microsoft Speech Platform only works on *Windows 10*, *Windows 7*, *Windows Vista*, *Windows 2003 Server*, and *Windows 2008 Server*!

7. **Will this project update in the future?**

The development will continue when the project attracts enough attention to inspire the creator.
