<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="AccountUpdate.aspx.cs" Inherits="IDPRO.web.CSR.AccountUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row-fluid">
        <div class="span12">
            <div class="box">
                <div class="box-header">
                    <span class="title">Customer Service</span>
                </div>
                <div class="box-content">
                    <div class="row-fluid">
                        <div class="span12">
                            <div class="tabbable margin-small">
                                <ul class="nav nav-tabs">
                                    <li class=""><a href="CustomerService.aspx">Home</a></li>
                                    <li class=""><a href="PersonalInfo.aspx">Personal Info</a></li>
                                    <li class=""><a href="Creditor.aspx">Creditor Info</a></li>
                                    <li class=""><a href="Plan.aspx">Plan Info</a></li>
                                    <li class=""><a href="BankInfo.aspx">Bank Info</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="span12">
                            <div class="row-fluid">
                                <div class="span11 ">
                                    <h3 class="title-divider">
                                        <span>Account Update Request</span></h3>
                                    <%--<div class="span12">
                                         
                                        <div class="control-group  text-center">
                                            <div class="controls">
                                             <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" CssClass="btn btn-success submit" /> <b><a
                                                    href="SelectIssueType.aspx">Back</a></b>
                                            </div>
                                        </div>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                        <div class="span11">
                            <div class="span8 cs">
                                <blockquote class="example-right">
                                    <p>
                                        I would be happy to give you an update on how your program is progressing!
                                        <ul>
                                            <li>X out of z drafts have successfully cleared </li>
                                            <li>The final draft of your program is currently scheduled for [Date]. Remember that
                                                many customers do not require the last few drafts of their program.</li>
                                            <li>We have settled with x lenders
                                                <ul>
                                                    <li>ABC</li>
                                                    <li>BCD</li>
                                                    <li>CDE</li>
                                                </ul>
                                            </li>
                                            <li>We are still negotiating with your remaining lenders
                                                <ul>
                                                    <li>DEF</li>
                                                    <li>EFG</li>
                                                    <li>FGH</li>
                                                </ul>
                                            </li>
                                        </ul>
                                    </p>
                                </blockquote>
                            </div>
                            <div class="span6">
                                <span style="float: right;"><b><a href="SelectIssueType.aspx">Back</a></b> </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
