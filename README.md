![icon](resources/icon.png)

# Window swaper
Window swaper is a utility program for Windows platform that allow to swap window positions on multi-screen environment. All of this accessible through globally assigned hotkey/shortcut.

## How does the program work?
Let's say that you have 2 window applications (A and B) opened each on one monitor. Then by pressing a predefined hotkey, window A moves to screen where window B was located while window B moves to where window A was. This only work when application A and B are **not** on the same screen/monitor and they are the top most focused elements (A and B are first elements in "alt-tab list"). It also does not work when program's window is maximized.

![illustration](resources/illustration.gif)

*Illustration of program's working principle*

## The state of this project
This is **functional prototype** where one can test if such functionality does really work/ is needed.

For now I will update this functional prototype to the level where I'm satisfied with it's functionality. Then I will probably migrate this project to more suitable solution/environment.

## Know issues & features to add
or things that needs to be addressed before anyone can call it a functional program.

- swap with first window that is not on the same screen rather than with second element. This would result in situation that always the 2 visible windows would be swapped. I think so at least.

- For now it only works for environments with 2 horizontals screens where horizontal resolution is 1920 pixels for both.
- There is no other possibility to change hotkey than modifying it directly in the source code
- Programs architecture is very junky and needs rework. 
