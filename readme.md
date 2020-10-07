# PortDiscrd - WebApplication to Handle multiple discord accounts

Based on SharpBrowser which is based on CefSharp which is based on Chromium  
Does not support Voice Calls/Playback videos screensharing etc. cause of lack of Chromium license for mpeg to support mp3/mp4 executions) - to make it work you will need to recompile chromium with support of mp3/mp4 to allow browser to communicate and playback videos on channels

Clicking into link inside tab will open new default browser tab with this link, if its internal discord link it will be open in same tab (i supose), fixed failed loading of images/thumbnails of videos whic hgoes to endless loop, and few other thigns. Still in develop avaliable hotkeys: F5 for refresning, CTRL + Tab - move forward 1 tab, CTRL + SHIFT + Tab - move backward 1 tab.  
all hotkeys can be found at MainForm.cs -> line 99
