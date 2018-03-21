# A basic setup of powershell.
FROM centos:centos7

RUN yum -y install make
RUN yum -y install git

RUN curl https://packages.microsoft.com/config/rhel/7/prod.repo | tee /etc/yum.repos.d/microsoft.repo
RUN rpm --import "http://keyserver.ubuntu.com/pks/lookup?op=get&search=0x3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF"
RUN curl https://download.mono-project.com/repo/centos7-stable.repo | tee /etc/yum.repos.d/mono-centos7-stable.repo
RUN yum -y install mono-devel
RUN yum -y install mono-complete
RUN yum -y install nuget
RUN yum -y install yum-utils
RUN yum -y install powershell
RUN yum -y install dotnet-sdk-2.0.0
RUN git clone https://github.com/nutanix/Powershell
RUN cd Powershell && make deps
RUN cd Powershell && make
