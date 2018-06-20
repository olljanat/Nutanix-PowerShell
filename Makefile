
TOP ?= $(CURDIR)
BUILD_DIR ?= $(CURDIR)/build

.PHONY: all
all: sdk

.PHONY: sdk
sdk:
	mkdir -p $(BUILD_DIR)
	dotnet build --output $(BUILD_DIR)

.PHONY: manifest
manifest:
	pwsh make_manifest.ps1

.PHONY: image
image:
	sudo docker build -t NtnxSDK .

.PHONY: clean
clean:
	rm -rf $(BUILD_DIR)

.PHONY: realclean
realclean:
	rm -rf $(BUILD_DIR)
	rm -rf $(DEPS_DIR)
