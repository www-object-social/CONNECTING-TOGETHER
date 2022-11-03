# CONNECTING TOGETHER
>We want to create a platform that everyone can connect to.
>But also want to connect to others.
>We believe that people have a job or are looking for one.
>OBJECT:SOCIAL
>We believe that there are 2 types of inner personality.
>Good|Claims and Bad|Claims.
>We all have memory, we need to store it somewhere to share and be remembered.
>Memory|Claims
>Become part of us.
>We are looking for all types of talent.
>become-part-of-us@object.social 
>Maybe we are taking a long time to answer. "sorry about this".

## Assembly names
>Relationship structures with names

|Name|Note|
|-|-|
|*.Server|Only for server|
|*.Browser|Only for browser|
|*.Software|Only for software|
|*.OS|Only for browser and software|
| |For browser,software and server|

> "*" indicate that we can choose any of the names that are available. but these names must not be used "Server", "Browser", "Software" and "OS"

## @Blazor server
### OBJECTSOCIAL.Server
|Domain|
|-|
|object.social|

|Dependencies|
|-|
|@Blazor browser/BadClaims.Browser|
|@OBJECTSOCIAL/@Product/Product.Server|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.OBJECTSOCIAL
```
### ForwardOBJECTSOCIAL.Server
>Used for short Domain names requested by an investor DK33497326 - MB Revision ApS - Hornevej 7 - 2770 Kastrup - Denmark

|Domain|
|-|
|myos.work|
|osmy.work|
|myos.world|
|osmy.world|

|Dependencies|
|-|
|@Blazor browser/ForwardOBJECTSOCIAL.Browser|
|@OBJECTSOCIAL/@Product/Product.Server|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.ForwardOBJECTSOCIAL
```
### MemoryClaims.Server

|Domain|
|-|
|memory.claims|

|Dependencies|
|-|
|@Blazor browser/MemoryClaims.Browser|
|@OBJECTSOCIAL/@Product/Product.Server|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.MemoryClaims
```
### GoodClaims.Server
|Domain|
|-|
|good.claims|

|Dependencies|
|-|
|@Blazor browser/GoodClaims.Browser|
|@OBJECTSOCIAL/@Product/Product.Server|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.GoodClaims
```
### BadClaims.Server
|Domain|
|-|
|bad.claims|

|Dependencies|
|-|
|@Blazor browser/BadClaims.Browser|
|@OBJECTSOCIAL/@Product/Product.Server|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.BadClaims
```

## @Blazor software

### OBJECTSOCIAL.Software
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Software|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.OBJECTSOCIAL
```
### MemoryClaims.Software
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Software|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.MemoryClaims
```
### GoodClaims.Software


|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Software|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.GoodClaims
```
### BadClaims.Software
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Software|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.BadClaims
```
## @Blazor browser
>Description coming
### OBJECTSOCIAL.Browser
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.OBJECTSOCIAL
```
### ForwardOBJECTSOCIAL.Browser
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.ForwardOBJECTSOCIAL
```
### MemoryClaims.Browser
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.MemoryClaims
```
### GoodClaims.Browser
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.GoodClaims
```
### BadClaims.Browser
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.BadClaims
```

## @OBJECTSOCIAL
### @Layout
#### Layout.OS
|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product.Hologram.OS|
### @Device
#### Device.Software
> This contain setting for Microsoft platform
### @Product
>We must have control on which platform the system works.
#### Product
>This is made so that we can keep track of which system the user accesses.
##### Name.cs
>Our project names
|Value|ID|
|-|-|
|ForwardOBJECTSOCIAL|0|
|OBJECTSOCIAL|1|
|MemoryClaims|2|
|GoodClaims|3|
|BadClaims|4|
##### Environment.cs
>Our Environment names
|Value|ID|
|-|-|
|Software|0|
|Browser|1|
|Server|2|
##### Dependency.cs
Should only be used if Environment is Software, Browser and Server
#### Product.Server
>Shortcut for environment Server

|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product|

```
@OBJECTSOCIAL/@Product/Environment.cs
Product.Environment.Server
```

##### Dependency.cs
>Should only be used if Environment is Server
#### Product.Browser
>Shortcut for environment Browser

|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product|
|@OBJECTSOCIAL/@Product/Product.OS|

```
@OBJECTSOCIAL/@Product/Environment.cs
Product.Environment.Browser
```

##### Dependency.cs
>Should only be used if Environment is Browser
#### Product.Software
>Shortcut for environment Software

|Dependencies|
|-|
|@OBJECTSOCIAL/@Product/Product|
|@OBJECTSOCIAL/@Product/Product.OS|

```
@OBJECTSOCIAL/@Product/Environment.cs
Product.Environment.Software
```

##### Dependency.cs
>Should only be used if Environment is Software

#### Product.OS
|Dependencies|
|-|
|@OBJECTSOCIAL/@Layout/Layout.OS|

##### Dependency.cs
>Should only be used if Environment is Software and Browser
##### Product.Hologram.OS