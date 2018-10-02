<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ContactForm.ascx.vb" Inherits="Control_ContactUs_Control_"  %>
<style type="text/css">
    .auto-style1 {
        width: 100px;
    }
</style>
<%--<script type="text/javascript">

//    function ValidatePhoneNumber(source, args)
//    {
//        var txtHomePhone = document.getElementById('<%=txtHomePhone.ClientID%>');
//        var txtWorkPhone = document.getElementById('<%=txtWorkPhone.ClientID%>');

//        if (txtHomePhone.value != '' || txtWorkPhone.value != '')
//        {
//            args.IsValid = true;
//        }
//        else {
//            args.IsValid = false;

//        }
//    }
</script>--%>
<body style="text-align: center">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

<table runat="server" id="TableFormat">
    <tr>
        <td colspan="3">Contact Us !<br /> 
            Contact us in this form
        </td>
    </tr>
    <tr>
        <td>Name</td>
        <td class="auto-style1">
            <asp:TextBox runat="server" ID="txtName" /></td>
        <td>
            <asp:RequiredFieldValidator ID="ValNameRequired"
                runat="server"
                ErrorMessage="Name Required"
                ControlToValidate="txtName"
                Text="*"
                SetFocusOnError="true"
                Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

        </td>
    </tr>
    <tr>
        <td>Email</td>
        <td class="auto-style1">
            <asp:TextBox ID="txtEmial1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="ValEmialRequired"
                runat="server"
                ErrorMessage="Emial Required"
                ControlToValidate="txtEmial1"
                Text="*"
                SetFocusOnError="true"
                Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

            <asp:RegularExpressionValidator ID="ValEmialFormat" runat="server"
                ErrorMessage="Check Emial Format"
                ControlToValidate="txtEmial1"
                Text="*"
                Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>

        </td>
    </tr>
    <tr>
        <td>Your Emial Again</td>
        <td class="auto-style1">
            <asp:TextBox ID="txtEmial2" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="valEmial2Required"
                runat="server"
                ErrorMessage="Your Confairmation Required"
                ControlToValidate="txtEmial2"
                Text="*"
                SetFocusOnError="true"
                Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ErrorMessage="Emial Confairmation dos not match "
                ControlToValidate="txtEmial2"
                ControlToCompare="txtEmial1"
                Type="String"
                Text="*"
                SetFocusOnError="true"
                Display="Dynamic" ForeColor="Red" ></asp:CompareValidator>

        </td>
    </tr>
    <tr>
       <%-- <td>Home Phone</td>
        <td class="auto-style1">
            <asp:TextBox ID="txtHomePhone" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:CustomValidator ID="ValCustHomePhone" runat="server" 
                ErrorMessage="Home or Work  Phone Required"
                Text="*"
                Display="Dynamic"
                ClientValidationFunction="ValidatePhoneNumber" ForeColor="Red"
                ></asp:CustomValidator>

        </td>--%>
    </tr>
    <tr>
        <td>Work Phone</td>
        <td class="auto-style1">
            <asp:TextBox ID="txtWorkPhone" runat="server"></asp:TextBox>
        </td>
        <td>
            

        </td>
    </tr>
    <tr>
        <td>Comments</td>
        <td class="auto-style1">
            <asp:TextBox ID="txtComments" runat="server" TextMode="MultiLine" style="margin: 0px; width: 690px; height: 124px;"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="ValCommentesRequired"
                runat="server"
                ErrorMessage="Comments Required"
                ControlToValidate="txtComments"
                Text="*"
                SetFocusOnError="true"
                Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td></td>
        <td class="auto-style1">
            <asp:Button ID="btnsend" runat="server" Text="send" Width="76px" /></td>
        <td></td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </td>
    </tr>

</table>
  <br />
 <asp:Label ID="lblsent" runat="server" Text="your mail is sent" Visible="false"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
        AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate  >
            <div class="peleasewait">
                please wait while well we send your email
             </div>
        </ProgressTemplate>
    </asp:UpdateProgress>

