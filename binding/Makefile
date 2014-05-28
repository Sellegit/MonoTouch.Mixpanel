BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
VERSION=1.8.1

all: MonoTouch.Mixpanel.dll

MonoTouch.Mixpanel.dll: Makefile ApiDefinition.cs libMixpanel.a
	$(MONOXBUILD) /p:Configuration=Release MonoTouch.Mixpanel.csproj
	cp bin/Release/MonoTouch.Mixpanel.dll MonoTouch.Mixpanel.dll

clean:
	-rm -rf list ios *.dll *.zip *.mdb *.sln bin/ obj/
