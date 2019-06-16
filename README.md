# TagHelpers.Localization
Use html tag to localize texts and html contents in razor views

## Installation
````
Install-Package LazZiya.TagHelpers.Localization -Version 1.0.0
````

## Usage
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
<img src="/images/lost-image.png" localize-att-alt="Cake and kuice image" />
````

# Live demos:
http://demo.ziyad.info/en/localize
