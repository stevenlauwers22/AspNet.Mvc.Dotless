#AspNet.Mvc.Dotless - Using dotless in an ASP.NET MVC application

---

### Install dotless

From the NuGet Package Manager Console:

    Install-Package dotless.Core

### Register the dotless HTTP handler

Add the following sections to your config file.
The dotless HTTP handler intercepts all HTTP requests to files that end with .less
The handler will get the content of the .less file and transform it into proper css
	
    <!-- Classic mode -->
    <system.web>
      <httpHandlers>
        <add path="*.less" verb="GET" type="dotless.Core.LessCssHttpHandler, dotless.Core" />
      </httpHandlers>
    </system.web>
  
	<!-- Integrated pipeline mode -->
    <system.webServer>
      <handlers>
        <add name="dotless" path="*.less" verb="GET" type="dotless.Core.LessCssHttpHandler, dotless.Core" resourceType="File" preCondition="" />
      </handlers>
    </system.webServer>
	
### Configure dotless

Add the following sections to your config file.

    <configSections>
      <section name="dotless" type="dotless.Core.configuration.DotlessConfigurationSectionHandler, dotless.Core" />
    </configSections>

    <dotless minifyCss="false" cache="true" web="true" />
	
### Create a dotless stylesheet called Site.less

    @brand_color: #4D926F;

    .header 
    {
        background-color: @brand_color;
	    color: white;
	    padding: 5px;
    }
	
### Reference the dotless stylesheet in your views

    <link href="~/Stylesheets/Site.less" rel="stylesheet" type="text/css" />