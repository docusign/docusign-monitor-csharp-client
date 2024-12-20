## [v2.0.2] - Monitor API v2.0-2.0.0 - 2024-11-15
### Changed
- Resolved an issue that prevented the use of `RequestJWTApplicationToken` with a production account URL.
- Updated C# SDK dependencies.
    - BouncyCastle.Cryptography: Version bumped from 2.3.1 to 2.4.0.
    - Microsoft.IdentityModelJsonWebTokens: Version bumped from 7.5.2 to 8.2.0.
- Updated the SDK release version.

## [v2.0.1] - Monitor API v2.0-2.0.0 - 2024-11-07
### Changed
- Fixed Deadlock issue with UI Apps (E.g. WinForms).
- Fixed deserialization issue of text/csv type response
- Removed the staging base path and OAuth path constant.
- Updated the SDK release version.

## [v2.0.0] - Monitor API v2.0-2.0.0 - 2024-07-30
### Changed
- Added support for version v2.0-2.0.0 of the DocuSign Monitor API.
- Updated the SDK release version.

## [v2.0.0-rc3] - Monitor API v2.0-2.0.0 - 2024-05-20
### Changed
- Updated C# SDK dependencies.
    - BouncyCastle.Cryptography: Version bumped from 2.3.0 to 2.3.1.
    - Microsoft.IdentityModel.JsonWebTokens: Version bumped from 7.5.1 to 7.5.2.
## [v2.0.0-rc2] - Monitor API v2.0-2.0.0 - 2024-04-29
### Breaking Changes
- Updated from System.IdentityModel.Tokens.Jwt to Microsoft.IdentityModel.JsonWebTokens for token handling.
## [v2.0.0-rc1] - Monitor API v2.0-2.0.0 - 2024-04-05
### Breaking Changes
- Updated C# SDK dependencies.
    - Microsoft.CSharp: Version bumped from 4.5.0 to 4.7.0.
    - Newtonsoft.Json: Version bumped from 13.0.1 to 13.0.3.
    - System.ComponentModel.Annotations: Version bumped from 4.5.0 to 5.0.0.
    - Microsoft.IdentityModel.Protocols: Version bumped from 5.4.0 to 7.3.1.
    - System.IdentityModel.Tokens.Jwt: Version bumped from 5.4.0 to 7.3.1.
    - BouncyCastle.Cryptography: Version bumped from 2.2.1 to 2.3.0.
### Changed
- Updated the SDK release version.

## [v1.2.1] - Monitor API v2.0-2.0.0 - 2023-12-15
### Changed
- Updated the SDK release version.
- Removed tracked files which are now present in .gitignore.

## [v1.2.0] - Monitor API v2.0-2.0.0 - 2023-06-14
### Changed
- Added support for version v2.0-2.0.0 of the DocuSign Monitor API.
- Updated the SDK release version.

## [v1.1.1] - Monitor API v2.0-1.1.0 - 2023-05-10
### Changed
- Removed support for .NET Framework 4.5.2. Miminum requirement is now .NET Framework 4.6.2
- Removed [BouncyCastle.Crypto](https://www.nuget.org/packages/BouncyCastle) and [Portable.BouncyCastle](https://www.nuget.org/packages/Portable.BouncyCastle) dependencies as they've been deprecated and added [BouncyCastle.Cryptography](https://www.nuget.org/packages/BouncyCastle.Cryptography) which is the recommended replacement and is being maintained.
- Added support for version v2.0-1.1.0 of the DocuSign Monitor API.
- Updated the SDK release version.

## [v1.1.0] - Monitor API v2.0-1.1.0 - 2022-04-11
### Changed
- Added support for version v2.0-1.1.0 of the DocuSign Monitor API.
- Updated the SDK release version.

