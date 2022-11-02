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

>* indicate that we can choose any of the names that are available

## @Blazor server
>Description coming
### OBJECTSOCIAL.Server

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
### BadClaims.Browser
>Description coming
## @OBJECTSOCIAL
>Description coming
### @Product
>We must have control on which platform the system works.
#### Name.cs
>Our project names

|Value|ID|
|-|-|
|ForwardOBJECTSOCIAL|0|
|OBJECTSOCIAL|1|
|MemoryClaims|2|
|GoodClaims|3|
|BadClaims|4|
#### Product
>This is made so that we can keep track of which system the user accesses.
#### Product.Server
>Description coming
