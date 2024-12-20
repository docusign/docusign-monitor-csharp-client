# The Official Docusign Monitor C# Client SDK

[![Nuget version][nuget-image]][nuget-url]
[![Nuget downloads][downloads-image]][downloads-url]

The Docusign SDK makes integrating Docusign into your apps and websites a seamless experience.

## Table of Contents
- [Introduction](#introduction)
- [Installation](#installation)
	* [Version Information](#versionInformation)
	* [Requirements](#requirements)
	* [Compatibility](#compatibility)
	* [NuGet Package Manager](#nugetPackageManager)
	* [Package Manager Console](#packageManagerConsole)
- [Dependencies](#dependencies)
- [API Reference](#apiReference)
- [Code Examples](#codeExamples)
- [OAuth Implementations](#oauthImplementations)
- [Changelog](#changeLog)
- [Support](#support)
- [License](#license)
- [Additional Resources](#additionalResources)

<a id="introduction"></a>
## Introduction
Docusign Monitor helps organizations protect their agreements with round-the-clock activity tracking. The Monitor API delivers this activity tracking information directly to existing security stacks or data visualization tools—enabling teams to detect unauthorized activity, investigate incidents, and quickly respond to verified threats. It also provides the flexibility security teams need to customize dashboards and alerts to meet specific business needs.

<a id="installation"></a>
## Installation
This client SDK is provided as open source, which enables you to customize its functionality to suit your particular use case. To do so, download or clone the repository. If the SDK’s given functionality meets your integration needs, or if you’re working through our [code examples](https://developers.docusign.com/docs/monitor-api/how-to/) from the [Docusign Developer Center](https://developers.docusign.com/), you merely need to install it by following the instructions below.

<a id="versionInformation"></a>
### Version Information
- **API version**: v2.0
- **Latest SDK version (Including prerelease)**: 2.0.2

<a id="requirements"></a>
### Requirements
*   Microsoft .NET version 4.6.2+ (4.7 recommended)
*   Free [developer account](https://go.docusign.com/o/sandbox/?postActivateUrl=https://developers.docusign.com/)

<a id="compatibility"></a>
### Compatibility
*   .NET Standard 2.0. See [.NET Standard Selector](https://immo.landwerth.net/netstandard-versions/) for details on versioning for the individual components in .NET Standard.
*   .NET Core 2.0 or above.
*   Microsoft .NET version 4.6.2+.
*   TLS 1.2

<a id="nugetPackageManager"></a>
### NuGet Package Manager:
1. Create a new C# project, or open an existing one.
2. Select **Tools** -> **NuGet Package Manager** -> **Manage NuGet Packages for Solution.**
3. Search for **Docusign**.
4. Select **DocuSign.Monitor**.
5. Select the check box next to your project name.
6. Click **Install.**

<a id="packageManagerConsole"></a>
### Package Manager Console:
1. Create a new C# project, or open an existing one.
2. Open the **Package Manager Console** by either method:
   1. Clicking **Package Manager Console** along the bottom of Visual Studio
   2. Clicking **Tools** -> **NuGet Package Manager** -> **Package Manager Console**
3. In the **Package Manager Console**, type: **Install-Package DocuSign.Monitor**

<a id="dependencies"></a>
## SDK Dependencies
This client has the following external dependencies:

### .NET Standard v2 and .NET Core:
*   Newtonsoft.Json v13.0.3
*   BouncyCastle.Cryptography v2.3.1
*   System.ComponentModel.Annotations v5.0.0
*   Microsoft.IdentityModel.JsonWebTokens v7.5.2

### .NET Framework, version 4.6.2:
*   Newtonsoft.Json v13.0.3
*   BouncyCastle.Cryptography v2.3.1
*   System.ComponentModel.Annotations v5.0.0
*   Microsoft.IdentityModel.JsonWebTokens v7.5.2

<a id="apiReference"></a>
## API Reference
You can refer to the API reference [here](https://developers.docusign.com/docs/monitor-api/reference/).

<a id="codeExamples"></a>
## Code Examples
Explore our GitHub repository for the [Launcher](https://github.com/docusign/code-examples-csharp/), a self-executing package housing code examples for the Monitor C# SDK. This package showcases several common use cases and their respective source files. Additionally, you can download a version preconfigured for your Docusign developer account from [Quickstart](https://developers.docusign.com/docs/esign-rest-api/quickstart/). These examples support both the [Authorization Code Grant](https://developers.docusign.com/platform/auth/authcode/) and [JSON Web Token (JWT)](https://developers.docusign.com/platform/auth/jwt/) authentication workflows.

<a id="oauthImplementations"></a>
## OAuth Implementations
For details regarding which type of OAuth grant will work best for your Docusign integration, see [Choose OAuth Type](https://developers.docusign.com/platform/auth/choose/) in the [Docusign Developer Center](https://developers.docusign.com/).

For security purposes, Docusign recommends using the [Authorization Code Grant](https://developers.docusign.com/platform/auth/authcode/) flow.

<a id="changeLog"></a>
## Changelog
You can refer to the complete changelog [here](https://github.com/docusign/docusign-monitor-csharp-client/blob/master/CHANGELOG.md).

<a id="support"></a>
## Support
Log issues against this client SDK through GitHub. You can also reach out to us through [Docusign Community](https://community.docusign.com/developer-59) and [Stack Overflow](https://stackoverflow.com/questions/tagged/docusignapi).

<a id="license"></a>
## License
The Docusign Monitor C# Client SDK is licensed under the [MIT License](https://github.com/docusign/docusign-monitor-csharp-client/blob/master/LICENSE).

<a id="additionalResources"></a>
## Additional resources
*   [Docusign Developer Center](https://developers.docusign.com/)
*   [Docusign API on Twitter](https://twitter.com/docusignapi)
*   [Docusign For Developers on LinkedIn](https://www.linkedin.com/showcase/docusign-for-developers/)
*   [Docusign For Developers on YouTube](https://www.youtube.com/channel/UCJSJ2kMs_qeQotmw4-lX2NQ)

[nuget-image]: https://img.shields.io/nuget/v/DocuSign.Monitor.svg?style=flat
[nuget-url]: https://www.nuget.org/packages/DocuSign.Monitor
[downloads-image]: https://img.shields.io/nuget/dt/DocuSign.Monitor.svg?style=flat
[downloads-url]: https://www.nuget.org/packages/DocuSign.Monitor