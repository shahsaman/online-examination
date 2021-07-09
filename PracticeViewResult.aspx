<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PracticeViewResult.aspx.cs" Inherits="PracticeResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Practice Result</title>
    <style type="text/css">

    .qb
    {
    border: solid 1px;
    }
    
    #Label61
    {
        font-family:Lucida Handwriting;
    }

    
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <asp:Label ID="Label61" runat="server" Text="Label"></asp:Label>
    <br />
    <br />


    <br />

    <div class="qb">
    &nbsp;Question 1 :
    <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="#0000CC"></asp:Label>
    
    <br />
    Option Selected :
    <asp:Label ID="Label2" runat="server" Text="Label" ForeColor="Red"></asp:Label>
&nbsp;<br />
    Right Answer :&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Label" ForeColor="Lime"></asp:Label>
    </div>
    <br />
    <br />
    

    
    <div class="qb">
    Question 2 : 
    <asp:Label ID="Label4" runat="server" Text="Label"  ForeColor="#0000CC"></asp:Label>
    <br />
   Option Selected :
    <asp:Label ID="Label5" runat="server" Text="Label" ForeColor="Red"></asp:Label>
&nbsp;<br />
    Right Answer :
    <asp:Label ID="Label6" runat="server" Text="Label"  ForeColor="Lime"></asp:Label>
    </div>
    <br />
    <br />
    


     <div class="qb">
    Question 3 : 
    <asp:Label ID="Label7" runat="server" Text="Label" ForeColor="#0000CC"></asp:Label>
    <br />
   Option Selected :
    <asp:Label ID="Label8" runat="server" Text="Label" ForeColor="Red"></asp:Label>
&nbsp;<br />
    Right Answer :
    <asp:Label ID="Label9" runat="server" Text="Label"  ForeColor="Lime"></asp:Label>
    </div>
    <br />
    <br />

     <div class="qb">
    Question 4 : 
    <asp:Label ID="Label10" runat="server" Text="Label" ForeColor="#0000CC"></asp:Label>
    <br />
   Option Selected :
    <asp:Label ID="Label11" runat="server" Text="Label" ForeColor="Red"></asp:Label>
&nbsp;<br />
    Right Answer :
    <asp:Label ID="Label12" runat="server" Text="Label"  ForeColor="Lime"></asp:Label>
    </div>
    <br />
    <br />


     <div class="qb">
    Question 5 : 
    <asp:Label ID="Label13" runat="server" Text="Label" ForeColor="#0000CC"></asp:Label>
    <br />
   Option Selected :
    <asp:Label ID="Label14" runat="server" Text="Label" ForeColor="Red"></asp:Label>
&nbsp;<br />
    Right Answer :
    <asp:Label ID="Label15" runat="server" Text="Label"  ForeColor="Lime"></asp:Label>
    </div>
    <br />
    <br />

    </form>
</body>
</html>
