# Set directories
$apiDir = "co2unter.API"
$frontendDir = "frontend"
$outputDir = "output"
$deployTarGz = "deploy.tar.gz"

# Set Docker image names
$apiImage = "co2unter-app:latest"
$frontendImage = "co2unter-frontend:latest"

# Ensure the output directory exists
if (-not (Test-Path -Path $outputDir)) {
    New-Item -ItemType Directory -Path $outputDir
}

# Build the Docker images
Write-Host "Building Docker image for API..."
docker build -t $apiImage $apiDir

Write-Host "Building Docker image for Frontend..."
docker build -t $frontendImage $frontendDir

# Save the Docker images as tar files
Write-Host "Saving API Docker image to tar..."
docker save $apiImage -o "$outputDir/co2unter-app-latest.tar"

Write-Host "Saving Frontend Docker image to tar..."
docker save $frontendImage -o "$outputDir/co2unter-frontend-latest.tar"

# Verify the existence of docker-compose-deploy.yml and reverseProxy directory
$composeFile = "docker-compose-deploy.yml"
$reverseProxyDir = "reverseProxy"

if (-not (Test-Path -Path $composeFile)) {
    Write-Host "Error: docker-compose-deploy.yml not found!"
    exit 1
}

if (-not (Test-Path -Path $reverseProxyDir)) {
    Write-Host "Error: reverseProxy directory not found!"
    exit 1
}

# Package everything into deploy.tar.gz using relative paths
Write-Host "Packaging everything into a deploy tar.gz file..."

# Temporarily change to the parent directory to avoid including absolute paths
$parentDir = (Get-Location)

# Compress relative files from the current directory (without full path)
Push-Location $parentDir
tar -czvf "output/$deployTarGz" -C $outputDir "co2unter-app-latest.tar" "co2unter-frontend-latest.tar" -C $parentDir "docker-compose-deploy.yml" "reverseProxy"
Pop-Location

Write-Host "Deployment package is ready at $deployTarGz"
