# DotnetCore-DB-CF
This is a dotnet core application with backend MSSQL database that can be deployed to CloudFoundry


# Clone the solution
git clone https://github.com/navya476/DotnetCore-DB-CF.git

# Install the dotnet core related modules to build the solution using this link
## https://www.codeproject.com/Articles/1137493/Deploy-ASP-Net-Core-Web-Applications-on-Ubuntu-Lin

# Install bower (dotnet core solution needs bower)

sudo apt-get install python-software-properties

curl -sL https://deb.nodesource.com/setup_6.x | sudo -E bash -

sudo apt-get install nodejs

sudo npm install -g bower

# Publish the solution

cd DotnetCore-DB-CF

dotnet restore

cd src/CSUsingEFDBFirstWithNetCore

dotnet publish

cd bin/Debug/netcoreapp1.0/publish/

# Push the application to CloudFoundry

cf login ## give appropriate link with username and password (https://api.run.pivotal.io)

cf push "ApplicationName" -b https://github.com/cloudfoundry/dotnet-core-buildpack
