### Generating Code

## Generator Framework
https://github.com/OpenAPITools/openapi-generator
https://github.com/OpenAPITools/openapi-generator#15---homebrew
* Mainline: brew install openapi-generator
* Master: brew reinstall --HEAD openapi-generator

## Generating code
* openapi-generator generate -i ./petstore-expanded.json -g csharp -o csharp -D targetFramework=v5.0
* openapi-generator generate -i ./petstore-expanded.json -g powershell -o powershell