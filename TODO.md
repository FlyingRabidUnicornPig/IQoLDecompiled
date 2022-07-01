Event Test Map - Make sure nothing gets borked between updates and a way to view every map event in one place. Add modded events as they come.

How to contribute - Not a priority, until at least dump is done, and maybe if there's more interest in the project. Need to figure out process: suggested changes to this repo will be manually modded in by me for testing/release?

Need to match releases between IQoL and here for better source control. Branches, Blames, whatever. Gonna be hell if i don't make sure these repos match. Maybe make them the same repo? Why didn't I do that before?

~~Ensure nothing important was broken by removing LevelEditorScene, the old map editor. Revert to an [old .dll](https://github.com/FlyingRabidUnicornPig/IQoLDecompiled/blob/11ea506258be974ae084e694bdfd1cd5fc5e1620/Assembly-CSharp.dll) to bring back the code for this class~~

Just bring back all the deleted classes, at least for preservation's sake. It is possible to remove classes that are "unused" according to dnSpy without crashing the game, for an example of this check the LogoAnimation class. Analyzing this class shows that "nothing" uses it, but if you delete this class you will no longer have the logo animations that plays before the menu (and after the splash logos). Who knows what else I've effected by deleting "unusued" classes that didn't immediately crash the game.

Confirmed: Readding old classes directly into the new .dll through dnSpy works. Use the vanilla .dll to readd