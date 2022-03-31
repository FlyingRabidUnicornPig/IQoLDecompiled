# IQoL Decompiled
The decompiled and deobfuscated files for Intralism and IQoL.

This repo is a resource to allow for better organization, version tracking, and potential collaboration for the [IQoL Mod](https://github.com/FlyingRabidUnicornPig/IntralismQoLMod) project.

### This is not the source code to Intralism.
### This contains no assets from Intralism.
### These files cannot rebuild Intralism.

This is the result of decompiling each class in `Assembly-CSharp.dll` through dnSpy and dumping the results in this repo. Additional, non-critical modifications such as white-space adjustment and comments will make this repo more readable than dnSpy.

dnSpy does not save comments or extra white space, cannot access all the original code, and can drastically change submitted code when compiling; a compiler's goal is to produce computer-focused code, not human-focused code. While I've adapted to this "hostile" environment quite well, it's recently been a pain trying to manage larger features over multiple days. It's time I've adapted further.

## Road Map

1. Copy-Paste the contents of each class from the current version of IQoL into individual files for this repo (In progress for all classes)
 
1.5. Cleanup (In progress for more important classes)
  - Deobfuscate
     - Remove junk code
     - Rename used gibberish-code
     - Humanify unreadable compiler-garbo (make sure it compiles same as mod!)
  - Comment on shit
  - Improve code style for readability
2. Prep for release, squash bugs, finish up cleanup, etc. Then upload new .dll to [IQoL](https://github.com/FlyingRabidUnicornPig/IntralismQoLMod)
3. Keep this repo updated with each IQoL update for source control. Plan for missed files, a double-check should be done every month or two.
4. When do i make money from doing this?

### New Features for release
- Editor Performance increases
  - Selecting objects is less taxing.
  - Caret used extremely bad code, increased performance by 10-14% (jfc)
- **Improved Console**
  - You can see what your commands are doing
  - Unlocked "cheat" and dev commands
  - New commands
    - `logAll < t | f >` set to true to see all logs, not just warnings or errors. This saves to your file as well.

### Bug fixes
- Vanilla: Background colors not being parsed correctly in editor or something idr
- Vanilla: Can record highscores on first attempt again (oxy was checking for something only hackers could do cool)
- Mod: Fixed quickstart offline mode (hopefully)

### Bugs To Squash before release
- Some sliders may start as float sliders when they should be integer sliders in editor. **Workaround** press apply and they will fix themselves.
- Editor selector (drag-n-select) will have a drastically inappropriate window for the first frame sometimes, selecting arcs you didn't want to (Extremely bothersome when `ctrl`+selecting). Happens when zoom or time changes since last select. Seems to use the same screen space as the last select. (Maybe reset values after a select-end?) **No Workaround**
