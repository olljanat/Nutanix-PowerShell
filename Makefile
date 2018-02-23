
BUILD_DIR ?= $(CURDIR)/build

.PHONY: all
all: sdk

# TODO: Powershell SDK should be 6.0 instead of 5.0, but 6.0 is not easily
# available via 'Install-Package' yet.
# TODO: compile more files than just 'Vm.cs'.
.PHONY: sdk
sdk:
	mkdir -p $(BUILD_DIR)
	mcs \
		-target:library \
		-out:$(BUILD_DIR)/NtnxPoshSDK.dll \
		-reference:/usr/local/share/PackageManagement/NuGet/Packages/Microsoft.PowerShell.5.ReferenceAssemblies.1.1.0/lib/net4/System.Management.Automation.dll \
		-reference:/usr/local/share/PackageManagement/NuGet/Packages/Newtonsoft.Json.10.0.3/lib/net45/Newtonsoft.Json.dll \
		*.cs

.PHONY: clean
clean:
	rm -rf $(BUILD_DIR)
