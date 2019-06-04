<%@ Page Title="" Language="C#" MasterPageFile="~/backstage/Template.Master" AutoEventWireup="true" CodeBehind="ManagerBlog.aspx.cs" Inherits="fengye.backstage.ManagerBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>FengYe-ManagerBlog</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card alert">
                <div class="card-header">
                    <h4 style="text-align: center">Start Manager Blog</h4>
                </div>
            </div>
            <!-- /# card -->
        </div>
        <!-- /# column -->
    </div>
    <div class="row">
        <div class="col-lg-12">
            <div id="invoice" class="effect2">
                <div id="invoice-bot">

                    <div id="invoice-table">
                        <table class="table table-responsive">
                            <tr class="tabletitle">
                                <td class="table-item">
                                    <h2>Title</h2>
                                </td>
                                <td class="Hours">
                                    <h2>Time</h2>
                                </td>
                                <td class="Rate">
                                    <h2>Author</h2>
                                </td>
                                <td class="subtotal">
                                    <h2>Operation</h2>
                                </td>
                            </tr>
                            
                            <asp:Panel ID="Panel1" runat="server"></asp:Panel>

                        </table>
                    </div>
                    <!--End Table-->


                </div>
                <!--End InvoiceBot-->
            </div>
            <!--End Invoice-->
        </div>
    </div>
    <!-- /# row -->
</asp:Content>
