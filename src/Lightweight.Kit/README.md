#How to publish:

Variables: ACCOUNT, VERSION, PAT_KEY, SOURCE_NAME

dotnet nuget add source --username ACCOUNT --password PAT_KEY --store-password-in-clear-text --name SOURCE_NAME "https://nuget.pkg.github.com/ACCOUNT/index.json"

dotnet nuget push "bin/Release/Lightweight.Kit.VERSION.nupkg"  --api-key PAT --source "SOURCE_NAME"

# In case source is already added:

dotnet nuget push "bin/Release/Lightweight.Kit.VERSION.nupkg"  --api-key PAT --source "SOURCE_NAME"