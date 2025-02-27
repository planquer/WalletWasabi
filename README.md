![](https://i.imgur.com/4GO7nnY.png)

| Code Quality           | Windows Tests           | Linux Tests             | macOS Tests             | Continuous Delivery       | Deterministic builds      | License                   |
| :----------------------| :-----------------------| :-----------------------| :-----------------------| :-------------------------| :-------------------------| :-------------------------|
| [![CodeFactor][9]][10] | [![Build Status][1]][2] | [![Build Status][3]][4] | [![Build Status][5]][6] | [![Build Status][11]][12] | [![Build Status][13]][14] | [![GitHub license][7]][8] |

[1]: https://dev.azure.com/zkSNACKs/Wasabi/_apis/build/status/Wasabi.Windows?branchName=master
[2]: https://dev.azure.com/zkSNACKs/Wasabi/_build?definitionId=3
[3]: https://dev.azure.com/zkSNACKs/Wasabi/_apis/build/status/Wasabi.Linux?branchName=master
[4]: https://dev.azure.com/zkSNACKs/Wasabi/_build?definitionId=1
[5]: https://dev.azure.com/zkSNACKs/Wasabi/_apis/build/status/Wasabi.Osx?branchName=master
[6]: https://dev.azure.com/zkSNACKs/Wasabi/_build?definitionId=2
[7]: https://img.shields.io/github/license/zkSNACKs/WalletWasabi.svg
[8]: https://github.com/zkSNACKs/WalletWasabi/blob/master/LICENSE.md
[9]: https://www.codefactor.io/repository/github/zksnacks/walletwasabi/badge
[10]: https://www.codefactor.io/repository/github/zksnacks/walletwasabi
[11]: https://dev.azure.com/zkSNACKs/Wasabi/_apis/build/status/Wasabi.ContinuousDelivery?branchName=master
[12]: https://dev.azure.com/zkSNACKs/Wasabi/_build/latest?definitionId=12&branchName=master
[13]: https://dev.azure.com/zkSNACKs/Wasabi/_apis/build/status/Wasabi.DeterministicBuild?branchName=master
[14]: https://dev.azure.com/zkSNACKs/Wasabi/_build/latest?definitionId=13&branchName=master

[Wasabi Wallet](https://wasabiwallet.io) is an open-source, non-custodial, privacy-focused Bitcoin wallet for desktop.

![](https://i.imgur.com/4tazbiF.png)

Note that [Wasabi Wallet 2.0](https://blog.wasabiwallet.io/wasabi-wallet-2/) is in the works, which means some code you may want to work on is about to be obsoleted. The most affected code is the UI and CoinJoin parts.

For more information, please check out the [Wasabi Documentation](https://docs.wasabiwallet.io), an archive of knowledge about the nuances of Bitcoin privacy and how to use Wasabi.

# [Download Wasabi](https://github.com/zkSNACKs/WalletWasabi/releases)

# Build From Source Code

## Get The Requirements

1. Get Git: https://git-scm.com/downloads
2. Get .NET 5.0 SDK: https://www.microsoft.com/net/download
3. Optionally disable .NET's telemetry by typing `export DOTNET_CLI_TELEMETRY_OPTOUT=1` on Linux and macOS or `setx DOTNET_CLI_TELEMETRY_OPTOUT 1` on Windows.

## Get Wasabi

Clone & Restore & Build

```sh
git clone https://github.com/zkSNACKs/WalletWasabi.git
cd WalletWasabi/WalletWasabi.Gui
dotnet build
```

## Run Wasabi

Run Wasabi with `dotnet run` from the `WalletWasabi.Gui` folder.

## Update Wasabi

```sh
git pull
```
