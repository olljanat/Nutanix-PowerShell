#!/bin/bash
#
# Usage:
# Start with a MINIMAL Centos installation.
# Then run this script as root, followed by yum update.
# Periodically, re-run this script to pick up new packages.
#

set -e
set -x

# Install 'yum-utils' for yum-config-manager.
yum -y yum-utils

yum-config-manager --add-repo http://download.mono-project.com/repo/centos/

# For installing powershell.
curl https://packages.microsoft.com/config/rhel/7/prod.repo | tee /etc/yum.repos.d/microsoft.repo

PACKAGES=(
  powershell
  mono-complete
  dotnet
  dotnet-sdk-2.0.0
)

yum -y --setopt=exclude= install "${PACKAGES[@]}"

exit 0
