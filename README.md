# IQoL Decompiled
The decompiled and deobfuscated files for Intralism and IQoL (WORK IN PROGRESS)

This repo is a resource to allow for better organization, version tracking, and potential collaboration for the [IQoL Mod](https://github.com/FlyingRabidUnicornPig/IntralismQoLMod) project.

__**This is not the source code to Intralism**__

This is the result of decompiling each class the Assembly-CSharp.dll file through dnSpy and dumping each class, with this repo hosting additional modifications for readability.

dnSpy does not save comments or extra white space, cannot access all the original code, and will change submitted code when compiling; a compiler's goal is to produce computer-focused code, not human-focused code. While I've adapted to this "hostile" environment quite well, it's recently been a pain trying to manage larger features over multiple days. It's time I've adapted further.

## Road Map

1. Copy-Paste the contents of each class from the current version of IQoL into individual files for this repo
 
2. Cleanup
  - Deobfuscate
     - Remove junk code
     - Rename used gibberish-code
     - Humanify unreadable compiler-garbo (make sure it compiles same as mod!)
  - Comment on shit
  - Improve code style for readability
3. Keep this repo updated with each mod update for source control. Plan for missed files, a full dump and deobf should be done every month or two.
