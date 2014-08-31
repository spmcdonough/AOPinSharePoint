<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AopPartUserControl.ascx.cs" Inherits="AOPinSharePoint.AopPart.AopPartUserControl" %>


<div style="max-width:100%; width:100%;">
    
    <div style="float:left; max-width:20%; padding:1%; width:20%;">
        <asp:Button ID="Example01Button" runat="server" Text="Example #1: Basic Functionality" Width="100%" OnClick="Example01Button_Click" />
    </div>

    <div style="max-width:76%; padding:1%; width:75%;">
        <asp:TextBox ID="ResultsTextbox" runat="server" TextMode="MultiLine" ReadOnly="True" Rows="20" Width="100%" EnableViewState="False"></asp:TextBox>
    </div>

</div>