Since this is intended to be used alongside IQoL work, some "faults" or "unneccessites" from dnSpy will be retained. This is to make finding/matching code easier between the two.

This repo will keep dnSpy's Class structure (just found it this isn't consistent NotLikeThis)
- Head Class
  - Methods
  - Constructors
  - Members
  - Classes

Methods on this repo will follow the order as seen in dnSpy unless asinine (i.e. a group of methods that only work with each other but are hundreds of lines apart).
I believe dnspy methods can be rearranged by copy/pasting the whole class, but that requires a deobf'd/editable class, not always available.

dnSpy uses `this` for all members and `base` for base methods even if they aren't overwritten. The repo will follow this style.

Code does not need to be the same between both as long as the function is the same. This repo is for readability, dnSpy is for functionality. However, it should be able to copy/paste a repo class into the appropriate dnspy class without unwanted in-game alterations.
