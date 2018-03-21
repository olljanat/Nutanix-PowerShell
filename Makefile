
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
		-reference:$(DEPS_DIR)/NETStandard.Library.NETFramework.2.0.0-preview2-25405-01/build/net461/lib/netstandard.dll \
		-reference:$(DEPS_DIR)/PowerShellStandard.Library.5.1.0-preview-01/lib/netstandard2.0/System.Management.Automation.dll \
		-reference:$(DEPS_DIR)/Newtonsoft.Json.10.0.3/lib/net40/Newtonsoft.Json.dll \
		*.cs
	cp NtnxPoshSDK.dll-Help.xml $(BUILD_DIR)/NtnxPoshSDK.dll-Help.xml

# Install dependencies.
.PHONY: deps
deps:
	nuget install -OutputDirectory deps NETStandard.Library.NETFramework -Version 2.0.0-preview2-25405-01
	nuget install -OutputDirectory deps Newtonsoft.Json -Version 10.0.3
	nuget install -OutputDirectory deps PowerShellStandard.Library -Version 5.1.0-preview-01

.PHONY: image
image:
	sudo docker build .

.PHONY: clean
clean:
	rm -rf $(BUILD_DIR)

.PHONY: realclean
realclean:
	rm -rf $(BUILD_DIR)
	rm -rf $(DEPS_DIR)
