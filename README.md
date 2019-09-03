# LazZiya.TagHelpers.Localization
Use html tag to localize texts and html contents in razor pages for Asp.Net Core 3 web applications 

## Installation
````
Install-Package LazZiya.TagHelpers.Localization -Version 1.1.0-preview1
````
Then inject localize tag helper in *_ViewImports.cshtml* file
````razor
addTagHelpers *, LazZiya.TagHelpers.Localization
````

## Localize TagHelper Usage
Use localize tag directly:
````razor
<localize>Hellow world!</localize>
````

Use localize attributes in any html tag:
````razor
<h1 localize-content>Hello world!</h1>
````

Localize html contents:
````razor
<div localize-content>
    <h2>Title</h2>
    <p>Details...</p>
</div>
````

Use localization args:
````razor
<p localize-args="@(new object[] { 123, DateTime.Now })">
    The number is {0}, the date is {1}
</p>
````

Localize attributes e.g. alt attribute:
````razor
<img src="/images/lost-image.png" localize-att-alt="Cake and juice image" />
````

## dependencies
Two nuget packages will be installed automatically with TagHelpers.Localization :

- [LazZiya.ExpressLocalization](https://github.com/lazziya/ExpressLocalization) : required for localization setup
- [LazZiya.TagHelpers](https://github.com/lazziya/TagHelpers) : main TagHelpers package

Check for updates after install.

## Localization Setup
In order for localize tag helper to work the localization setup must be done in startup.cs as described in [LazZiya.ExpressLocalization](https://github.com/lazziya/ExpressLocalization)

# Live demos:
http://demo.ziyad.info/en/localize
