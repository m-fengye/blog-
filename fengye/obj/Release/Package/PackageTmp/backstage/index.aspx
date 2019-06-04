<%@ Page Title="" Language="C#" MasterPageFile="~/backstage/Template.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="fengye.backstage.manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>FengYe-Manager</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="card alert">
                <div class="card-header">
                    <h4 style="text-align:center">Welcome To FengYe Blog Manager System</h4>
                </div>
                <div class="card-body">
                </div>
            </div>
            <!-- /# card -->
        </div>
        <!-- /# column -->
    </div>
    <!-- /# row -->
    <div class="row">
        <div class="col-lg-3">
            <div class="card">
                <div class="stat-widget-two">
                    <div class="widget-icon color-1">
                        <i class="fas fa-bullseye"></i>
                    </div>
                    <div class="stat-content">
                        <div class="stat-text">CPU Use</div>
                    </div>
                    <div class="progress">
                        <div id="cpu" runat="server" class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="85" aria-valuemin="0" aria-valuemax="100" style="width: 85%;"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /# column -->
        <div class="col-lg-3">
            <div class="card">
                <div class="stat-widget-two">
                    <div class="widget-icon color-2">
                        <i class="fas fa-credit-card"></i>
                    </div>
                    <div class="stat-content">
                        <div class="stat-text">Memory Use</div>
                    </div>
                    <div class="progress">
                        <div class="progress-bar progress-bar-primary" role="progressbar" aria-valuenow="78" aria-valuemin="0" aria-valuemax="100" style="width: 78%;"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /# column -->
        <div class="col-lg-3">
            <div class="card">
                <div class="stat-widget-two">
                    <div class="widget-icon color-3">
                        <i class="fas fa-tasks"></i>
                    </div>
                    <div class="stat-content">
                        <div class="stat-text">Disk Use</div>
                    </div>
                    <div class="progress">
                        <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="50" aria-valuemin="0" aria-valuemax="100" style="width: 50%;"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /# column -->
        <div class="col-lg-3">
            <div class="card">
                <div class="stat-widget-two">
                    <div class="widget-icon color-4">
                        <i class="fas fa-users"></i>
                    </div>
                    <div class="stat-content">
                        <div class="stat-text">Today Visitor</div>
                    </div>
                    <div class="progress">
                        <div class="progress-bar progress-bar-danger" role="progressbar" aria-valuenow="65" aria-valuemin="0" aria-valuemax="100" style="width: 65%;"></div>
                    </div>
                </div>
            </div>
        </div>
        <!-- /# column -->
    </div>
    <!-- /# row -->
    
</asp:Content>
