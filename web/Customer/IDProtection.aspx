<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="IDProtection.aspx.cs" Inherits="IDPRO.web.Customer.IDProtection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <div class="box">
                <div class="box-header">
                    <span class="title">Customer</span>
                </div>
                <div class="box-content">
                    <div class="row-fluid">
                        <div class="span12">
                            <div class="tabbable">
                                <ul class="nav nav-tabs">
                                    <li class=""><a href="PersonalInfo.aspx">Personal Info</a></li>
                                    <li class=""><a href="BankInfo.aspx">Bank Info</a></li>
                                    <li class=""><a href="Creditor.aspx">Creditor Info</a></li>
                                    <li class=""><a href="PlanInfo.aspx">Plan Info</a></li>
                                    <li class=""><a href="Drafts.aspx">Drafts</a></li>
                                    <li class=""><a href="DateJournals.aspx">Date Journal</a></li>
                                    <li class="active"><a href="IDProtection.aspx">ID Protection</a></li>
                                    <li class=""><a href="TicketHistory.aspx">Ticket History</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="row-fluid">
                        <div class="span12">
                            <h3 class="title-divider">
                                <span>ID Protection</span></h3>
                            <div class="span1">
                                Client
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="ddl" runat="server" CssClass="span9">
                                    <asp:ListItem>Yes - GCS Bill</asp:ListItem>
                                    <asp:ListItem>Yes - Direct Bill</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem>Docs Out</asp:ListItem>
                                    <asp:ListItem>Follow Up</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="span7">
                                    <asp:ListItem>Default</asp:ListItem>
                                    <asp:ListItem>1st</asp:ListItem>
                                    <asp:ListItem>2nd</asp:ListItem>
                                    <asp:ListItem>3rd</asp:ListItem>
                                    <asp:ListItem>4th</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1">
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1">
                                <asp:DropDownList ID="DropDownList5" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row-fluid">
                        <div class="span12">
                         <h3>
                                 </h3>
                            <div class="span1">
                               Co-Client
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList6" runat="server" CssClass="span9">
                                    <asp:ListItem>Yes - GCS Bill</asp:ListItem>
                                    <asp:ListItem>Yes - Direct Bill</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                    <asp:ListItem>Docs Out</asp:ListItem>
                                    <asp:ListItem>Follow Up</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList7" runat="server" CssClass="span7">
                                    <asp:ListItem>Default</asp:ListItem>
                                    <asp:ListItem>1st</asp:ListItem>
                                    <asp:ListItem>2nd</asp:ListItem>
                                    <asp:ListItem>3rd</asp:ListItem>
                                    <asp:ListItem>4th</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList8" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1">
                                <asp:DropDownList ID="DropDownList9" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span2">
                                <asp:DropDownList ID="DropDownList10" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1">
                                <asp:DropDownList ID="DropDownList11" runat="server" CssClass="span9">
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                    <asp:ListItem></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
