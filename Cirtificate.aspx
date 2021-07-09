<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cirtificate.aspx.cs" Inherits="Cirtificate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        #d2
        {
            border:solid 1px;
            background-color:Silver;
            width:1000px;
            margin-left:200px;
            margin-top:150px;
            
            
        }
    .d1
    {
        float:left;
        padding:10px;
        }
        #dd
        {
            
            width: 98px;
            height: 79px;
        }
        #d3
        {
            
            width: 976px;
            height: 79px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server" >
    <div id="d2" style="background-color:#c9f02f;align-items:center">
    <div>
    
      <div class="d1" id="d3">
      <h1 style="color:white;position:absolute;z-index:10;text-align:center; top: 175px; left: 218px; width: 986px; height: 80px;
 background-color:#02aab0;">Certificate of Excellence</h1>
        
      
      </div>


&nbsp;<br />
        <br />
&nbsp;
        <asp:Label ID="Label1" runat="server" Style="position:absolute;font-weight:500;font-size:50px;color:black; top: 324px; left: 663px;"></asp:Label>
        </div>
    <br />
    <br />
    <br />
    <p style="position:absolute;color:black;text-align:center; top: 415px; left: 393px; width: 627px;">You have successfully completed the <asp:Label ID="Label2" runat="server"></asp:Label> exam from STAS</p>
        <br />
    <br />
    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    <br />
    <br />

    <br />

        <br />
                       <br /><br />                        
                                          
                        
                    </div>  
                    <br />
                <asp:Button ID="Button1" runat="server" Text="Print"
                    OnClientClick="JavaScript:window.print();" 
        onclick="Button1_Click" CausesValidation="False"/>
                <br /><br />              
                </div>
                </div>
    </form>
</body>
</html>
