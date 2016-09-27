LitJSON

A .Net library to handle conversions from and to JSON (JavaScript Object Notation) strings. This fork has been edited specificity for use with Unity3D.

Originally created by lbv.

Installation

Simply pull the repo and open the .unitypackage to import the library.

Licence

This is free and unencumbered software released into the public domain.

For more information, please refer to http://unlicense.org/.

Examples

For general examples, check out /Docs/Quickstart/guide.md in this repo, there is also a simple example included in the Unity package.

Compiling

The LitJson csproj can be used to compile a dll and run the tests. If you intend to use the library in your Unity3D project I recommend you import the uncompiled source as there are some #if directives in Platform.cs that help make the library work on WinRT (and possibly other platforms in the future).
Compiler Directives

JSON_STANDALONE     // Compile without Unity3D dependencies.

JSON_WINRT          // Compile with WinRT compatibility fix. This will
                    // force compilation in Unity3D even if UNITY_METRO
                    // is false. It is recommended you only use this if
                    // you are using JSON_STANDALONE and are building
                    // for WindowsRT



Tests

This library comes with a set of unit tests using the NUnit framework.

TODO
1.Remove the static writer and just create a new private one each time instead (eliminates need for global lock).
2.Add more error checks for type hinting.
3.Add full XMLDocs to public interfaces.
4.Try to get custom importers/exporters working recursively.
5.README.md needs more information and examples.
6.Fix unit tests that cause mono to crash (something with Enums I think).



## Compiling

See the files under the `build` directory.

### Using GNU Make

Change directory to `build/make/` and run `make` from it. This tries to use
the `gmcs` compiler by default. Feel free to open the `Makefile` and tweak
it according to your needs.

### Using other tools

Currently, LitJSON doesn't have any other auxiliary files for compiling this
library with other tools.

If you want to contribute your own solutions to compile it with tools like
*NAnt* or *MSBuild*, that would be most appreciated. Please create those
auxiliary files under the path `build/some-tool`. Thanks.

## Tests

This library comes with a set of unit tests using the [NUnit][nunit]
framework.

If you have [pkg-config][pkg-config] in your system, and the *Mono* suite
provides the `mono-nunit.pc` file, you can try running these tests by running
`make test` from the `build/make` directory.

You can specify which `pkg-config` is invoked by passing a `PKG_CONFIG`
variable to `make test`. This is useful when you have mutiple conflicting
`pkg-config`s on your system and need to select the correct one (i.e. to
avoid conflicts with Homebrew on Mac OSX).

Example of running the tests on Mac OSX:

```bash
# In litjson/ directory
$ cd build/make
$ make PKG_CONFIG=/Library/Frameworks/Mono.framework/Commands/pkg-config test
```

## Using LitJSON from an application

Reference the `LitJson.dll` file when compiling your code. For a link to
download this file, see the *Download* section in the project's
[website][litjson].

Alternatively, just copy the whole tree of files under `src/LitJSON` to your
own project's source tree and integrate it with your development environment.

## License

[Unlicense][unlicense] (public domain).


[litjson]: http://lbv.github.io/litjson/
[nunit]: http://www.nunit.org/
[pkg-config]: http://www.freedesktop.org/wiki/Software/pkg-config
[unlicense]: http://unlicense.org/
