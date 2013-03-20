﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true"
    CodeBehind="Graduation-Step2.aspx.cs" Inherits="IDPRO.web.CSR.Graduation_Step2" %>

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
                        <div class="span5 offset1">
                            <asp:UpdatePanel ID="update2" runat="server">
                                <ContentTemplate>
                                    <div class="row-fluid">
                                        <asp:Panel ID="pnlCourtesy3" runat="server" Visible="true">
                                            <div class="span10 cs">
                                                <blockquote class="example-right">
                                                    <p>
                                                        Thank you! Locate an orienation rep to take the call. OK, Mr. Customer, I am getting
                                                        you over to [orientation rep name] now. Thank you again for your business!
                                                    </p>
                                                </blockquote>
                                            </div>
                                        </asp:Panel>
                                        <asp:Panel ID="pnlNo" runat="server" Visible="false">
                                            <div class="span10 cs">
                                                <blockquote class="example-right">
                                                    <p>
                                                        I understand you are busy Mr. Customer. I will have a Graduation rep give you a
                                                        call back! Thank you again for your business!
                                                    </p>
                                                </blockquote>
                                            </div>
                                        </asp:Panel>
                                        <div class="span10 form-horizontal">
                                            <asp:RadioButtonList ID="rdbSure" AutoPostBack="true" runat="server" CssClass="radio inline"
                                                RepeatDirection="Vertical" OnSelectedIndexChanged="rdbSure_SelectedIndexChanged">
                                                <asp:ListItem Text="Sure!" Selected="True" Value="1" />
                                                <asp:ListItem Text="No" Value="2" />
                                            </asp:RadioButtonList>
                                            <br />
                                            <span style="float: right;"><b><a href="Graduation.aspx">Back</a></b> </span>
                                        </div>
                                    </div>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
