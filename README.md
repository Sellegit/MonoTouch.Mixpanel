# MonoTouch.Mixpanel

Xamarin MonoTouch bindings to the [Mixpanel SDK](https://mixpanel.com/help/reference/ios) (v2.3.6).

## Usage

``` c#
using MonoTouch.Mixpanel;

...

Mixpanel.SharedInstanceWithToken ("be362dcdbbbe95297ec9fc57d1ad8424");
Mixpanel.SharedInstance.Identify ("thisuser@gmail.com");
Mixpanel.SharedInstance.People.Set ("some.property", new NSNumber (true));
```

Check out more integration samples in the [Mixpanel SDK documentation](https://mixpanel.com/help/reference/ios).

## Build

``` sh
$ git submodule init
$ git submodule update
$ make
```

Requires `xcodebuild` and `xbuild` to compile.

## Installation

- Add `bindings/MonoTouch.Mixpanel.dll` to your project.
- Add contents of the `resources/` subdirectory your main bundle (unfortunately it's not possible to have them in the binding)

## Requirements

MonoTouch.Mixpanel is tested on iOS7.

## TODO

* Have the resources directly in the binding DLL

Pull requests welcome!

## Contact

Lukas Lipka

- http://github.com/lipka
- http://twitter.com/lipec
- http://lukaslipka.com

## License

MonoTouch.Mixpanel is available under the [MIT license](LICENSE). See the LICENSE file for more info.
