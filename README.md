# Window swaper
Utility program for Windows that allows to swap windows with each other in multi-screen enviroment by a hotkey. This is usefull when you quicly want to look/use other application without loosing focus.

# How it works?
Let's say that you have 2 window application a and b opened each on one monitor. Then by a hotkey, you can swap their positions with each other. Application a that was located on screen 1 is moved into screen 2 while application b is moved from screen 2 to 1.  

# The state of this project
Basicly this is **functional prototype** where one can test if such functionality does really work/ is needed.

I'm looking for frameworks that better match the projects scope. I'm also experimenting with different approach, should it be a terminal application, service or gui application as it currently is.

# Know issues & features to add
or things that needs to be addressed before anyone can call it a functional program.
- For now it only works for enviroments with 2 horizontals screens where horizontal resolution is 1920 px for both.
- There is no other possiblity to change hotkey than modifing it directly in the source code
- Programs architecture is very junky and needs rework. 
