<%@ Assembly Name="AOPinSharePoint, Version=1.0.0.0, Culture=neutral, PublicKeyToken=0670e2248928a50f" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AopExamplesWebPartUserControl.ascx.cs" Inherits="AOPinSharePoint.AopExamplesWebPart.AopExamplesWebPartUserControl" %>


<div style="max-width:100%; width:100%;">
    
    <div style="float:left; max-width:25%; width:25%;">
        <div style="padding:5px 0 0 10px;">Examples</div>
        <div style="padding-top: 5px;">
            <asp:Button ID="Example01Button" runat="server" Text="Ex #1: Basic Feature Code" Width="100%" OnClick="Example01Button_Click" Font-Names="Corbel" />        
        </div>
        <div style="padding-top: 5px;">
            <asp:Button ID="Example02Button" runat="server" Text="Ex #2: Feature Code with Logging" Width="100%" OnClick="Example02Button_Click" Font-Names="Corbel" />        
        </div>
        <div style="padding-top: 5px;">
            <asp:Button ID="Example03Button" runat="server" Text="Ex #3: Simplified Logging With Aspect" Width="100%" OnClick="Example03Button_Click" Font-Names="Corbel" />
        </div>
    </div>

    <div style="float:right; max-width:72%; padding: 5px 0 0 5px; width:72%;">
        <div style="padding-bottom:5px;">Output</div>
        <asp:TextBox ID="ResultsTextbox" runat="server" TextMode="MultiLine" ReadOnly="True" Rows="10" Width="100%" EnableViewState="False" Font-Names="Corbel" ForeColor="#87234B"></asp:TextBox>
        <div style="padding: 10px 0 5px 0;">Logging</div>
        <asp:TextBox ID="LogTextbox" runat="server" TextMode="MultiLine" ReadOnly="True" Rows="12" Width="100%" EnableViewState="False" Font-Names="Courier New"></asp:TextBox>
    </div>

</div>
