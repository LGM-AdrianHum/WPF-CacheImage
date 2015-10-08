## Synopsis

This is a simple project that will help you build an application that needs to cache images sourced from a remote source.


## Code Example

The application consist of a valueconverter that takes a URI, and converts into an imagesource that you can use as a background or as a source for an Image. When the image is downloaded from the the source, it is saved to the cache directory, and displayed in the image box.

```xml
<UserControl xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
             xmlns:u="clr-namespace:MyNamespace"
             d:DesignHeight="500"
             d:DesignWidth="420">
    <UserControl.Resources>
        <ResourceDictionary>
            <u:UriToCachedImageConverter x:Key="UrlToCachedImageConverter" />
        </ResourceDictionary>
    </UserControl.Resources>
</UserControl>

<Image Source="{Binding URL,
                Mode=OneWay,
                Converter={StaticResource UrlToCachedImageConverter},
                IsAsync=true}"/>

```




