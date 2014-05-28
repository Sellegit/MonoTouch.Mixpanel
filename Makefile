all:
	$(MAKE) -C library
	cp library/libMixpanel.a binding/libMixpanel.a
	$(MAKE) -C binding

clean:
	$(MAKE) -C library clean
	$(MAKE) -C binding clean
