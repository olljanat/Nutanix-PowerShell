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
yum -y install yum-utils

yum-config-manager --add-repo http://download.mono-project.com/repo/centos/

# For installing powershell.
curl https://packages.microsoft.com/config/rhel/7/prod.repo | tee /etc/yum.repos.d/microsoft.repo

# For installing mono.
rpm --import "http://keyserver.ubuntu.com/pks/lookup?op=get&search=0x3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF"
su -c 'curl https://download.mono-project.com/repo/centos7-stable.repo | tee /etc/yum.repos.d/mono-centos7-stable.repo'

PACKAGES=(
  powershell
  mono-devel
  mono-complete
  dotnet-sdk-2.0.0
)

yum -y install "${PACKAGES[@]}"

exit 0
