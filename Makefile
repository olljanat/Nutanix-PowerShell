
TOP ?= $(CURDIR)
BUILD_DIR ?= $(CURDIR)/build
DEPS_DIR ?= $(CURDIR)/deps

.PHONY: all
all: sdk

# TODO: Powershell SDK should be 6.0 instead of 5.0, but 6.0 is not easily
# available via 'Install-Package' yet.
.PHONY: sdk
sdk:
	mkdir -p $(BUILD_DIR)
	mcs \
		-target:library \
		-out:$(BUILD_DIR)/NtnxPoshSDK.dll \
		-reference:$(TOP)/deps/Microsoft.PowerShell.5.ReferenceAssemblies.1.1.0/lib/net4/System.Management.Automation.dll \
		-reference:$(TOP)/deps/Newtonsoft.Json.10.0.3/lib/net40/Newtonsoft.Json.dll \
		*.cs
	cp NtnxPoshSDK.dll-Help.xml $(BUILD_DIR)/NtnxPoshSDK.dll-Help.xml

# Install dependencies.
.PHONY: deps
deps:
	nuget install -OutputDirectory deps Newtonsoft.Json -Version 10.0.3
	nuget install -OutputDirectory deps Microsoft.PowerShell.5.ReferenceAssemblies -Version 1.1.0

.PHONY: clean
clean:
	rm -rf $(BUILD_DIR)

.PHONY: realclean
clean:
	rm -rf $(BUILD_DIR)
	rm -rf $(DEPS_DIR)
