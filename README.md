# HsvScreensaver

This Windows screensaver uses an source image and animates its hue value (HSV color model). It does so by compiling OpenGL shaders that are executed directly on the video card. Settings are available to customize the animation, the used source image and display settings.


## Download

There are two ways to obtain an `HsvScreensaver.scr` executable of this project:

1. download the latest [released binary](https://github.com/Istador/HsvScreensaver/releases)
2. download the source code and compile it yourself (see the build section)


## Installation

1. Copy the `HsvScreensaver.scr` file into `%windir%/System32/`
2. Use the Windows screensaver settings to select `HsvScreensaver`


## Minimum System Requirements

- Windows 7 (might work with XP)
- .NET Framework 2.0
- OpenGL 2.0 compatible video card supporting GLSL 1.1
- 64 bit CPU (an untested 32 bit executable is available)


## Settings

The screensaver can be customized using the settings dialog that can be opened in the windows screensaver selection dialog.

A click on the penguin at the bottom left disables or enables the penguin. Clicking on the preview at the bottom right opens a fullscreen preview using the selected display mode.

![A screenshot showing the settings dialog in english]
(https://github.com/Istador/HsvScreensaver/blob/pictures/screenshots/SettingsForm.en.png "Settings Dialog")

- Image
   - Path [String]
   - Repeat
      - X [+0.01, 50.00]: repeat the image horizontally
      - Y [+0.01, 50.00]: repeat the image vertically
   - Move
      - X [-1.00, +1.00]: moves the images origin point horizontally
      - Y [-1.00, +1.00]: moves the images origin point vertivally
- Color Correction
   - +RGB: changes the rgb colors of the input image
      - R [-1.00, +1.00]: red
      - G [-1.00, +1.00]: green
      - B [-1.00, +1.00]: blue
   - HSV
      - H [ 0.00, +3.60]: hue in 1/100 degree
      - S [-1.00, +1.00]: saturation
      - V [-1.00, +1.00]: value
   - RGB: changes the rgb colors of the output image
      - R [-1.00, +1.00]: red
      - G [-1.00, +1.00]: green
      - B [-1.00, +1.00]: blue
- Display
   - Monitors
      - X [1, 9]: number of horizontal monitors besides each other
      - Y [1, 9]: number of vertical monitors above each other
   - Mode {Normal, Mazimized, Fullscreen}: Display mode
   - VSync {0, 1}: Changing this setting is disabled, because it might overheat the video card if disabled. It can only be enabled manually in the settings file.
- Hue Animation
   - Speed [-50.0, +50.0]: animation speed in °/s (scales per axis individually with X/Y, Monitors and Repeat)
   - Intensity [0.0, 100.0]: percentage of blending with the unaltered source image (0.0 := source image)
   - X [-20.0, +20.0]: increases the hue value based on the x-coordinate (this creates a horizontal rainbow effect)
   - Y [-20.0, +20.0]:  increases the hue value based on the y-coordinate (this creates a vertical rainbow effect)
   - Random Init {0, 1}: screensaver starts with a random hue value

The setting will be saved in the `config.xml` file in the settings directory.

On Windows 7 the settings directory is: `%userprofile%/AppData/Roaming/blackpinguin.de/HsvScreensaver/`

It's possible to use custom vertex and fragement shaders by creating the files [vert.glsl](https://github.com/Istador/HsvScreensaver/blob/public/Common/vert.glsl) and/or [frag.glsl](https://github.com/Istador/HsvScreensaver/blob/public/Common/frag.glsl) in the settings directory. On older hardware where this screensaver might not be running smoothly, it is advisable to use custom shaders to improve performance. For example, one might remove unused color correction settings from the fragment shader.


## Build

Get the C# source code:
```bash
git clone https://github.com/Istador/HsvScreensaver.git
```

In the `/Windows/C#/` directory resides a [Visual Studio 2015 Community](https://www.visualstudio.com/products/visual-studio-community-vs) project with the name `HsvScreensaver`. Open it in Visual Studio and build it.

The [OpenTK](http://www.opentk.com/) 1.1 library and the [TextTransform](https://msdn.microsoft.com/en-us/library/bb126245.aspx) 14.0 executable are given in the `/Windows/C#/HsvScreensaver/Libraries/` directory. You might want to change OpenTK to a newer version or use a TextTransform version that better fits your build system.

The following two packages should be automatically downloaded by Visual Studio via NuGet:
- Costura.Fody
- Fody

They are used to package the `OpenTK` library into the executable as an ressource, so that it can run independently without deploying it together with additional `.dll` files.


## Example Animations

### Source Image

It's advisable to have an image with color information and varying saturations, because changing the hue of an greyscale image has no visible effect. The saturation of the image can be changed in the screensaver settings but that is applied to all pixels symetrically (it would affect white pixels a lot).

Here is a simple image I made that you can use:

[
![Death Star PD logo on an blue background]
(https://github.com/Istador/HsvScreensaver/blob/pictures/source_images/DSPD_thumb.png "Example source image")
]
(https://github.com/Istador/HsvScreensaver/blob/pictures/source_images/DSPD_1080.png)

It uses the [Death Star PD](https://rcl.blackpinguin.de/proj/DeathStarPD/) logo on a blue background with noise, a textile pattern and a central light spot.

The image should match the display's aspect ratio (or the aspect ratio of one monitor in a multi monitor setup with identical devices ). The following examples were made with an 1280x1024 image for three monitors that were forming one display having a resolution of 3*1280x1024 = 3840x1024.


### Skew Rainbow

Settings:
- Hue Animation
   - X = 0.50
   - Y = 0.30

Animation:

![Skew rainbow color effect that (seems) to move horizontally from left to right]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/Rainbow.gif "Animation: Skew Rainbow")

Screenshot:

![Skew rainbow color effect]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/Rainbow.png "Screenshot with a higher quality than the GIF")


### Horizontal Rainbow

Settings:
- Hue Animation
   - X = 0.25
   - Y = 0.00

Animation:

![Rainbow color effect that (seems) to move horizontally from left to right]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/Horizontal.gif "Animation: Rainbow horizontally")

Screenshot:

![Horizontal rainbow color effect]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/Horizontal.png "Screenshot with a higher quality than the GIF")


### One Color

Settings:
- Hue Animation
   - X = 0.00
   - Y = 0.00

Animation:

![One color on the whole screen that is changing over time]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/OneColor.gif "Animation: rotating one color")

Screenshot:

![One color on the whole scren]
(https://github.com/Istador/HsvScreensaver/blob/pictures/examples/OneColor.png "Screenshot with a higher quality than the GIF")
