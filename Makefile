
TOP ?= $(CURDIR)

.PHONY: all
all: clean sdk

.PHONY: sdk
sdk:
	dotnet build

.PHONY: manifest
manifest:
	pwsh make_manifest.ps1

.PHONY: image
image:
	sudo docker build -t NtnxSDK .

.PHONY: clean
clean:
	rm -rf ./src/Nutanix.PowerShell.SDK/bin/
	rm -rf ./src/Nutanix.PowerShell.SDK/obj/
