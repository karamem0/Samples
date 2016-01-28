<%@ assembly name="$SharePoint.Project.AssemblyFullName$" %>
<%@ assembly name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ import namespace="Microsoft.SharePoint" %>
<%@ import namespace="Microsoft.SharePoint.ApplicationPages" %>
<%@ import namespace="Microsoft.SharePoint.Utilities" %>
<%@ register tagprefix="asp" namespace="System.Web.UI" assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>

<%@ page language="C#" autoeventwireup="true" codebehind="ApplicationPage1.aspx.cs" inherits="Karamem0.Samples.ApplicationPage1" dynamicmasterpagefile="~masterurl/default.master" %>

<asp:content id="PageHead" contentplaceholderid="PlaceHolderAdditionalPageHead" runat="server">
</asp:content>

<asp:content id="Main" contentplaceholderid="PlaceHolderMain" runat="server">
    <h1><%# SPUtility.GetLocalizedString("$Resources: Message", "Resource1", SPContext.Current.Web.Language) %></h1>
</asp:content>

<asp:content id="PageTitle" contentplaceholderid="PlaceHolderPageTitle" runat="server">
    アプリケーション ページ
</asp:content>

<asp:content id="PageTitleInTitleArea" contentplaceholderid="PlaceHolderPageTitleInTitleArea" runat="server">
    マイ アプリケーション ページ
</asp:content>
