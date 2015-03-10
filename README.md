## Box OAuth2 Workflow Sample for ASP.Net 

This repository provides a complete example ASP.Net MVC-based example of how to navigate the 
[Box OAuth2 authentication flow](https://developers.box.com/docs/#oauth-2).
You will need to [create a Box application](https://box.com/developers/services/edit/) if 
you haven't already.

## Try It Out

### Option A: Use the Demo Version

1. Set the `redirect_uri` of your Box application to `https://box-oauth2-mvc.azurewebsites.net`
1. Browse to [https://box-oauth2-mvc.azurewebsites.net](https://box-oauth2-mvc.azurewebsites.net), set your client ID and secret, and click **Authorize** to kick off the workflow.

### Option B: Build It Yourself

Open this solution in Visual Studio and press `F5` to start the site.

*Nota bene*: Part of the OAuth2 workflow involves an HTTPS redirect from Box's site to the 
one you'll be running here. The URL of *this* demo site *must* be registered 
with Box in order for everything to work. (This pre-registration is done in 
order to prevent rogue redirects; it's part of the OAuth2 spec.)  However, 
Visual Studio doesn't enable SSL by default, so there are a few steps 
required to make it all work.

*Enable SSL connections in your project*

1.  In the Solution Explorer, left-click on this project to select it.
2.  Press F4 to bring up the project's Properties.
3.  Change 'SSL Enabled' from False to True.  The SSL URL field should be automatically populated.
4.  Copy the SSL URL to the clipboard.

*Configure your project to start with the SSL URL*

5.  Now right-click on the project name and select 'Properties'
6.  Click the 'Web' tab
7.  In the 'Servers' section find the text box labeled 'Project Url'
8.  Paste the SSL URL into this text box and save the changes.

*Configure your Box application to redirect to the SSL URL*

9.  Browse to http://developers.box.com
10.  Click on "My Box Apps" on the upper right; log in.1
11.  Edit the application that you want to work with.
12.  Under 'OAuth2 Parameters' locate the 'redirect_uri' field.
13.  Paste the SSL URL into this field.  Save your changes.

This configures your app to use SSL and tells Box to redirect you back to this
HTTPS site after you've authenticated and agreed to let your application 
access your Box data.

Ok, that's it -- everything should be ready to go now.  You might want to 
keep the browser window open that contains your Box application's Client
ID and Client Secret; you'll need those in a moment.

Press F5 to get started!

## About

Created by John Hoerr at Indiana University for the Box community. 
jhoerr@iu.edu / @johnhoerr

## License

The MIT License (MIT)

Copyright (c) 2014 The Trustees of Indiana University

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.




