Radical-VisualStudio-Templates
==============================

Radical Framework Visual Studio templates, available in the Visual Studio gallery: https://visualstudiogallery.msdn.microsoft.com/5ff17cc4-ecf3-4395-9e18-d4673186e2fe

### Debug

In order to debug the templates you need to change the project properties, at least of the `Radical Templates` project, to run the `Visual Studio Experimental Instance`:

* Open `Project properties`
* Go in `Debug` section
* Change the `Start external program` with `C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\devenv.exe`
* Change the `Command line arguments` with `/rootsuffix Exp`