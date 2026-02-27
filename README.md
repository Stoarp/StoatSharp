# StoatSharp (Stoarp Fork)

A C# client library for the [Stoat](https://stoat.chat/) chat API, forked from [FluxpointDev/StoatSharp](https://github.com/FluxpointDev/StoatSharp) and modified for use as a user client library in Stoarp.

## What changed

The upstream library targets bot development. This fork strips bot-specific code to focus on user account sessions:

- **Removed** `RevoltSharp.Commands` (bot command framework), `RevoltSharp.InstanceAdmin`, `RevoltSharp.Challenge`, and `TestBot`
- **Removed** bot auth path — only `x-session-token` is used, no `x-bot-token`
- **Removed** `PublicBot` model and `GetPublicBotAsync()`
- **Removed** bot-specific config (`Owners`, `OwnerBypassPermissions`)
- **Kept** core REST/WebSocket client, voice support, and all user-facing features (login, MFA, sessions, friends, DMs, servers, etc.)
