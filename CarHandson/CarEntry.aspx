<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarEntry.aspx.cs" Inherits="CarHandson.CarEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CAR SALES APPLICATION</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
<style>
    h2{
        text-align:center;
        font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
        font-size:50px;
        background-color:papayawhip;
        
    }
    table{
        margin:auto;        
        border:dotted;
        border-color:deeppink;

    } 
    td{
        padding: 15px;
    }
    body{
        background-color:palegoldenrod;
    }
      
</style>
</head>
<body>
    <form id="carform" runat="server" >
        <div>
            <header><h2>CarDetails</h2></header>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="CarModel" runat="server" Text="CarModel"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtmodel" runat="server"></asp:TextBox>
                        </td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="CarName"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCategory" runat="server" Text="CarCategory"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtcategory" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtprice" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblYear" runat="server" Text="YearofModel"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtyear" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblDes" runat="server" Text="Description"></asp:Label></td>
                    <td>:</td>
                    <td><asp:TextBox ID="txtdes" runat="server"></asp:TextBox></td>

                </tr>                
            </table>    
            <table>
        <tr>
            <td>
                <asp:Button runat="server" Id="btnSave" Text="Save" class="btn btn-success" OnClick="btnSave_Click" />
                <asp:Button runat="server" Id="btnUpdate" Text="Update" class="btn btn-dark" OnClick="btnUpdate_Click" />
                <asp:Button runat="server" Id="btnDelete" Text="Delete" class="btn btn-primary" OnClick="btnDelete_Click" />
                <asp:Button runat="server" Id="btnReset" Text="Reset" class="btn btn-danger" OnClick="btnReset_Click" />
            </td>
        </tr>
    </table>
        </div>  
        <table>        
            <asp:Label ID="lblResult" runat="server" Text="Result" class="active"></asp:Label>        
        </table>
           <div>
               <asp:GridView ID="GTable" runat="server"></asp:GridView>
           </div>
        
    </form>
    
</body>
    
</html>
