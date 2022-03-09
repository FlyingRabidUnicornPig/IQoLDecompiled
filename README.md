# IQoL Decompiled
The decompiled and deobfuscated files for Intralism and IQoL (WORK IN PROGRESS)

This repo is a resource to allows for better organization, version tracking, and potential collaboration for the [IQoL Mod](https://github.com/FlyingRabidUnicornPig/IntralismQoLMod) project.

**This is not the source code to Intralism**

This is the result of decompiling each class in the Assembly-CSharp.dll file through dnSpy, with added modifications to be more human-readable.

dnSpy does not save comments, uneeded white space, cannot access all the code and will change other aspects of my code, as dnspy's goal is to produce computer-focused, code, not human code. While I've adapted to this "hostile" environment quite well, it's recently been a pain trying to manage larger features over multiple days. It's time I've adapted further.

## Road Map

1. Copy-Paste the contents of each class from the current version of IQoL into individual files for this repo

1.5 Create appropriate folders for better management.
 
2. Cleanup
 - Deobfuscate
    - Remove junk code
    - Rename used gibberish-code
    - Remove unreadable compiler-garbo
 - Comment on shit
 - Improve code style for readability
3. Keep this repo updated with each mod update for source control. Plan for missed files, a full dump and deobf should be done every month or two.
