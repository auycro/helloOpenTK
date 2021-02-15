## Prerequisite

```
brew install gtk+3 glade
```

## Settings up glade editor

- To configure that “Open in Editor” extension properly
- go to menu View | Command Palette
- type Open User Settings and click on it to open the Settings page
- in the Settings page expand the "Extensions" entry
- find the "Open in External Editor" entry
- click on the "Edit in settings.json" found under the Alt-editor: Binary
- add the following two lines
  1. "alt-editor.binary": "C:\\Tools\\msys64\\mingw64\\bin\\glade.exe",
  2. "alt-editor.args": "{filename}"
- Now open any *.glade file in VSCode editor, right click on it, and hit "Open in External Editor".