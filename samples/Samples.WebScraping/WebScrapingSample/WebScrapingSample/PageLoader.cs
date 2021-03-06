﻿namespace WebScrapingSample
{
	using System.Collections.Generic;
	using HtmlAgilityPack;

	public class PageLoader
    {
	    public IEnumerable<HtmlNode> GetHtmlNodes(string url)
	    {
		    var web = new HtmlWeb();
		    var doc = web.Load(url);
		    //return doc.DocumentNode.Descendants();


            var html = @"






<!DOCTYPE html>
<html lang=""en"">
  <head>
    <meta charset=""utf-8"">
  <link rel=""dns-prefetch"" href=""https://assets-cdn.github.com"">
  <link rel=""dns-prefetch"" href=""https://avatars0.githubusercontent.com"">
  <link rel=""dns-prefetch"" href=""https://avatars1.githubusercontent.com"">
  <link rel=""dns-prefetch"" href=""https://avatars2.githubusercontent.com"">
  <link rel=""dns-prefetch"" href=""https://avatars3.githubusercontent.com"">
  <link rel=""dns-prefetch"" href=""https://github-cloud.s3.amazonaws.com"">
  <link rel=""dns-prefetch"" href=""https://user-images.githubusercontent.com/"">



  <link crossorigin=""anonymous"" href=""https://assets-cdn.github.com/assets/frameworks-a4bf54bef6fb.css"" integrity=""sha512-pL9Uvvb7LMqGC8jv/AyqZ7Ya6/HTgkhZzKwEsHOdsfaW2pr3fgzqjgKUSJfYkZ/klxwHrcu+tZwtNDTuw8vH6Q=="" media=""all"" rel=""stylesheet"" />
  <link crossorigin=""anonymous"" href=""https://assets-cdn.github.com/assets/github-ff942f0a548a.css"" integrity=""sha512-/5QvClSKPnKUdBhNhO39Uy5y0+qAalfcZs808ORs/YRl8VEBSnQFbvJf6C0/g4Ym5UtnviJHse30UBFAQbMNjw=="" media=""all"" rel=""stylesheet"" />
  
  
  
  

  <meta name=""viewport"" content=""width=device-width"">
  
  <title>apetrovskiy/JdiCodeGenerator: This is a tool to generate code for JDI-based tests</title>
  <link rel=""search"" type=""application/opensearchdescription+xml"" href=""/opensearch.xml"" title=""GitHub"">
  <link rel=""fluid-icon"" href=""https://github.com/fluidicon.png"" title=""GitHub"">
  <meta property=""fb:app_id"" content=""1401488693436528"">

    
    <meta content=""https://avatars2.githubusercontent.com/u/2947151?s=400&amp;v=4"" property=""og:image"" /><meta content=""GitHub"" property=""og:site_name"" /><meta content=""object"" property=""og:type"" /><meta content=""apetrovskiy/JdiCodeGenerator"" property=""og:title"" /><meta content=""https://github.com/apetrovskiy/JdiCodeGenerator"" property=""og:url"" /><meta content=""JdiCodeGenerator - This is a tool to generate code for JDI-based tests"" property=""og:description"" />

  <link rel=""assets"" href=""https://assets-cdn.github.com/"">
  <link rel=""web-socket"" href=""wss://live.github.com/_sockets/VjI6MjUxNDQ1NTc3OjAzZjUyYjg1NTM2YjI0MTVkNzBhZjk4ZGE3ZWFlOGYyN2ZjZGNmNDU5ZjE0OTI5Y2Y3YzVjZTM0YjU2NWI3MjA=--5844e5a3682b162d36eb87e0937a938f1540fd3e"">
  <meta name=""pjax-timeout"" content=""1000"">
  <link rel=""sudo-modal"" href=""/sessions/sudo_modal"">
  <meta name=""request-id"" content=""FA25:3B35:1C7ED1A:367A33C:5A996B36"" data-pjax-transient>
  

  <meta name=""selected-link"" value=""repo_source"" data-pjax-transient>

    <meta name=""google-site-verification"" content=""KT5gs8h0wvaagLKAVWq8bbeNwnZZK1r1XQysX3xurLU"">
  <meta name=""google-site-verification"" content=""ZzhVyEFwb7w3e0-uOTltm8Jsck2F5StVihD0exw2fsA"">
  <meta name=""google-site-verification"" content=""GXs5KoUUkNCoaAZn7wPN-t01Pywp9M3sEjnt_3_ZWPc"">
    <meta name=""google-analytics"" content=""UA-3769691-2"">

<meta content=""collector.githubapp.com"" name=""octolytics-host"" /><meta content=""github"" name=""octolytics-app-id"" /><meta content=""https://collector.githubapp.com/github-external/browser_event"" name=""octolytics-event-url"" /><meta content=""FA25:3B35:1C7ED1A:367A33C:5A996B36"" name=""octolytics-dimension-request_id"" /><meta content=""iad"" name=""octolytics-dimension-region_edge"" /><meta content=""iad"" name=""octolytics-dimension-region_render"" /><meta content=""18421129"" name=""octolytics-actor-id"" /><meta content=""yuliapetrova"" name=""octolytics-actor-login"" /><meta content=""76aa339e874f81eb8d3a6fea6bbc3f14e60d5a094cf690107c9e3a0b78c16c54"" name=""octolytics-actor-hash"" />
<meta content=""https://github.com/hydro_browser_events"" name=""hydro-events-url"" />
<meta content=""/&lt;user-name&gt;/&lt;repo-name&gt;"" data-pjax-transient=""true"" name=""analytics-location"" />




  <meta class=""js-ga-set"" name=""dimension1"" content=""Logged In"">


  

      <meta name=""hostname"" content=""github.com"">
    <meta name=""user-login"" content=""yuliapetrova"">

      <meta name=""expected-hostname"" content=""github.com"">
    <meta name=""js-proxy-site-detection-payload"" content=""NmY4YzFjZWExMmE1YTVkNzMzZmZhMjk5MjgwNjY4MjliNjVhNzMzMjdhYTRiYjJhY2UwNjM4ZDM0ZjcwNjFhYXx7InJlbW90ZV9hZGRyZXNzIjoiMTUyLjE2Ny4yNTQuMTE0IiwicmVxdWVzdF9pZCI6IkZBMjU6M0IzNToxQzdFRDFBOjM2N0EzM0M6NUE5OTZCMzYiLCJ0aW1lc3RhbXAiOjE1MjAwMDM5MDEsImhvc3QiOiJnaXRodWIuY29tIn0="">

    <meta name=""enabled-features"" content=""UNIVERSE_BANNER,FREE_TRIALS,MARKETPLACE_INSIGHTS,MARKETPLACE_INSIGHTS_CONVERSION_PERCENTAGES"">

  <meta name=""html-safe-nonce"" content=""de16af3228e64806ae779ca83cf948d94e7d97ab"">

  <meta http-equiv=""x-pjax-version"" content=""1e39fd59633cd2488c4b3cc8ba504eed"">
  

      <link href=""https://github.com/apetrovskiy/JdiCodeGenerator/commits/master.atom"" rel=""alternate"" title=""Recent Commits to JdiCodeGenerator:master"" type=""application/atom+xml"">

  <meta name=""description"" content=""JdiCodeGenerator - This is a tool to generate code for JDI-based tests"">
  <meta name=""go-import"" content=""github.com/apetrovskiy/JdiCodeGenerator git https://github.com/apetrovskiy/JdiCodeGenerator.git"">

  <meta content=""2947151"" name=""octolytics-dimension-user_id"" /><meta content=""apetrovskiy"" name=""octolytics-dimension-user_login"" /><meta content=""60525131"" name=""octolytics-dimension-repository_id"" /><meta content=""apetrovskiy/JdiCodeGenerator"" name=""octolytics-dimension-repository_nwo"" /><meta content=""true"" name=""octolytics-dimension-repository_public"" /><meta content=""false"" name=""octolytics-dimension-repository_is_fork"" /><meta content=""60525131"" name=""octolytics-dimension-repository_network_root_id"" /><meta content=""apetrovskiy/JdiCodeGenerator"" name=""octolytics-dimension-repository_network_root_nwo"" /><meta content=""false"" name=""octolytics-dimension-repository_explore_github_marketplace_ci_cta_shown"" />


    <link rel=""canonical"" href=""https://github.com/apetrovskiy/JdiCodeGenerator"" data-pjax-transient>


  <meta name=""browser-stats-url"" content=""https://api.github.com/_private/browser/stats"">

  <meta name=""browser-errors-url"" content=""https://api.github.com/_private/browser/errors"">

  <link rel=""mask-icon"" href=""https://assets-cdn.github.com/pinned-octocat.svg"" color=""#000000"">
  <link rel=""icon"" type=""image/x-icon"" class=""js-site-favicon"" href=""https://assets-cdn.github.com/favicon.ico"">

<meta name=""theme-color"" content=""#1e2327"">


  <meta name=""u2f-support"" content=""true"">

<link rel=""manifest"" href=""/manifest.json"" crossOrigin=""use-credentials"">

  </head>

  <body class=""logged-in env-production"">
    

  <div class=""position-relative js-header-wrapper "">
    <a href=""#start-of-content"" tabindex=""1"" class=""bg-black text-white p-3 show-on-focus js-skip-to-content"">Skip to content</a>
    <div id=""js-pjax-loader-bar"" class=""pjax-loader-bar""><div class=""progress""></div></div>

    
    
    



        
<header class=""Header  f5"" role=""banner"">
  <div class=""d-flex px-3 flex-justify-between container-lg"">
    <div class=""d-flex flex-justify-between "">
      <div class="""">
        <a class=""header-logo-invertocat"" href=""https://github.com/"" data-hotkey=""g d"" aria-label=""Homepage"" data-ga-click=""Header, go to dashboard, icon:logo"">
  <svg aria-hidden=""true"" class=""octicon octicon-mark-github"" height=""32"" version=""1.1"" viewBox=""0 0 16 16"" width=""32""><path fill-rule=""evenodd"" d=""M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z""/></svg>
</a>

      </div>

    </div>

    <div class=""HeaderMenu d-flex flex-justify-between flex-auto"">
      <div class=""d-flex"">
            <div class="""">
              <div class=""header-search scoped-search site-scoped-search js-site-search"" role=""search"">
  <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/apetrovskiy/JdiCodeGenerator/search"" class=""js-site-search-form"" data-scoped-search-url=""/apetrovskiy/JdiCodeGenerator/search"" data-unscoped-search-url=""/search"" method=""get""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /></div>
    <label class=""form-control header-search-wrapper js-chromeless-input-container"">
        <a href=""/apetrovskiy/JdiCodeGenerator"" class=""header-search-scope no-underline"">This repository</a>
      <input type=""text""
        class=""form-control header-search-input js-site-search-focus js-site-search-field is-clearable""
        data-hotkey=""s""
        name=""q""
        value=""""
        placeholder=""Search""
        aria-label=""Search this repository""
        data-unscoped-placeholder=""Search GitHub""
        data-scoped-placeholder=""Search""
        autocapitalize=""off"">
        <input type=""hidden"" class=""js-site-search-type-field"" name=""type"" >
    </label>
</form></div>

            </div>

          <ul class=""d-flex pl-2 flex-items-center text-bold list-style-none"" role=""navigation"">
            <li>
              <a href=""/pulls"" aria-label=""Pull requests you created"" class=""js-selected-navigation-item HeaderNavlink px-2"" data-ga-click=""Header, click, Nav menu - item:pulls context:user"" data-hotkey=""g p"" data-selected-links=""/pulls /pulls/assigned /pulls/mentioned /pulls"">
                Pull requests
</a>            </li>
            <li>
              <a href=""/issues"" aria-label=""Issues you created"" class=""js-selected-navigation-item HeaderNavlink px-2"" data-ga-click=""Header, click, Nav menu - item:issues context:user"" data-hotkey=""g i"" data-selected-links=""/issues /issues/assigned /issues/mentioned /issues"">
                Issues
</a>            </li>
                <li>
                  <a href=""/marketplace"" class=""js-selected-navigation-item HeaderNavlink px-2"" data-ga-click=""Header, click, Nav menu - item:marketplace context:user"" data-selected-links="" /marketplace"">
                    Marketplace
</a>                </li>
            <li>
              <a href=""/explore"" class=""js-selected-navigation-item HeaderNavlink px-2"" data-ga-click=""Header, click, Nav menu - item:explore"" data-selected-links=""/explore /trending /trending/developers /integrations /integrations/feature/code /integrations/feature/collaborate /integrations/feature/ship showcases showcases_search showcases_landing /explore"">
                Explore
</a>            </li>
          </ul>
      </div>

      <div class=""d-flex"">
        
<ul class=""user-nav d-flex flex-items-center list-style-none"" id=""user-links"">
  <li class=""dropdown js-menu-container"">
    <span class=""d-inline-block  px-2"">
      

    </span>
  </li>

  <li class=""dropdown js-menu-container"">
    <details class=""dropdown-details details-reset js-dropdown-details d-flex px-2 flex-items-center"">
      <summary class=""HeaderNavlink""
         aria-label=""Create new…""
         data-ga-click=""Header, create new, icon:add"">
        <svg aria-hidden=""true"" class=""octicon octicon-plus float-left mr-1 mt-1"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 9H7v5H5V9H0V7h5V2h2v5h5z""/></svg>
        <span class=""dropdown-caret mt-1""></span>
      </summary>

      <ul class=""dropdown-menu dropdown-menu-sw"">
        
<a class=""dropdown-item"" href=""/new"" data-ga-click=""Header, create new repository"">
  New repository
</a>

  <a class=""dropdown-item"" href=""/new/import"" data-ga-click=""Header, import a repository"">
    Import repository
  </a>

<a class=""dropdown-item"" href=""https://gist.github.com/"" data-ga-click=""Header, create new gist"">
  New gist
</a>

  <a class=""dropdown-item"" href=""/organizations/new"" data-ga-click=""Header, create new organization"">
    New organization
  </a>



  <div class=""dropdown-divider""></div>
  <div class=""dropdown-header"">
    <span title=""apetrovskiy/JdiCodeGenerator"">This repository</span>
  </div>
    <a class=""dropdown-item"" href=""/apetrovskiy/JdiCodeGenerator/issues/new"" data-ga-click=""Header, create new issue"">
      New issue
    </a>

      </ul>
    </details>
  </li>

  <li class=""dropdown js-menu-container"">

    <details class=""dropdown-details details-reset js-dropdown-details d-flex pl-2 flex-items-center"">
      <summary class=""HeaderNavlink name mt-1""
        aria-label=""View profile and more""
        data-ga-click=""Header, show menu, icon:avatar"">
        <img alt=""@yuliapetrova"" class=""avatar float-left mr-1"" src=""https://avatars2.githubusercontent.com/u/18421129?s=40&amp;v=4"" height=""20"" width=""20"">
        <span class=""dropdown-caret""></span>
      </summary>

      <ul class=""dropdown-menu dropdown-menu-sw"">
        <li class=""dropdown-header header-nav-current-user css-truncate"">
          Signed in as <strong class=""css-truncate-target"">yuliapetrova</strong>
        </li>

        <li class=""dropdown-divider""></li>

        <li><a class=""dropdown-item"" href=""/yuliapetrova"" data-ga-click=""Header, go to profile, text:your profile"">
          Your profile
        </a></li>
        <li><a class=""dropdown-item"" href=""/yuliapetrova?tab=stars"" data-ga-click=""Header, go to starred repos, text:your stars"">
          Your stars
        </a></li>
          <li><a class=""dropdown-item"" href=""https://gist.github.com/"" data-ga-click=""Header, your gists, text:your gists"">Your gists</a></li>

        <li class=""dropdown-divider""></li>

        <li><a class=""dropdown-item"" href=""https://help.github.com"" data-ga-click=""Header, go to help, text:help"">
          Help
        </a></li>

        <li><a class=""dropdown-item"" href=""/settings/profile"" data-ga-click=""Header, go to settings, icon:settings"">
          Settings
        </a></li>

        <li><!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/logout"" class=""logout-form"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""WVarEs8GYLuTrCN4sItJiIaaVepoOxVcAtcnXAhoVU2h9kL03XyGhGGGgEiBCrVuzNklTSom7qqfIOw80/jxgw=="" /></div>
          <button type=""submit"" class=""dropdown-item dropdown-signout"" data-ga-click=""Header, sign out, icon:logout"">
            Sign out
          </button>
        </form></li>
      </ul>
    </details>
  </li>
</ul>



        <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/logout"" class=""sr-only right-0"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""lPa25fzLmxubn+GeitmT+UmKCEmCiK+1j+Zh9l32cfBsVl8D7rF9JGm1Qq67WG8fA8l47sCVVEMSEaqWhmbVPg=="" /></div>
          <button type=""submit"" class=""dropdown-item dropdown-signout"" data-ga-click=""Header, sign out, icon:logout"">
            Sign out
          </button>
</form>      </div>
    </div>
  </div>
</header>

      

  </div>

  <div id=""start-of-content"" class=""show-on-focus""></div>

    <div id=""js-flash-container"">
</div>



  <div role=""main"" class=""application-main "">
        <div itemscope itemtype=""http://schema.org/SoftwareSourceCode"" class="""">
    <div id=""js-repo-pjax-container"" data-pjax-container >
      





  <div class=""pagehead repohead instapaper_ignore readability-menu experiment-repo-nav  "">
    <div class=""repohead-details-container clearfix container"">

      <ul class=""pagehead-actions"">
  <li>
        <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/notifications/subscribe"" class=""js-social-container"" data-autosubmit=""true"" data-remote=""true"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""YHiclUuKUOozoBDYRfVncRFr/fG+wBWf5s8R9eszborqazO6PfwEqM5kDsoldSMzrZOb9dbVpvmbkIGYjHgA4w=="" /></div>      <input class=""form-control"" id=""repository_id"" name=""repository_id"" type=""hidden"" value=""60525131"" />

        <div class=""select-menu js-menu-container js-select-menu"">
          <a href=""/apetrovskiy/JdiCodeGenerator/subscription""
            class=""btn btn-sm btn-with-count select-menu-button js-menu-target""
            role=""button""
            aria-haspopup=""true""
            aria-expanded=""false""
            aria-label=""Toggle repository notifications menu""
            data-ga-click=""Repository, click Watch settings, action:files#disambiguate"">
            <span class=""js-select-button"">
                <svg aria-hidden=""true"" class=""octicon octicon-eye"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.06 2C3 2 0 8 0 8s3 6 8.06 6C13 14 16 8 16 8s-3-6-7.94-6zM8 12c-2.2 0-4-1.78-4-4 0-2.2 1.8-4 4-4 2.22 0 4 1.8 4 4 0 2.22-1.78 4-4 4zm2-4c0 1.11-.89 2-2 2-1.11 0-2-.89-2-2 0-1.11.89-2 2-2 1.11 0 2 .89 2 2z""/></svg>
                Watch
            </span>
          </a>
          <a class=""social-count js-social-count""
            href=""/apetrovskiy/JdiCodeGenerator/watchers""
            aria-label=""1 user is watching this repository"">
            1
          </a>

        <div class=""select-menu-modal-holder"">
          <div class=""select-menu-modal subscription-menu-modal js-menu-content"">
            <div class=""select-menu-header js-navigation-enable"" tabindex=""-1"">
              <svg aria-label=""Close"" class=""octicon octicon-x js-menu-close"" height=""16"" role=""img"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48z""/></svg>
              <span class=""select-menu-title"">Notifications</span>
            </div>

              <div class=""select-menu-list js-navigation-container"" role=""menu"">

                <div class=""select-menu-item js-navigation-item selected"" role=""menuitem"" tabindex=""0"">
                  <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
                  <div class=""select-menu-item-text"">
                    <input checked=""checked"" id=""do_included"" name=""do"" type=""radio"" value=""included"" />
                    <span class=""select-menu-item-heading"">Not watching</span>
                    <span class=""description"">Be notified when participating or @mentioned.</span>
                    <span class=""js-select-button-text hidden-select-button-text"">
                      <svg aria-hidden=""true"" class=""octicon octicon-eye"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.06 2C3 2 0 8 0 8s3 6 8.06 6C13 14 16 8 16 8s-3-6-7.94-6zM8 12c-2.2 0-4-1.78-4-4 0-2.2 1.8-4 4-4 2.22 0 4 1.8 4 4 0 2.22-1.78 4-4 4zm2-4c0 1.11-.89 2-2 2-1.11 0-2-.89-2-2 0-1.11.89-2 2-2 1.11 0 2 .89 2 2z""/></svg>
                      Watch
                    </span>
                  </div>
                </div>

                <div class=""select-menu-item js-navigation-item "" role=""menuitem"" tabindex=""0"">
                  <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
                  <div class=""select-menu-item-text"">
                    <input id=""do_subscribed"" name=""do"" type=""radio"" value=""subscribed"" />
                    <span class=""select-menu-item-heading"">Watching</span>
                    <span class=""description"">Be notified of all conversations.</span>
                    <span class=""js-select-button-text hidden-select-button-text"">
                      <svg aria-hidden=""true"" class=""octicon octicon-eye"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.06 2C3 2 0 8 0 8s3 6 8.06 6C13 14 16 8 16 8s-3-6-7.94-6zM8 12c-2.2 0-4-1.78-4-4 0-2.2 1.8-4 4-4 2.22 0 4 1.8 4 4 0 2.22-1.78 4-4 4zm2-4c0 1.11-.89 2-2 2-1.11 0-2-.89-2-2 0-1.11.89-2 2-2 1.11 0 2 .89 2 2z""/></svg>
                        Unwatch
                    </span>
                  </div>
                </div>

                <div class=""select-menu-item js-navigation-item "" role=""menuitem"" tabindex=""0"">
                  <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
                  <div class=""select-menu-item-text"">
                    <input id=""do_ignore"" name=""do"" type=""radio"" value=""ignore"" />
                    <span class=""select-menu-item-heading"">Ignoring</span>
                    <span class=""description"">Never be notified.</span>
                    <span class=""js-select-button-text hidden-select-button-text"">
                      <svg aria-hidden=""true"" class=""octicon octicon-mute"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8 2.81v10.38c0 .67-.81 1-1.28.53L3 10H1c-.55 0-1-.45-1-1V7c0-.55.45-1 1-1h2l3.72-3.72C7.19 1.81 8 2.14 8 2.81zm7.53 3.22l-1.06-1.06-1.97 1.97-1.97-1.97-1.06 1.06L11.44 8 9.47 9.97l1.06 1.06 1.97-1.97 1.97 1.97 1.06-1.06L13.56 8l1.97-1.97z""/></svg>
                        Stop ignoring
                    </span>
                  </div>
                </div>

              </div>

            </div>
          </div>
        </div>
</form>
  </li>

  <li>
    
  <div class=""js-toggler-container js-social-container starring-container "">
    <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/apetrovskiy/JdiCodeGenerator/unstar"" class=""starred js-social-form"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""DbYjZQkMvqkb1EjRPLlRa/FA/P2tLq4jV6qMD8iVKuGG6hsaqBjPWK+Zspv/OFPo8qC4oLrPWr71fgWG85hfqA=="" /></div>
      <input type=""hidden"" name=""context"" value=""repository""></input>
      <button
        type=""submit""
        class=""btn btn-sm btn-with-count js-toggler-target""
        aria-label=""Unstar this repository"" title=""Unstar apetrovskiy/JdiCodeGenerator""
        data-ga-click=""Repository, click unstar button, action:files#disambiguate; text:Unstar"">
        <svg aria-hidden=""true"" class=""octicon octicon-star"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M14 6l-4.9-.64L7 1 4.9 5.36 0 6l3.6 3.26L2.67 14 7 11.67 11.33 14l-.93-4.74z""/></svg>
        Unstar
      </button>
        <a class=""social-count js-social-count"" href=""/apetrovskiy/JdiCodeGenerator/stargazers""
           aria-label=""0 users starred this repository"">
          0
        </a>
</form>
    <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/apetrovskiy/JdiCodeGenerator/star"" class=""unstarred js-social-form"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""0qkSB9T13XuhRw+RJcewyoBzXwzQ3B9jopSUq3nAR6/pUSukFW23sbVBFBKcZMrBoAafoUqL7rG3rWacmikewQ=="" /></div>
      <input type=""hidden"" name=""context"" value=""repository""></input>
      <button
        type=""submit""
        class=""btn btn-sm btn-with-count js-toggler-target""
        aria-label=""Star this repository"" title=""Star apetrovskiy/JdiCodeGenerator""
        data-ga-click=""Repository, click star button, action:files#disambiguate; text:Star"">
        <svg aria-hidden=""true"" class=""octicon octicon-star"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M14 6l-4.9-.64L7 1 4.9 5.36 0 6l3.6 3.26L2.67 14 7 11.67 11.33 14l-.93-4.74z""/></svg>
        Star
      </button>
        <a class=""social-count js-social-count"" href=""/apetrovskiy/JdiCodeGenerator/stargazers""
           aria-label=""0 users starred this repository"">
          0
        </a>
</form>  </div>

  </li>

  <li>
          <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/apetrovskiy/JdiCodeGenerator/fork"" class=""btn-with-count"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""0T5AgNcOEVwrnWCHJsXVxZMxnzfKOPe5bdlW5LNGhJaXJZanHNRgywuKufJGPo8d0VAw+KrHH/TnnN+DCNLUag=="" /></div>
            <button
                type=""submit""
                class=""btn btn-sm btn-with-count""
                data-ga-click=""Repository, show fork modal, action:files#disambiguate; text:Fork""
                title=""Fork your own copy of apetrovskiy/JdiCodeGenerator to your account""
                aria-label=""Fork your own copy of apetrovskiy/JdiCodeGenerator to your account"">
              <svg aria-hidden=""true"" class=""octicon octicon-repo-forked"" height=""16"" version=""1.1"" viewBox=""0 0 10 16"" width=""10""><path fill-rule=""evenodd"" d=""M8 1a1.993 1.993 0 0 0-1 3.72V6L5 8 3 6V4.72A1.993 1.993 0 0 0 2 1a1.993 1.993 0 0 0-1 3.72V6.5l3 3v1.78A1.993 1.993 0 0 0 5 15a1.993 1.993 0 0 0 1-3.72V9.5l3-3V4.72A1.993 1.993 0 0 0 8 1zM2 4.2C1.34 4.2.8 3.65.8 3c0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zm3 10c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zm3-10c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2z""/></svg>
              Fork
            </button>
</form>
    <a href=""/apetrovskiy/JdiCodeGenerator/network"" class=""social-count""
       aria-label=""0 users forked this repository"">
      0
    </a>
  </li>
</ul>

      <h1 class=""public "">
  <svg aria-hidden=""true"" class=""octicon octicon-repo"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M4 9H3V8h1v1zm0-3H3v1h1V6zm0-2H3v1h1V4zm0-2H3v1h1V2zm8-1v12c0 .55-.45 1-1 1H6v2l-1.5-1.5L3 16v-2H1c-.55 0-1-.45-1-1V1c0-.55.45-1 1-1h10c.55 0 1 .45 1 1zm-1 10H1v2h2v-1h3v1h5v-2zm0-10H2v9h9V1z""/></svg>
  <span class=""author"" itemprop=""author""><a href=""/apetrovskiy"" class=""url fn"" rel=""author"">apetrovskiy</a></span><!--
--><span class=""path-divider"">/</span><!--
--><strong itemprop=""name""><a href=""/apetrovskiy/JdiCodeGenerator"" data-pjax=""#js-repo-pjax-container"">JdiCodeGenerator</a></strong>

</h1>

    </div>
    
<nav class=""reponav js-repo-nav js-sidenav-container-pjax container""
     itemscope
     itemtype=""http://schema.org/BreadcrumbList""
     role=""navigation""
     data-pjax=""#js-repo-pjax-container"">

  <span itemscope itemtype=""http://schema.org/ListItem"" itemprop=""itemListElement"">
    <a href=""/apetrovskiy/JdiCodeGenerator"" class=""js-selected-navigation-item selected reponav-item"" data-hotkey=""g c"" data-selected-links=""repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches repo_packages /apetrovskiy/JdiCodeGenerator"" itemprop=""url"">
      <svg aria-hidden=""true"" class=""octicon octicon-code"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M9.5 3L8 4.5 11.5 8 8 11.5 9.5 13 14 8 9.5 3zm-5 0L0 8l4.5 5L6 11.5 2.5 8 6 4.5 4.5 3z""/></svg>
      <span itemprop=""name"">Code</span>
      <meta itemprop=""position"" content=""1"">
</a>  </span>

    <span itemscope itemtype=""http://schema.org/ListItem"" itemprop=""itemListElement"">
      <a href=""/apetrovskiy/JdiCodeGenerator/issues"" class=""js-selected-navigation-item reponav-item"" data-hotkey=""g i"" data-selected-links=""repo_issues repo_labels repo_milestones /apetrovskiy/JdiCodeGenerator/issues"" itemprop=""url"">
        <svg aria-hidden=""true"" class=""octicon octicon-issue-opened"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M7 2.3c3.14 0 5.7 2.56 5.7 5.7s-2.56 5.7-5.7 5.7A5.71 5.71 0 0 1 1.3 8c0-3.14 2.56-5.7 5.7-5.7zM7 1C3.14 1 0 4.14 0 8s3.14 7 7 7 7-3.14 7-7-3.14-7-7-7zm1 3H6v5h2V4zm0 6H6v2h2v-2z""/></svg>
        <span itemprop=""name"">Issues</span>
        <span class=""Counter"">0</span>
        <meta itemprop=""position"" content=""2"">
</a>    </span>

  <span itemscope itemtype=""http://schema.org/ListItem"" itemprop=""itemListElement"">
    <a href=""/apetrovskiy/JdiCodeGenerator/pulls"" class=""js-selected-navigation-item reponav-item"" data-hotkey=""g p"" data-selected-links=""repo_pulls checks /apetrovskiy/JdiCodeGenerator/pulls"" itemprop=""url"">
      <svg aria-hidden=""true"" class=""octicon octicon-git-pull-request"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M11 11.28V5c-.03-.78-.34-1.47-.94-2.06C9.46 2.35 8.78 2.03 8 2H7V0L4 3l3 3V4h1c.27.02.48.11.69.31.21.2.3.42.31.69v6.28A1.993 1.993 0 0 0 10 15a1.993 1.993 0 0 0 1-3.72zm-1 2.92c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zM4 3c0-1.11-.89-2-2-2a1.993 1.993 0 0 0-1 3.72v6.56A1.993 1.993 0 0 0 2 15a1.993 1.993 0 0 0 1-3.72V4.72c.59-.34 1-.98 1-1.72zm-.8 10c0 .66-.55 1.2-1.2 1.2-.65 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2zM2 4.2C1.34 4.2.8 3.65.8 3c0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2z""/></svg>
      <span itemprop=""name"">Pull requests</span>
      <span class=""Counter"">0</span>
      <meta itemprop=""position"" content=""3"">
</a>  </span>

    <a href=""/apetrovskiy/JdiCodeGenerator/projects"" class=""js-selected-navigation-item reponav-item"" data-hotkey=""g b"" data-selected-links=""repo_projects new_repo_project repo_project /apetrovskiy/JdiCodeGenerator/projects"">
      <svg aria-hidden=""true"" class=""octicon octicon-project"" height=""16"" version=""1.1"" viewBox=""0 0 15 16"" width=""15""><path fill-rule=""evenodd"" d=""M10 12h3V2h-3v10zm-4-2h3V2H6v8zm-4 4h3V2H2v12zm-1 1h13V1H1v14zM14 0H1a1 1 0 0 0-1 1v14a1 1 0 0 0 1 1h13a1 1 0 0 0 1-1V1a1 1 0 0 0-1-1z""/></svg>
      Projects
      <span class=""Counter"" >0</span>
</a>
    <a href=""/apetrovskiy/JdiCodeGenerator/wiki"" class=""js-selected-navigation-item reponav-item"" data-hotkey=""g w"" data-selected-links=""repo_wiki /apetrovskiy/JdiCodeGenerator/wiki"">
      <svg aria-hidden=""true"" class=""octicon octicon-book"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M3 5h4v1H3V5zm0 3h4V7H3v1zm0 2h4V9H3v1zm11-5h-4v1h4V5zm0 2h-4v1h4V7zm0 2h-4v1h4V9zm2-6v9c0 .55-.45 1-1 1H9.5l-1 1-1-1H2c-.55 0-1-.45-1-1V3c0-.55.45-1 1-1h5.5l1 1 1-1H15c.55 0 1 .45 1 1zm-8 .5L7.5 3H2v9h6V3.5zm7-.5H9.5l-.5.5V12h6V3z""/></svg>
      Wiki
</a>

  <a href=""/apetrovskiy/JdiCodeGenerator/pulse"" class=""js-selected-navigation-item reponav-item"" data-selected-links=""repo_graphs repo_contributors dependency_graph pulse /apetrovskiy/JdiCodeGenerator/pulse"">
    <svg aria-hidden=""true"" class=""octicon octicon-graph"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M16 14v1H0V0h1v14h15zM5 13H3V8h2v5zm4 0H7V3h2v10zm4 0h-2V6h2v7z""/></svg>
    Insights
</a>

</nav>


  </div>

<div class=""container new-discussion-timeline experiment-repo-nav  "">
  <div class=""repository-content "">

    
  

  <div class=""js-repo-meta-container"">
  <div class=""repository-meta mb-0 mb-3 js-repo-meta-edit js-details-container "">
    <div class=""repository-meta-content col-11 mb-1"">
          <span class=""col-11 text-gray-dark mr-2"" itemprop=""about"">
            This is a tool to generate code for JDI-based tests
          </span>
    </div>

  </div>

</div>



  <div class=""overall-summary overall-summary-bottomless"">
    <div class=""stats-switcher-viewport js-stats-switcher-viewport"">
      <div class=""stats-switcher-wrapper"">
      <ul class=""numbers-summary"">
        <li class=""commits"">
          <a data-pjax href=""/apetrovskiy/JdiCodeGenerator/commits/master"">
              <svg aria-hidden=""true"" class=""octicon octicon-history"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M8 13H6V6h5v2H8v5zM7 1C4.81 1 2.87 2.02 1.59 3.59L0 2v4h4L2.5 4.5C3.55 3.17 5.17 2.3 7 2.3c3.14 0 5.7 2.56 5.7 5.7s-2.56 5.7-5.7 5.7A5.71 5.71 0 0 1 1.3 8c0-.34.03-.67.09-1H.08C.03 7.33 0 7.66 0 8c0 3.86 3.14 7 7 7s7-3.14 7-7-3.14-7-7-7z""/></svg>
              <span class=""num text-emphasized"">
                93
              </span>
              commits
          </a>
        </li>
        <li>
          <a data-pjax href=""/apetrovskiy/JdiCodeGenerator/branches"">
            <svg aria-hidden=""true"" class=""octicon octicon-git-branch"" height=""16"" version=""1.1"" viewBox=""0 0 10 16"" width=""10""><path fill-rule=""evenodd"" d=""M10 5c0-1.11-.89-2-2-2a1.993 1.993 0 0 0-1 3.72v.3c-.02.52-.23.98-.63 1.38-.4.4-.86.61-1.38.63-.83.02-1.48.16-2 .45V4.72a1.993 1.993 0 0 0-1-3.72C.88 1 0 1.89 0 3a2 2 0 0 0 1 1.72v6.56c-.59.35-1 .99-1 1.72 0 1.11.89 2 2 2 1.11 0 2-.89 2-2 0-.53-.2-1-.53-1.36.09-.06.48-.41.59-.47.25-.11.56-.17.94-.17 1.05-.05 1.95-.45 2.75-1.25S8.95 7.77 9 6.73h-.02C9.59 6.37 10 5.73 10 5zM2 1.8c.66 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2C1.35 4.2.8 3.65.8 3c0-.65.55-1.2 1.2-1.2zm0 12.41c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2zm6-8c-.66 0-1.2-.55-1.2-1.2 0-.65.55-1.2 1.2-1.2.65 0 1.2.55 1.2 1.2 0 .65-.55 1.2-1.2 1.2z""/></svg>
            <span class=""num text-emphasized"">
              1
            </span>
            branch
          </a>
        </li>

        <li>
          <a href=""/apetrovskiy/JdiCodeGenerator/releases"">
            <svg aria-hidden=""true"" class=""octicon octicon-tag"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M7.73 1.73C7.26 1.26 6.62 1 5.96 1H3.5C2.13 1 1 2.13 1 3.5v2.47c0 .66.27 1.3.73 1.77l6.06 6.06c.39.39 1.02.39 1.41 0l4.59-4.59a.996.996 0 0 0 0-1.41L7.73 1.73zM2.38 7.09c-.31-.3-.47-.7-.47-1.13V3.5c0-.88.72-1.59 1.59-1.59h2.47c.42 0 .83.16 1.13.47l6.14 6.13-4.73 4.73-6.13-6.15zM3.01 3h2v2H3V3h.01z""/></svg>
            <span class=""num text-emphasized"">
              3
            </span>
            releases
          </a>
        </li>

        <li>
            <include-fragment src=""/apetrovskiy/JdiCodeGenerator/contributors_size"">
              <a href=""/apetrovskiy/JdiCodeGenerator/graphs/contributors"">
                <svg aria-hidden=""true"" class=""octicon octicon-organization"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M16 12.999c0 .439-.45 1-1 1H7.995c-.539 0-.994-.447-.995-.999H1c-.54 0-1-.561-1-1 0-2.634 3-4 3-4s.229-.409 0-1c-.841-.621-1.058-.59-1-3 .058-2.419 1.367-3 2.5-3s2.442.58 2.5 3c.058 2.41-.159 2.379-1 3-.229.59 0 1 0 1s1.549.711 2.42 2.088C9.196 9.369 10 8.999 10 8.999s.229-.409 0-1c-.841-.62-1.058-.59-1-3 .058-2.419 1.367-3 2.5-3s2.437.581 2.495 3c.059 2.41-.158 2.38-1 3-.229.59 0 1 0 1s3.005 1.366 3.005 4""/></svg>
                <span class=""num text-emphasized""></span>
                Fetching contributors
              </a>
</include-fragment>        </li>
      </ul>

        <div class=""repository-lang-stats"">
          <ol class=""repository-lang-stats-numbers"">
            <li>
                <a href=""/apetrovskiy/JdiCodeGenerator/search?l=c%23""  data-ga-click=""Repository, language stats search click, location:repo overview"">
                  <span class=""color-block language-color"" style=""background-color:#178600;""></span>
                  <span class=""lang"">C#</span>
                  <span class=""percent"">98.7%</span>
                </a>
            </li>
            <li>
                <span class=""other"">
                  <span class=""color-block language-color"" style=""background-color:#ededed;""></span>
                  <span class=""lang"">Other</span>
                  <span class=""percent"">1.3%</span>
                </span>
            </li>
          </ol>
        </div>
      </div>
    </div>
  </div>

    <div class=""repository-lang-stats-graph js-toggle-lang-stats"" title=""Click for language details"" data-ga-click=""Repository, language bar stats toggle, location:repo overview"">
      <span class=""language-color"" aria-label=""C# 98.7%"" style=""width:98.7%; background-color:#178600;"" itemprop=""keywords"">C#</span>
      <span class=""language-color"" aria-label=""Other 1.3%"" style=""width:1.3%; background-color:#ededed;"" itemprop=""keywords"">Other</span>
    </div>


    <include-fragment src=""/apetrovskiy/JdiCodeGenerator/show_partial?partial=tree%2Frecently_touched_branches_list""></include-fragment>

  <div class=""file-navigation in-mid-page"">

    <details class=""get-repo-select-menu js-menu-container float-right position-relative dropdown-details details-reset"">
  <summary class=""btn btn-sm btn-primary"">
    Clone or download
    <span class=""dropdown-caret""></span>
  </summary>
  <div class=""position-relative"">
    <div class=""get-repo-modal dropdown-menu dropdown-menu-sw pb-0 js-toggler-container "">
        <div class=""clone-options https-clone-options"">
            <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone"" data-remote=""true"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""BR3NrZcKzYcNeFYqeQ5oWKDYQVnjlVjC65Z0mKCo/Jlg7vix4z1P3MTH8BJ0a2Y7yRw62jfcUQTf5VQ1NJYgTQ=="" /></div><button class=""btn-link btn-change-protocol js-toggler-target float-right"" type=""submit"">Use SSH</button></form>

          <h4 class=""mb-1"">
            Clone with HTTPS
            <a class=""muted-link"" href=""https://help.github.com/articles/which-remote-url-should-i-use"" target=""_blank"" title=""Which remote URL should I use?"">
              <svg aria-hidden=""true"" class=""octicon octicon-question"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M6 10h2v2H6v-2zm4-3.5C10 8.64 8 9 8 9H6c0-.55.45-1 1-1h.5c.28 0 .5-.22.5-.5v-1c0-.28-.22-.5-.5-.5h-1c-.28 0-.5.22-.5.5V7H4c0-1.5 1.5-3 3-3s3 1 3 2.5zM7 2.3c3.14 0 5.7 2.56 5.7 5.7s-2.56 5.7-5.7 5.7A5.71 5.71 0 0 1 1.3 8c0-3.14 2.56-5.7 5.7-5.7zM7 1C3.14 1 0 4.14 0 8s3.14 7 7 7 7-3.14 7-7-3.14-7-7-7z""/></svg>
            </a>
          </h4>
          <p class=""mb-2 get-repo-decription-text"">
            Use Git or checkout with SVN using the web URL.
          </p>

          <div class=""input-group js-zeroclipboard-container"">
  <input type=""text"" class=""form-control input-monospace input-sm js-zeroclipboard-target js-url-field"" value=""https://github.com/apetrovskiy/JdiCodeGenerator.git"" aria-label=""Clone this repository at https://github.com/apetrovskiy/JdiCodeGenerator.git"" readonly>
  <div class=""input-group-button"">
    <button aria-label=""Copy to clipboard"" class=""js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s"" data-copied-hint=""Copied!"" type=""button""><svg aria-hidden=""true"" class=""octicon octicon-clippy"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M2 13h4v1H2v-1zm5-6H2v1h5V7zm2 3V8l-3 3 3 3v-2h5v-2H9zM4.5 9H2v1h2.5V9zM2 12h2.5v-1H2v1zm9 1h1v2c-.02.28-.11.52-.3.7-.19.18-.42.28-.7.3H1c-.55 0-1-.45-1-1V4c0-.55.45-1 1-1h3c0-1.11.89-2 2-2 1.11 0 2 .89 2 2h3c.55 0 1 .45 1 1v5h-1V6H1v9h10v-2zM2 5h8c0-.55-.45-1-1-1H8c-.55 0-1-.45-1-1s-.45-1-1-1-1 .45-1 1-.45 1-1 1H3c-.55 0-1 .45-1 1z""/></svg></button>
  </div>
</div>

        </div>

        <div class=""clone-options ssh-clone-options"">
            <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/users/set_protocol?protocol_selector=https&amp;protocol_type=clone"" data-remote=""true"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""7TpMjffc07mcvogi2kwD9c1+e3nmLr90tReXxnT5tWqIyXmRg+tR4lUBLhrXKQ2WpLoA+jJntrKBZLdr4Mdpvg=="" /></div><button class=""btn-link btn-change-protocol js-toggler-target float-right"" type=""submit"">Use HTTPS</button></form>

            <h4 class=""mb-1"">
              Clone with SSH
              <a class=""muted-link"" href=""https://help.github.com/articles/which-remote-url-should-i-use"" target=""_blank"" title=""Which remote URL should I use?"">
                <svg aria-hidden=""true"" class=""octicon octicon-question"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M6 10h2v2H6v-2zm4-3.5C10 8.64 8 9 8 9H6c0-.55.45-1 1-1h.5c.28 0 .5-.22.5-.5v-1c0-.28-.22-.5-.5-.5h-1c-.28 0-.5.22-.5.5V7H4c0-1.5 1.5-3 3-3s3 1 3 2.5zM7 2.3c3.14 0 5.7 2.56 5.7 5.7s-2.56 5.7-5.7 5.7A5.71 5.71 0 0 1 1.3 8c0-3.14 2.56-5.7 5.7-5.7zM7 1C3.14 1 0 4.14 0 8s3.14 7 7 7 7-3.14 7-7-3.14-7-7-7z""/></svg>
              </a>
            </h4>
            <p class=""mb-2 get-repo-decription-text"">
              Use an SSH key and passphrase from account.
            </p>

            <div class=""input-group js-zeroclipboard-container"">
  <input type=""text"" class=""form-control input-monospace input-sm js-zeroclipboard-target js-url-field"" value=""git@github.com:apetrovskiy/JdiCodeGenerator.git"" aria-label=""Clone this repository at git@github.com:apetrovskiy/JdiCodeGenerator.git"" readonly>
  <div class=""input-group-button"">
    <button aria-label=""Copy to clipboard"" class=""js-zeroclipboard btn btn-sm zeroclipboard-button tooltipped tooltipped-s"" data-copied-hint=""Copied!"" type=""button""><svg aria-hidden=""true"" class=""octicon octicon-clippy"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M2 13h4v1H2v-1zm5-6H2v1h5V7zm2 3V8l-3 3 3 3v-2h5v-2H9zM4.5 9H2v1h2.5V9zM2 12h2.5v-1H2v1zm9 1h1v2c-.02.28-.11.52-.3.7-.19.18-.42.28-.7.3H1c-.55 0-1-.45-1-1V4c0-.55.45-1 1-1h3c0-1.11.89-2 2-2 1.11 0 2 .89 2 2h3c.55 0 1 .45 1 1v5h-1V6H1v9h10v-2zM2 5h8c0-.55-.45-1-1-1H8c-.55 0-1-.45-1-1s-.45-1-1-1-1 .45-1 1-.45 1-1 1H3c-.55 0-1 .45-1 1z""/></svg></button>
  </div>
</div>

        </div>
      <div class=""mt-2"">
          <a href=""https://desktop.github.com"" class=""btn btn-outline get-repo-btn tooltipped tooltipped-s tooltipped-multiline"" aria-label=""Clone apetrovskiy/JdiCodeGenerator to your computer and use it in GitHub Desktop."">
    Open in Desktop
  </a>

<a href=""/apetrovskiy/JdiCodeGenerator/archive/master.zip""
   class=""btn btn-outline get-repo-btn
""
   rel=""nofollow""
   data-ga-click=""Repository, download zip, location:repo overview"">
  Download ZIP
</a>

      </div>
    </div>
  </div>
</details>


  <div class=""BtnGroup float-right"">
      
  <!-- '""` --><!-- </textarea></xmp> --></option></form><form accept-charset=""UTF-8"" action=""/apetrovskiy/JdiCodeGenerator/new/master"" class=""BtnGroup-form"" method=""post""><div style=""margin:0;padding:0;display:inline""><input name=""utf8"" type=""hidden"" value=""&#x2713;"" /><input name=""authenticity_token"" type=""hidden"" value=""YtP9SQtOVqasgk/MgHME941/hjEm0K4Xg+1hb8pAeAj88LPHZQsJU3fiKlrWrwckV9Za0lPCuiV1M5vJP1cnCQ=="" /></div>
    <button class=""btn btn-sm BtnGroup-item"" type=""submit"" data-disable-with=""Creating file…"">
      Create new file
    </button>
</form>

      
  <a href=""/apetrovskiy/JdiCodeGenerator/upload/master"" class=""btn btn-sm BtnGroup-item"">
    Upload files
  </a>


    <a href=""/apetrovskiy/JdiCodeGenerator/find/master""
      class=""btn btn-sm empty-icon float-right BtnGroup-item""
      data-pjax
      data-hotkey=""t""
      data-ga-click=""Repository, find file, location:repo overview"">
      Find file
    </a>
  </div>

  
<div class=""select-menu branch-select-menu js-menu-container js-select-menu float-left"">
  <button class="" btn btn-sm select-menu-button js-menu-target css-truncate"" data-hotkey=""w""
    
    type=""button"" aria-label=""Switch branches or tags"" aria-expanded=""false"" aria-haspopup=""true"">
      <i>Branch:</i>
      <span class=""js-select-button css-truncate-target"">master</span>
  </button>

  <div class=""select-menu-modal-holder js-menu-content js-navigation-container"" data-pjax>

    <div class=""select-menu-modal"">
      <div class=""select-menu-header"">
        <svg aria-label=""Close"" class=""octicon octicon-x js-menu-close"" height=""16"" role=""img"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48z""/></svg>
        <span class=""select-menu-title"">Switch branches/tags</span>
      </div>

      <div class=""select-menu-filters"">
        <div class=""select-menu-text-filter"">
          <input type=""text"" aria-label=""Filter branches/tags"" id=""context-commitish-filter-field"" class=""form-control js-filterable-field js-navigation-enable"" placeholder=""Filter branches/tags"">
        </div>
        <div class=""select-menu-tabs"">
          <ul>
            <li class=""select-menu-tab"">
              <a href=""#"" data-tab-filter=""branches"" data-filter-placeholder=""Filter branches/tags"" class=""js-select-menu-tab"" role=""tab"">Branches</a>
            </li>
            <li class=""select-menu-tab"">
              <a href=""#"" data-tab-filter=""tags"" data-filter-placeholder=""Find a tag…"" class=""js-select-menu-tab"" role=""tab"">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class=""select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket"" data-tab-filter=""branches"" role=""menu"">

        <div data-filterable-for=""context-commitish-filter-field"" data-filterable-type=""substring"">


            <a class=""select-menu-item js-navigation-item js-navigation-open selected""
               href=""/apetrovskiy/JdiCodeGenerator/tree/master""
               data-name=""master""
               data-skip-pjax=""true""
               rel=""nofollow"">
              <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
              <span class=""select-menu-item-text css-truncate-target js-select-menu-filter-text"">
                master
              </span>
            </a>
        </div>

          <div class=""select-menu-no-results"">Nothing to show</div>
      </div>

      <div class=""select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket"" data-tab-filter=""tags"">
        <div data-filterable-for=""context-commitish-filter-field"" data-filterable-type=""substring"">


            <a class=""select-menu-item js-navigation-item js-navigation-open ""
              href=""/apetrovskiy/JdiCodeGenerator/tree/MonolithicCore""
              data-name=""MonolithicCore""
              data-skip-pjax=""true""
              rel=""nofollow"">
              <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
              <span class=""select-menu-item-text css-truncate-target"" title=""MonolithicCore"">
                MonolithicCore
              </span>
            </a>
            <a class=""select-menu-item js-navigation-item js-navigation-open ""
              href=""/apetrovskiy/JdiCodeGenerator/tree/0.0.3""
              data-name=""0.0.3""
              data-skip-pjax=""true""
              rel=""nofollow"">
              <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
              <span class=""select-menu-item-text css-truncate-target"" title=""0.0.3"">
                0.0.3
              </span>
            </a>
            <a class=""select-menu-item js-navigation-item js-navigation-open ""
              href=""/apetrovskiy/JdiCodeGenerator/tree/0.0.2""
              data-name=""0.0.2""
              data-skip-pjax=""true""
              rel=""nofollow"">
              <svg aria-hidden=""true"" class=""octicon octicon-check select-menu-item-icon"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M12 5l-8 8-4-4 1.5-1.5L4 10l6.5-6.5z""/></svg>
              <span class=""select-menu-item-text css-truncate-target"" title=""0.0.2"">
                0.0.2
              </span>
            </a>
        </div>

        <div class=""select-menu-no-results"">Nothing to show</div>
      </div>

    </div>
  </div>
</div>


        <a href=""/apetrovskiy/JdiCodeGenerator/pull/new/master"" class=""btn btn-sm new-pull-request-btn"" data-pjax data-ga-click=""Repository, new pull request, location:repo overview"">
          New pull request
        </a>

  <div class=""breadcrumb"">
    
  </div>
</div>


  

<include-fragment class=""commit-tease commit-loader"" src=""/apetrovskiy/JdiCodeGenerator/tree-commit/950e2ec262dc848b2ac865c194ada2a106a8224b"">
  <div class=""blank"">
    <img alt="""" class=""loader"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32-EAF2F5.gif"" width=""16"" />
    Fetching latest commit…
  </div>
  <div class=""loader-error"">
    Cannot retrieve the latest commit at this time.
  </div>
</include-fragment>


<include-fragment class=""file-wrap"" src=""/apetrovskiy/JdiCodeGenerator/file-list/master"">

  <a href=""/apetrovskiy/JdiCodeGenerator/tree/950e2ec262dc848b2ac865c194ada2a106a8224b"" class=""d-none js-permalink-shortcut"" data-hotkey=""y"">Permalink</a>

  <table class=""files js-navigation-container js-active-navigation-container"" data-pjax>


    <tbody>
      <tr class=""warning include-fragment-error"">
        <td class=""icon""><svg aria-hidden=""true"" class=""octicon octicon-alert"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.865 1.52c-.18-.31-.51-.5-.87-.5s-.69.19-.87.5L.275 13.5c-.18.31-.18.69 0 1 .19.31.52.5.87.5h13.7c.36 0 .69-.19.86-.5.17-.31.18-.69.01-1L8.865 1.52zM8.995 13h-2v-2h2v2zm0-3h-2V6h2v4z""/></svg></td>
        <td class=""content"" colspan=""3"">Failed to load latest commit information.</td>
      </tr>

        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/.nuget"" class=""js-navigation-open"" id=""3ce4907e9cfb8bdf6d2f0d8f9d816070-9f3176b2b597e2c7c13017a3f0d4947f28ba77b6"" title="".nuget"">.nuget</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/Examples/JdiCodeGenerator.Web.ExampleRunner"" class=""js-navigation-open"" id=""86cdb1b1b60fa732addc7bf14c1148d3-95526f0a8b73e9cb738f427880816c292e948e2d"" title=""This path skips through empty directories""><span class=""simplified-path"">Examples/</span>JdiCodeGenerator.Web.ExampleRunner</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/JdiCodeGenerator.Core"" class=""js-navigation-open"" id=""a0dacaf2dc064b8a65cb46d5363982f3-6da4a407b44dd7f88af57a73a803c91b61be1be6"" title=""JdiCodeGenerator.Core"">JdiCodeGenerator.Core</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/JdiCodeGenerator.Facade"" class=""js-navigation-open"" id=""d1d7f0324e36186a771a7b7cc382ea26-62c88875389d040fd3fba7bb3d985dd066c0482b"" title=""JdiCodeGenerator.Facade"">JdiCodeGenerator.Facade</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/JdiCodeGenerator.Web"" class=""js-navigation-open"" id=""cefa6dbcd43cc5589ed87da6fec668c0-77551c3b67681107c62a5d3acb34fcf4e8bd54c8"" title=""JdiCodeGenerator.Web"">JdiCodeGenerator.Web</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/Tests"" class=""js-navigation-open"" id=""90792de52961c34118f976ebe4af3a75-d7feb9c43b1acf18f5eff02f9136696897f84c5c"" title=""Tests"">Tests</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file-directory"" height=""16"" version=""1.1"" viewBox=""0 0 14 16"" width=""14""><path fill-rule=""evenodd"" d=""M13 4H7V3c0-.66-.31-1-1-1H1c-.55 0-1 .45-1 1v10c0 .55.45 1 1 1h12c.55 0 1-.45 1-1V5c0-.55-.45-1-1-1zM6 4H1V3h5v1z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/tree/master/packages"" class=""js-navigation-open"" id=""2fc9e51174a78dd5bfc57e8e368590b3-5de07bcde4bc24e5fe98bf99f9bc552be0aa8e29"" title=""packages"">packages</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M6 5H2V4h4v1zM2 8h7V7H2v1zm0 2h7V9H2v1zm0 2h7v-1H2v1zm10-7.5V14c0 .55-.45 1-1 1H1c-.55 0-1-.45-1-1V2c0-.55.45-1 1-1h7.5L12 4.5zM11 5L8 2H1v12h10V5z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/blob/master/.gitignore"" class=""js-navigation-open"" id=""a084b794bc0759e7a6b77810e01874f2-6c5131ca070a97fbcbb3535d5218a53f661c4e3d"" title="".gitignore"">.gitignore</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M6 5H2V4h4v1zM2 8h7V7H2v1zm0 2h7V9H2v1zm0 2h7v-1H2v1zm10-7.5V14c0 .55-.45 1-1 1H1c-.55 0-1-.45-1-1V2c0-.55.45-1 1-1h7.5L12 4.5zM11 5L8 2H1v12h10V5z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/blob/master/JdiCodeGenerator.sln"" class=""js-navigation-open"" id=""b413803812750c8bca67530695a7fc6a-5ea84b5b514cdda60160149662a0cb9da6000bca"" title=""JdiCodeGenerator.sln"">JdiCodeGenerator.sln</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
        <tr class=""js-navigation-item"">
          <td class=""icon"">
            <svg aria-hidden=""true"" class=""octicon octicon-file"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M6 5H2V4h4v1zM2 8h7V7H2v1zm0 2h7V9H2v1zm0 2h7v-1H2v1zm10-7.5V14c0 .55-.45 1-1 1H1c-.55 0-1-.45-1-1V2c0-.55.45-1 1-1h7.5L12 4.5zM11 5L8 2H1v12h10V5z""/></svg>
            <img alt="""" class=""spinner"" height=""16"" src=""https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif"" width=""16"" />
          </td>
          <td class=""content"">
            <span class=""css-truncate css-truncate-target""><a href=""/apetrovskiy/JdiCodeGenerator/blob/master/README.md"" class=""js-navigation-open"" id=""04c6e90faac2675aa89e2176d2eec7d8-bfe46aaf570e36c1d762593b41e4a4bae8623f73"" title=""README.md"">README.md</a></span>
          </td>
          <td class=""message"">
            <span class=""css-truncate css-truncate-target"">
            </span>
          </td>
          <td class=""age"">
            <span class=""css-truncate css-truncate-target""></span>
          </td>
        </tr>
    </tbody>
  </table>

</include-fragment>



  <div id=""readme"" class=""readme boxed-group clearfix announce instapaper_body md"">
    <h3>
      <svg aria-hidden=""true"" class=""octicon octicon-book"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M3 5h4v1H3V5zm0 3h4V7H3v1zm0 2h4V9H3v1zm11-5h-4v1h4V5zm0 2h-4v1h4V7zm0 2h-4v1h4V9zm2-6v9c0 .55-.45 1-1 1H9.5l-1 1-1-1H2c-.55 0-1-.45-1-1V3c0-.55.45-1 1-1h5.5l1 1 1-1H15c.55 0 1 .45 1 1zm-8 .5L7.5 3H2v9h6V3.5zm7-.5H9.5l-.5.5V12h6V3z""/></svg>
      README.md
    </h3>

      <article class=""markdown-body entry-content"" itemprop=""text""><h1><a href=""#jdicodegenerator"" aria-hidden=""true"" class=""anchor"" id=""user-content-jdicodegenerator""><svg aria-hidden=""true"" class=""octicon octicon-link"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M4 9h1v1H4c-1.5 0-3-1.69-3-3.5S2.55 3 4 3h4c1.45 0 3 1.69 3 3.5 0 1.41-.91 2.72-2 3.25V8.59c.58-.45 1-1.27 1-2.09C10 5.22 8.98 4 8 4H4c-.98 0-2 1.22-2 2.5S3 9 4 9zm9-3h-1v1h1c1 0 2 1.22 2 2.5S13.98 12 13 12H9c-.98 0-2-1.22-2-2.5 0-.83.42-1.64 1-2.09V6.25c-1.09.53-2 1.84-2 3.25C6 11.31 7.55 13 9 13h4c1.45 0 3-1.69 3-3.5S14.5 6 13 6z""></path></svg></a>JdiCodeGenerator</h1>
<p>This is a tool to generate code for JDI-based tests</p>
</article>
  </div>


  </div>
  <div class=""modal-backdrop js-touch-events""></div>
</div>

    </div>
  </div>

  </div>

      
<div class=""footer container-lg px-3"" role=""contentinfo"">
  <div class=""position-relative d-flex flex-justify-between py-6 mt-6 f6 text-gray border-top border-gray-light "">
    <ul class=""list-style-none d-flex flex-wrap "">
      <li class=""mr-3"">&copy; 2018 <span title=""0.36266s from unicorn-1568351981-stxbc"">GitHub</span>, Inc.</li>
        <li class=""mr-3""><a href=""https://help.github.com/articles/github-terms-of-service/"" data-ga-click=""Footer, go to terms, text:terms"">Terms</a></li>
        <li class=""mr-3""><a href=""https://github.com/site/privacy"" data-ga-click=""Footer, go to privacy, text:privacy"">Privacy</a></li>
        <li class=""mr-3""><a href=""https://help.github.com/articles/github-security/"" data-ga-click=""Footer, go to security, text:security"">Security</a></li>
        <li class=""mr-3""><a href=""https://status.github.com/"" data-ga-click=""Footer, go to status, text:status"">Status</a></li>
        <li><a href=""https://help.github.com"" data-ga-click=""Footer, go to help, text:help"">Help</a></li>
    </ul>

    <a href=""https://github.com"" aria-label=""Homepage"" class=""footer-octicon"" title=""GitHub"">
      <svg aria-hidden=""true"" class=""octicon octicon-mark-github"" height=""24"" version=""1.1"" viewBox=""0 0 16 16"" width=""24""><path fill-rule=""evenodd"" d=""M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0 0 16 8c0-4.42-3.58-8-8-8z""/></svg>
</a>
    <ul class=""list-style-none d-flex flex-wrap "">
        <li class=""mr-3""><a href=""https://github.com/contact"" data-ga-click=""Footer, go to contact, text:contact"">Contact GitHub</a></li>
      <li class=""mr-3""><a href=""https://developer.github.com"" data-ga-click=""Footer, go to api, text:api"">API</a></li>
      <li class=""mr-3""><a href=""https://training.github.com"" data-ga-click=""Footer, go to training, text:training"">Training</a></li>
      <li class=""mr-3""><a href=""https://shop.github.com"" data-ga-click=""Footer, go to shop, text:shop"">Shop</a></li>
        <li class=""mr-3""><a href=""https://github.com/blog"" data-ga-click=""Footer, go to blog, text:blog"">Blog</a></li>
        <li><a href=""https://github.com/about"" data-ga-click=""Footer, go to about, text:about"">About</a></li>

    </ul>
  </div>
</div>



  <div id=""ajax-error-message"" class=""ajax-error-message flash flash-error"">
    <svg aria-hidden=""true"" class=""octicon octicon-alert"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.865 1.52c-.18-.31-.51-.5-.87-.5s-.69.19-.87.5L.275 13.5c-.18.31-.18.69 0 1 .19.31.52.5.87.5h13.7c.36 0 .69-.19.86-.5.17-.31.18-.69.01-1L8.865 1.52zM8.995 13h-2v-2h2v2zm0-3h-2V6h2v4z""/></svg>
    <button type=""button"" class=""flash-close js-ajax-error-dismiss"" aria-label=""Dismiss error"">
      <svg aria-hidden=""true"" class=""octicon octicon-x"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48z""/></svg>
    </button>
    You can't perform that action at this time.
  </div>


    
    <script crossorigin=""anonymous"" integrity=""sha512-8hfks50vcmA+MqfsLFujoYKb7mZVTcRD7AWco96d0D0vNbr3mfZYOPfFuHRKvHoM+oAMV6RWLjaZgzvfoXjwFw=="" src=""https://assets-cdn.github.com/assets/frameworks-f217e4b39d2f.js"" type=""application/javascript""></script>
    
    <script async=""async"" crossorigin=""anonymous"" integrity=""sha512-mbvs4S6xMUnDCBLrh6+mCYb97BwczlCWT4OyfaQ1U8JYTNtPV7b8jgVxjL5mMBtDvufbKkD+3bkloc7LIucI9Q=="" src=""https://assets-cdn.github.com/assets/github-99bbece12eb1.js"" type=""application/javascript""></script>
    
    
    
    
  <div class=""js-stale-session-flash stale-session-flash flash flash-warn flash-banner d-none"">
    <svg aria-hidden=""true"" class=""octicon octicon-alert"" height=""16"" version=""1.1"" viewBox=""0 0 16 16"" width=""16""><path fill-rule=""evenodd"" d=""M8.865 1.52c-.18-.31-.51-.5-.87-.5s-.69.19-.87.5L.275 13.5c-.18.31-.18.69 0 1 .19.31.52.5.87.5h13.7c.36 0 .69-.19.86-.5.17-.31.18-.69.01-1L8.865 1.52zM8.995 13h-2v-2h2v2zm0-3h-2V6h2v4z""/></svg>
    <span class=""signed-in-tab-flash"">You signed in with another tab or window. <a href="""">Reload</a> to refresh your session.</span>
    <span class=""signed-out-tab-flash"">You signed out in another tab or window. <a href="""">Reload</a> to refresh your session.</span>
  </div>
  <div class=""facebox"" id=""facebox"" style=""display:none;"">
  <div class=""facebox-popup"">
    <div class=""facebox-content"" role=""dialog"" aria-labelledby=""facebox-header"" aria-describedby=""facebox-description"">
    </div>
    <button type=""button"" class=""facebox-close js-facebox-close"" aria-label=""Close modal"">
      <svg aria-hidden=""true"" class=""octicon octicon-x"" height=""16"" version=""1.1"" viewBox=""0 0 12 16"" width=""12""><path fill-rule=""evenodd"" d=""M7.48 8l3.75 3.75-1.48 1.48L6 9.48l-3.75 3.75-1.48-1.48L4.52 8 .77 4.25l1.48-1.48L6 6.52l3.75-3.75 1.48 1.48z""/></svg>
    </button>
  </div>
</div>

  

  </body>
</html>

";
            var doc1 = new HtmlDocument();

            doc1.LoadHtml(html);
            var nodes = doc1.DocumentNode.Descendants();
            
             int i = 1;

            return nodes;

        }
    }
}
