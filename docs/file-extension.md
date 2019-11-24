<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /docs/mdsource/file-extension.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# File extension

The default file extension is `.txt`. So the resulting verified file will be `TestClass.TestMethod.verified.txt`.

It can be overridden at two levels:

 * Method: Change the extension for the current test method.
 * Class: Change the extension all verifications in all test methods for a test class.

Usage:

<!-- snippet: ExtensionSample.cs -->
<a id='snippet-ExtensionSample.cs'/></a>
```cs
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

public class ExtensionSample :
    VerifyBase
{
    [Fact]
    public async Task AtMethod()
    {
        UseExtensionForText(".xml");
        await Verify(@"<note>
<to>Joe</to>
<from>Kim</from>
<heading>Reminder</heading>
</note>");
    }

    [Fact]
    public async Task InheritedFromClass()
    {
        await Verify(@"{
    ""fruit"": ""Apple"",
    ""size"": ""Large"",
    ""color"": ""Red""
}");
    }

    public ExtensionSample(ITestOutputHelper output) :
        base(output)
    {
        UseExtensionForText(".json");
    }
}
```
<sup>[snippet source](/src/Verify.Xunit.Tests/ExtensionSample.cs#L1-L35) / [anchor](#snippet-ExtensionSample.cs)</sup>
<!-- endsnippet -->

Result in two files:

<!-- snippet: ExtensionSample.InheritedFromClass.verified.json -->
<a id='snippet-ExtensionSample.InheritedFromClass.verified.json'/></a>
```json
{
    "fruit": "Apple",
    "size": "Large",
    "color": "Red"
}
```
<sup>[snippet source](/src/Verify.Xunit.Tests/ExtensionSample.InheritedFromClass.verified.json#L1-L5) / [anchor](#snippet-ExtensionSample.InheritedFromClass.verified.json)</sup>
<!-- endsnippet -->

<!-- snippet: ExtensionSample.AtMethod.verified.xml -->
<a id='snippet-ExtensionSample.AtMethod.verified.xml'/></a>
```xml
<note>
<to>Joe</to>
<from>Kim</from>
<heading>Reminder</heading>
</note>
```
<sup>[snippet source](/src/Verify.Xunit.Tests/ExtensionSample.AtMethod.verified.xml#L1-L5) / [anchor](#snippet-ExtensionSample.AtMethod.verified.xml)</sup>
<!-- endsnippet -->