[Please Consider Donating to my Ko-fi](https://ko-fi.com/dustdust)

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
3. Keep this repo updated with each IQoL update for source control. Plan for missed files, a double-check should be done every month or two. (consider changing to have only one repo, would make .dll/source changes easier to manage)

### New Features for release
- Editor Performance increases
  - Selecting objects is less taxing.
  - Caret used extremely bad code, increased performance by 10-14% (jfc)
- Faster Map Loading (On my computer with decent CPU, loading 50 editor maps went from 2.5 seconds to 1.83 seconds)
 - Difficulty Calculation is less performance intensive
   - Low difficulty maps may have had their difficulty changed by up to ±.1)
 - Optimized LevelsListElement (the map icon and all the buttons that let you select a map, rate for workshop, see more info, etc)
- Deselect individual objects in Editor with ALT
  - ALT+CTRL to drag-deselect (Bug-feature)
- **Improved Console**
  - You can see what your commands are doing
  - Unlocked "cheat" and dev commands
  - New commands
    - `logAll < t | f >` set to true to see all logs, not just warnings or errors. This saves to your file as well.

### Bug fixes
- Vanilla: Background colors not being parsed correctly in editor or something idr
- Vanilla: Can record highscores on first attempt again (oxy was checking for something only hackers could do cool)
- Vanilla: Offline Mode will now work when the Steam API is down
  - You can play editor maps and use the editor.
  - TODO: Load downloaded workshop maps through File control rather than UGC control
- Vanilla/Mod: Fixed game over screen (again (again))
- Mod: "Fixed" quickstart offline mode (need to double check with a flakey connection to see if it really works)
- Mod: "Start offline mode" message won't pop up if you press o in console.
- Mod: Fixed 1/6th and 1/12 snap colors

### Bugs To Squash before release
- Some sliders may start as float sliders when they should be integer sliders in editor. **Workaround** press apply and they will fix themselves.
- Using loadscene 2 to load the editor before offline mode has been set causes some visual glitches. **Workaround:** start offline mode before using any loading commands.
- Vanilla Bug-Feature: CTRL+ALT is the only way to drag-deselect, this seems to be a bug from vanilla, as there's no code that is clearly for this purpose. I would rather drag-deselect was ALT only, but when I try that, Unity starts ignoring alt...
- Copy/Pasting events will more often use shitty offset than the offset you're expecting (ending arc more likely to be used than beginning arc for paste time, think it's using the last selected arc for time)
- Pressing Copy/Paste icons in event editor will break editor. Seems events aren't loading, check FindNearestEvent and other BS in MapEditor, CustomEventEditor, etc.
