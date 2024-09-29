# KrakCO2

## Build

### Prerequisites

- System - Windows
- CLI - PowerShell
- 7Zip - https://www.7-zip.org/
- Docker engine - https://docs.docker.com/engine/install/

### Enable powershell scripts:
- open powershell as admin
- input: `Set-ExecutionPolicy RemoteSigned -Scope CurrentUser`

### Run build

- open powershell in project root directory
- .\build.ps1
- Builded package: `output/deploy.tar.gz`

## Deploy

### Prerequisites

- System - Windows
- CLI - PowerShell
- SSH & SCP available
- add ssh public key to `authorized_keys` on prod machine

### Run build

- open powershell in project root directory
- .\deploy.ps1
