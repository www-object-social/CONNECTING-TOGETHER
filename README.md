# CONNECTING TOGETHER
>Description coming

## Assembly names
>Relationship structures with names

|Name|Note|
|-|-|
|*.Server|Only for server|
|*.Browser|Only for browser|
|*.Software|Only for software|
|*.OS|Only for browser and software|
| |For browser,software and server|

> "*" indicate that we can choose any of the names that are available

## @Blazor server
>Description coming
### OBJECTSOCIAL.Server
>Description coming

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
>Description coming

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
>Description coming

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
>Description coming

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
>Description coming

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
>Description coming
## @Blazor browser
>Description coming
### OBJECTSOCIAL.Browser
>Description coming

|Dependencies|
|-|
|@OBJECTSOCIAL/Layout.OS|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.OBJECTSOCIAL
```
### ForwardOBJECTSOCIAL.Browser
>Description coming

|Dependencies|
|-|
|@OBJECTSOCIAL/Layout.OS|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.ForwardOBJECTSOCIAL
```
### MemoryClaims.Browser
>Description coming

|Dependencies|
|-|
|@OBJECTSOCIAL/Layout.OS|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.MemoryClaims
```
### GoodClaims.Browser
>Description coming

|Dependencies|
|-|
|@OBJECTSOCIAL/Layout.OS|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.GoodClaims
```
### BadClaims.Browser
>Description coming

|Dependencies|
|-|
|@OBJECTSOCIAL/Layout.OS|
|@OBJECTSOCIAL/@Product/Product.Browser|

```
@OBJECTSOCIAL/@Product/Name.cs
Product.Name.BadClaims
```

## @OBJECTSOCIAL
>Description coming
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
>Shortcut for environment server

|Dependencies|
|-|
|@Product/Product|

```
@OBJECTSOCIAL/@Product/Environment.cs
Product.Environment.Server
```

##### Dependency.cs
> Should only be used if Environment is Server

#### Product.Browser
>Shortcut for environment server

|Dependencies|
|-|
|@Product/Product|
|@Product/Product.OS|

```
@OBJECTSOCIAL/@Product/Environment.cs
Product.Environment.Browser
```

##### Dependency.cs
> Should only be used if Environment is Server
#### Product.OS
>Shortcut for environment server
##### Dependency.cs
> Should only be used if Environment is Software and Browser