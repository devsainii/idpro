<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="Drafts.aspx.cs" Inherits="IDPRO.web.Customer.Drafts" %>

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
                                    <li class="active"><a href="Drafts.aspx">Drafts</a></li>
                                    <li class=""><a href="DateJournals.aspx">Date Journal</a></li>
                                    <li class=""><a href="IDProtection.aspx">ID Protection</a></li>
                                    <li class=""><a href="TicketHistory.aspx">Ticket History</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row-fluid">
                        <div class="span12">
                            <div class="form-horizontal form-large">
                                <h3 class="title-divider">
                                    <span>Draft Details</span></h3>
                                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered table-condensed"
                                    GridLines="None" AutoGenerateColumns="False">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="NewAccountNumber" HeaderText="Effective Date" />
                                        <asp:BoundField DataField="Type" HeaderText="Amount" />
                                        <asp:BoundField DataField="Name" HeaderText="Status" />
                                    </Columns>
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <br />
                    <%--<div class="row-fluid">
                        <div class="span3 offset5">
                            <asp:Button ID="btn" runat="server" Text="Save & Next" CssClass="btn btn-success submit" />
                        </div>
                    </div>--%>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
