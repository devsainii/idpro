﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="Lenders-DebitingStep1.aspx.cs" Inherits="IDPRO.web.CSR.Lenders_DebitingStep1" %>

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
                                    <li class=""><a href="../../PersonalInfo.aspx">Personal Info</a></li>
                                    <li class=""><a href="../../Creditor.aspx">Creditor Info</a></li>
                                    <li class=""><a href="../../Plan.aspx">Plan Info</a></li>
                                    <li class=""><a href="../../BankInfo.aspx">Bank Info</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class="row-fluid">
                        <div class="span1">
                        </div>
                        <div class="span5">
                            <div class="span10 cs">
                                <blockquote class="example-right">
                                    <p>
                                        Ms. Customer, which lender is drafting you?
                                    </p>
                                </blockquote>
                            </div>
                            <div class="row-fluid">
                                <div class="span10 form-horizontal">
                                    <asp:RadioButtonList ID="rdb" runat="server" CssClass="radio inline" RepeatDirection="Vertical">
                                        <asp:ListItem Text="Unlisted Lender" Value="1" Selected="True" />
                                        <asp:ListItem Text="Lender 1" Value="2" />
                                        <asp:ListItem Text="Lender 2" Value="3" />
                                        <asp:ListItem Text="Lender 3" Value="4" />
                                        <asp:ListItem Text="Lender 4" Value="5" />
                                    </asp:RadioButtonList>
                                    <br />
                                    <br />
                                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-success submit" Text="Select"
                                        OnClick="Button1_Click" />
                                    <span style="float: right;"><b><a href="SelectIssueType.aspx">Back</a></b> </span>
                                </div>
                            </div>
                        </div>
                        <div class="span5">
                            <%--<div class="span10 cs ">
                                <h6 style="padding-top: 50px;">
                                    Select</h6>
                                skkksmmms
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
