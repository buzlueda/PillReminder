PILLREMINDER_API_VERSION="$(git rev-parse HEAD) | $(date '+%Y%m%d %H%M') | $(git rev-parse --abbrev-ref HEAD)"
(cd src/PillReminder.Presentation/PillReminder.Presentation.WebAPI && DOTNET_CLI_DO_NOT_USE_MSBUILD_SERVER=1 dotnet run --launch-profile http)