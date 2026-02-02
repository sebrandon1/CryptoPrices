# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

CryptoPrices is an ASP.NET Web Forms application that aggregates Bitcoin prices from multiple cryptocurrency exchanges. The application fetches real-time buy/sell rates and displays them with price change indicators.

### Supported Exchanges
- Mt. Gox (historical - now defunct)
- BTC-e (historical - now defunct)
- Coinbase
- Bitstamp (partial implementation)

## Technology Stack

- **Framework**: .NET Framework 4.5
- **Web Framework**: ASP.NET Web Forms
- **JSON Parsing**: Newtonsoft.Json
- **Frontend**: jQuery, jQuery UI, AJAX Control Toolkit

## Directory Structure

```
Website/CryptoPrices/
├── Classes/           # API integration classes
│   ├── CryptoCode.cs  # Main API client with exchange methods
│   ├── Coinbase_BTC.cs
│   ├── MtGox_BTC.cs
│   ├── BTCe_BTC.cs
│   ├── BTCe_LTC.cs
│   └── Bitstamp_BTC.cs
├── Scripts/           # JavaScript files
├── Styles/            # CSS stylesheets
├── Content/           # Static content
├── Default.aspx       # Main page
├── Default.aspx.cs    # Page code-behind
├── Web.config         # Application configuration
└── CryptoPrices.sln   # Visual Studio solution
```

## Code Style

### C#
- Follow standard C# naming conventions (PascalCase for public members)
- Include change log comments at the top of files
- Use try-catch blocks for API calls with fallback to 0.0 on error
- Round currency values to 2 decimal places

## Requirements

- Visual Studio (2012 or later recommended)
- .NET Framework 4.5
- Internet access for fetching cryptocurrency data from exchange APIs
