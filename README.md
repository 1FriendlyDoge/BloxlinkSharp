# BloxlinkSharp
> Wrapper for the [Bloxlink API](https://www.blox.link/dashboard/user/developer).

## Getting Started
> ### Using Constructor:
> ```csharp
> new Bloxlink("your_api_key") // string apiKey, string baseUrl = "https://api.blox.link/v4/"
>     .Build()
> ```

> ### Using Environment:
> ```csharp
> new Bloxlink()
>     .UseAuthEnvironment() // BloxlinkBaseURL (default: https://api.blox.link/v4/)
>     .UseBaseUrlEnvironment() // BloxlinkAuth
>     .Build();
> ```

It is required to always call `.Build()` after setting all values to ensure the client is setup correctly.

## Functions
For all examples in this category we will assume that there is an object of the `Bloxlink` class that
is already initialized and has a valid authentication token named `bloxlink`.

> ### Return Values:
> All return values from API fetch functions are wrapped in the generic type `BloxlinkResponse<T>`
> that has a field called `StatusCode` (type: `HttpStatusCode`) and a field named `Data` which contains the
> data fetched from the API.

> #### Perform a lookup for the Discord user and resolve their Roblox ID. This user must be in your Discord server.
> #### `BaseURL/public/guilds/{ServerID}/discord-to-roblox/{UserID}`
> ```csharp
> // Sync
> BloxlinkResponse<RobloxResolve> r = bloxlink.DiscordToRoblox(987798554972143728, 333991360199917568).Result;
> 
> // Async
> BloxlinkResponse<RobloxResolve> r = await bloxlink.DiscordToRoblox(987798554972143728, 333991360199917568);
> ```

## Models
> #### RobloxResolve
> ```json
> {
>   "RobloxID": "string", // string (nullable)
>   "Resolved": { // [!!!] BLOXLINK PREMIUM ONLY [!!!]
>     "Discord": {
>       "Avatar": "string", // string (nullable)
>       "CommunicationDisabledUntil": null, // object (nullable)
>       "Flags": 0, // int
>       "JoinedAt": "0001-01-01T00:00:00", // DateTime
>       "Nick": "string", // string (nullable)
>       "Pending": false, // bool
>       "PremiumSince": null, // object (nullable)
>       "Roles": ["string"], // List<string>
>       "UnusualDmActivityUntil": null, // object (nullable)
>       "DiscordUser": {
>         "Id": "string", // string (nullable)
>         "Username": "string", // string (nullable)
>         "Avatar": "string", // string (nullable)
>         "Discriminator": "string", // string (nullable)
>         "PublicFlags": 0, // int
>         "Flags": 0, // int
>         "Banner": "string", // string (nullable)
>         "AccentColor": 0, // int
>         "GlobalName": "string", // string (nullable)
>         "AvatarDecorationData": null, // object (nullable)
>         "BannerColor": "string" // string (nullable)
>       },
>       "Mute": false, // bool
>       "Deaf": false // bool
>     },
>     "Roblox": {
>       "Name": "string", // string (nullable)
>       "Id": 0, // int
>       "DisplayName": "string", // string (nullable)
>       "Description": "string", // string (nullable)
>       "IsBanned": false, // bool
>       "Created": "0001-01-01T00:00:00", // DateTime
>       "Badges": [ // List<Badge>
>         {
>           "ImageUri": "string", // string (nullable)
>           "Name": "string" // string (nullable)
>         }
>       ],
>       "ProfileLink": "string", // string (nullable)
>       "Presence": null, // object (nullable)
>       "Groups": [ // List<Group>
>         {
>           "Group": {
>             "Id": 0, // int
>             "Name": "string", // string (nullable)
>             "MemberCount": 0, // int
>             "HasVerifiedBadge": false // bool
>           },
>           "Role": {
>             "Id": 0, // int
>             "Name": "string", // string (nullable)
>             "Rank": 0 // int
>           }
>         }
>       ],
>       "Avatar": {
>         "BustThumbnail": "string", // string (nullable)
>         "HeadshotThumbnail": "string", // string (nullable)
>         "FullBody": "string" // string (nullable)
>       },
>       "Rap": null, // object (nullable)
>       "Value": null, // object (nullable)
>       "PlaceVisits": null, // object (nullable)
>       "HasDisplayName": false, // bool
>       "ExternalAppDisplayName": null, // object (nullable)
>       "HasVerifiedBadge": false, // bool
>       "Groupsv2": { // Dictionary<string, GroupV2>
>         "Key": {
>           "Group": {
>             "Id": 0, // int
>             "Name": "string", // string (nullable)
>             "MemberCount": 0, // int
>             "HasVerifiedBadge": false // bool
>           },
>           "Role": {
>             "Id": 0, // int
>             "Name": "string", // string (nullable)
>             "Rank": 0 // int
>           }
>         }
>       }
>     }
>   }
> }
> ```