
# LazZiya.TagHelpers.Localization
Use html tag to localize texts and html contents in razor pages for Asp.Net Core web applications. And automatically have the `{culture}` parameter added to route values for every anchor.

## Release history
- v1.3.0 - 04.01.2020
- New breaking change - [CultureAnchoreTagHelper](#cultureanchortaghelper) : Automatically add `{culture}` to the route values of all anchor taghelpers. 

## Installation
````
Install-Package LazZiya.TagHelpers.Localization
````
Then inject localize tag helper in *_ViewImports.cshtml* file
````razor
addTagHelpers *, LazZiya.TagHelpers.Localization

@* IMPORTANT : starting from v1.3.0 *@
@removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
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

## CultureAnchorTagHelper
Starting from v1.3.0 it is not necessary to manually add `asp-route-culture="culture"` to every link. With the new built-in [`CultureAnchorTagHelper`][2] the current culture will be added to the route value automatically.

````html
<a localize-content asp-page="/Index">Home</a>
````

This change requires removing the default [`AnchorTagHelper`][3] from `_ViewImports` :
````
@removeTagHelper Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper, Microsoft.AspNetCore.Mvc.TagHelpers
````

If you still want to use the default [`AnchorTagHelper`][3] just remove the [`CultureAnchorTagHelper`][2] from `_ViewImports` :
````
@removeTagHelper LazZiya.TagHelpers.Localization.CultureAnchorTagHelper, LazZiya.TagHelpers.Localization
````
But in this case you will need to manually add `asp-route-culture="..."` to every link.

````html
<a localize-content asp-page="/Index" asp-route-culture="@culture">Home</a>
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

[1]: https://github.com/LazZiya/TagHelpers.Localization/tree/TagHelpersLocalizationCore3
[2]: https://github.com/LazZiya/TagHelpers.Localization/blob/master/LazZiya.TagHelpers.Localization/CultureAnchorTagHelper.cs
[3]: https://github.com/aspnet/Mvc/blob/master/src/Microsoft.AspNetCore.Mvc.TagHelpers/AnchorTagHelper.cs
