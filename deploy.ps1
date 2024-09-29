# Set variables
$localDeployFile = "output/deploy.tar.gz"
$remoteUser = "ubuntu"
$remoteHost = "ec2.co2unter.redtm.pl"
$remoteDeployPath = "/home/ubuntu/deploy.tar.gz"

# Ensure the deploy file exists
if (-not (Test-Path -Path $localDeployFile)) {
    Write-Host "Error: Deployment file $localDeployFile not found!"
    exit 1
}

# Copy the deploy.tar.gz to the remote server
Write-Host "Copying $localDeployFile to ${remoteUser}@${remoteHost}:${remoteDeployPath}..."
scp $localDeployFile "${remoteUser}@${remoteHost}:${remoteDeployPath}"

# Check if the copy was successful
if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: Failed to copy the deploy file."
    exit 1
}

# SSH into the remote server to unpack and run Docker commands
Write-Host "Connecting to ${remoteUser}@${remoteHost} to unpack and deploy..."

# Create the SSH command to execute on the remote server
$sshCommand = @"
cd /home/ubuntu
tar -xzvf deploy.tar.gz
mv docker-compose-deploy.yml docker-compose.yml  # Rename the docker-compose file
docker load -i co2unter-app-latest.tar
docker load -i co2unter-frontend-latest.tar
rm *.tar
docker compose up -d --build
"@

# Execute the SSH command
ssh "${remoteUser}@${remoteHost}" $sshCommand

# Check if the SSH command was successful
if ($LASTEXITCODE -ne 0) {
    Write-Host "Error: Failed to execute remote commands."
    exit 1
}

Write-Host "Deployment completed successfully!"
