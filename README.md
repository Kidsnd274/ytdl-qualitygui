# YouTubeDL QualityGUI
youtube-dl GUI with format options

## Description
GUI for youtube-dl to allow users of youtube-dl to choose which formats to download.

![image](https://user-images.githubusercontent.com/1343896/117649017-92861f80-b1c1-11eb-91fb-928c127f581d.png)

### Features
- Displays available formats for provided link (if supported by youtube-dl)
- Filter only audio formats (for YouTube links only)

### Prequisites:
- [youtube-dl](https://github.com/ytdl-org/youtube-dl) (required)
- [ffmpeg](https://github.com/FFmpeg/FFmpeg) (recommended, for muxing, youtube-dl needs this)

### Downloads
- [Releases](https://github.com/Kidsnd274/ytdl-qualitygui/releases)

### Usage
1. Place the youtube-dl.exe in the same directory as YouTubeDL QualityGUI or specify youtube-dl.exe's location
2. If using ffmepg.exe, place it in the same directory as youtube-dl.exe
4. Paste video link in the Link box and click Check
5. Select one video format and one audio format and click Download

The program might hang when sending commands to youtube-dl.exe (It's not multi-threaded yet)
