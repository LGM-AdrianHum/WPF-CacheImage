## Synopsis

This is a simple project that will help you build an application that needs to cache images sourced from a remote source.


## Code Example

The application consist of a valueconverter that takes a URI, and converts into an imagesource that you can use as a background or as a source for an Image. When the image is downloaded from the the source, it is saved to the cache directory, and displayed in the image box.


require 'redcarpet'
markdown = Redcarpet.new("Hello World!")
puts markdown.to_html
```xmal
&lt;UserControl xmlns=&quot;<http://schemas.microsoft.com/winfx/2006/xaml/presentation>&quot;
	xmlns:x=&quot;<http://schemas.microsoft.com/winfx/2006/xaml>&quot;
    xmlns:mc=&quot;<http://schemas.openxmlformats.org/markup-compatibility/2006>&quot;
    xmlns:d=&quot;<http://schemas.microsoft.com/expression/blend/2008>&quot;
    xmlns:u=&quot;clr-namespace:MyNamespace&quot;
d:DesignHeight=&quot;500&quot;
    d:DesignWidth=&quot;420&quot;&gt;

&lt;UserControl.Resources&gt;

:

    &lt;ResourceDictionary&gt;

    :   &lt;u:UriToCachedImageConverter
        x:Key=&quot;UrlToCachedImageConverter&quot; /&gt;

    &lt;/ResourceDictionary&gt;

&lt;/UserControl.Resources&gt;

:

    &lt;Grid&gt;

    :   &lt;Image Source=&quot;{Binding URL, Mode=OneWay,
        Converter={StaticResource UrlToCachedImageConverter},
        IsAsync=true}&quot;/&gt;

    &lt;/Grid&gt;

&lt;/UserControl&gt;
&lt;Image Source=&quot;{Binding URL, Mode=OneWay, Converter={StaticResource
UrlToCachedImageConverter}, IsAsync=true}&quot; /&gt;
```
## Motivation



## Installation

Provide code examples and explanations of how to get the project.

## API Reference

Depending on the size of the project, if it is small and simple enough the reference docs can be added to the README. For medium size to larger projects it is important to at least provide a link to where the API reference docs live.

## Tests

Describe and show how to run the tests with code examples.

## Contributors

Let people know how they can dive into the project, include important links to things like issue trackers, irc, twitter accounts if applicable.

## License

A short snippet describing the license (MIT, Apache, etc.)