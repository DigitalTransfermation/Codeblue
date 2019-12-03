<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminreport.aspx.cs" Inherits="employeevote.assets.adminreport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Basic Page Needs ================================================== -->
    <meta charset="utf-8"/>

    <!-- Mobile Specific Metas ================================================== -->
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0"/>

    <!-- Site Title -->
    <title>Nippon Paint Stars</title>
        <link rel="shortcut icon" type="image/png" href="https://nipponpaint.co.in/wp-content/uploads/2018/04/favicon.png" />


    <!-- CSS
         ================================================== -->
    <!-- Bootstrap -->
    <link rel="stylesheet" href="css/bootstrap.min.css"/>

    <!-- FontAwesome -->
    <link rel="stylesheet" href="css/font-awesome.min.css"/>
    <!-- Animation -->
    <link rel="stylesheet" href="css/animate.css"/>
    <!-- magnific -->
    <link rel="stylesheet" href="css/magnific-popup.css"/>
    <!-- carousel -->
    <link rel="stylesheet" href="css/owl.carousel.min.css"/>
    <!-- isotop -->
    <link rel="stylesheet" href="css/isotop.css"/>
    <!-- ico fonts -->
    <link rel="stylesheet" href="css/xsIcon.css"/>
    <!-- Template styles-->
    <link rel="stylesheet" href="css/style.css"/>
    <!-- Responsive styles-->
    <link rel="stylesheet" href="css/responsive.css"/>
</head>
<body>
    <form id="form1" runat="server">
       <div class="body-inner">
        <!-- Header start -->
        <header id="header" class="header header-classic" style="    background-color: #2c0f8b;">
            <div class="container">
                <nav class="navbar navbar-expand-lg navbar-light">
                    <!-- logo-->
                    <a class="navbar-brand" href="adminreport">
                      <img src="https://nipponpaint.co.in/wp-content/uploads/2018/04/Nippon-Logo.png" style="height: 80px;" alt="">

                    </a>
                   
                </nav>
            </div><!-- container end-->
        </header>
        <!--/ Header end -->
        <!-- banner start-->
        
        <!-- banner end-->
    
    
        <!-- ts map direction start-->
        <section class="ts-map-direction wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="400ms" style="padding-top: 10px;">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <h2 class="column-title">
                          <%--  <span>Reach us</span>--%>
                            Get Reports for all your need.
                        </h2>

                        <div class="ts-map-tabs">
                            <ul class="nav" role="tablist">
                                <li class="nav-item">
                                    <a class="nav-link active" href="#profile" role="tab" data-toggle="tab">Employee Votes</a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" href="#buzz" role="tab" data-toggle="tab">Nominee Votes</a>
                                </li>
                                <%--<li class="nav-item">
                                    <a class="nav-link" href="#references" role="tab" data-toggle="tab">How to get there</a>
                                </li>--%>
                            </ul>

                            <!-- Tab panes -->
                            <div class="tab-content direction-tabs">
                                <div role="tabpanel" class="tab-pane active" id="profile">
                                    <div class="direction-tabs-content">
                                        <div class="row">
                                        <h3> <asp:Button ID="btnfullsummery" runat="server" class="btn" OnClick="btnfullsummery_Click" Text="Export to Excel" Style="font-size: 13px;margin-top: -8px;float: right;padding-left: 10px;padding-right: 10px;margin-left: 19px;" />
</h3>
                                            </div>
                                    <%--    <p class="derecttion-vanue">

                                        </p>--%>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="contact-info-box">
                                                 
                                                    <asp:GridView ID="gvfullsummery" runat="server" Width="100%" AutoGenerateColumns="false" Font-Size="Small"
                                                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                    CssClass="table table-striped table-bordered table-hover table-responsive" RowStyle-Wrap="true"
                                                    SelectedRowStyle-BackColor="Yellow" AllowSorting="true" PageSize="15" AllowPaging="false" ShowHeaderWhenEmpty="True">
                                                    <EmptyDataTemplate>No Records Found</EmptyDataTemplate>
                                                    <Columns>


                                                        <asp:TemplateField HeaderStyle-Width="50">
                                                            <HeaderTemplate>S.No</HeaderTemplate>
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblSRNO" runat="server"
                                                                    Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                                                            </ItemTemplate>

                                                            <HeaderStyle Width="50px"></HeaderStyle>

                                                        </asp:TemplateField>

                                                        <asp:TemplateField HeaderText="Employee Name" HeaderStyle-Width="20%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblEmpname" runat="server" Text='<%#Eval("Empname") %>' />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                         <asp:TemplateField HeaderText="EmployeeNo" HeaderStyle-Width="10%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblempno" runat="server" Text='<%#Eval("EMP_No") %>' />

                                                            </ItemTemplate>
                                                        </asp:TemplateField>

                                                        <asp:TemplateField HeaderText="Employee Division" HeaderStyle-Width="10%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblEmpdivision" runat="server" Text='<%#Eval("EmpBusinessUnit") %>' />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                         <asp:TemplateField HeaderText="Voted To" HeaderStyle-Width="20%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblvotename" runat="server" Text='<%#Eval("votename") %>' />

                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Voted On" HeaderStyle-Width="20%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblEmpvotedon" runat="server" Text='<%#Eval("Empvotedon","{0:dd-MM-yyyy HH:MM:tt }") %>' />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                       
                                                       

                                                        <asp:TemplateField HeaderText="Division" HeaderStyle-Width="20%">
                                                            <ItemTemplate>
                                                                <asp:Label ID="lblVoteDivision" runat="server" Text='<%#Eval("VoteDivision") %>' />
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <%-- <asp:TemplateField HeaderText="Location">
                                                <ItemTemplate>
                                                    <asp:Label ID="lbllocation" runat="server" Text='<%#Eval("location") %>' />
                                                </ItemTemplate>
                                            </asp:TemplateField>--%>
                                                    </Columns>
                                                    <FooterStyle BackColor="White" ForeColor="#000066" />
                                                    <HeaderStyle BackColor="#284177" Font-Bold="True" ForeColor="White" />
                                                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Font-Bold="true" Font-Size="12" />
                                                    <RowStyle ForeColor="#000066" />
                                                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                    <%--                                      <PagerSettings Mode="Numeric" />--%>
                                                </asp:GridView>
                                                </div>

                                            </div>
                                           
                                        </div><!-- row end-->
                                    </div><!-- direction tabs end-->
                                </div><!-- tab pane end-->
                                <div role="tabpanel" class="tab-pane fade" id="buzz">
                                    <div class="direction-tabs-content">
                                        <div class="row">
                                        <h3>  <asp:Button ID="btncountsummery" OnClick="btncountsummery_Click" runat="server" class="btn" Text="Export to Excel" Style="font-size: 13px;margin-top: -8px;float: right;padding-left: 10px;padding-right: 10px;margin-left: 19px;" />
</h3>
                                            </div>
                                       <%-- <p class="derecttion-vanue">
                                            1Hd- 50, 010 Avenue, NY 90001<br />
                                            United States
                                        </p>--%>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="contact-info-box">
                                               <asp:GridView ID="gvdetailview" runat="server" AutoGenerateColumns="false" Font-Size="Small"
                                                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
                                                CssClass="table table-striped table-bordered table-hover table-responsive" RowStyle-Wrap="true"
                                                SelectedRowStyle-BackColor="Yellow" AllowSorting="true" ShowHeader="True" PageSize="15" AllowPaging="false">
                                                <EmptyDataTemplate>No Records Found</EmptyDataTemplate>
                                                <Columns>
                                                    <asp:TemplateField HeaderText="Nominee Name" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="left">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblvotename" runat="server" Text='<%#Eval("Name") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Vote Count" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblvotes" runat="server" Text='<%#Eval("votes") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>
                                                      <asp:TemplateField HeaderText="Division" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                        <ItemTemplate>
                                                            <asp:Label ID="lblVoteDivision" runat="server" Text='<%#Eval("Division") %>' />
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <%--    <asp:TemplateField HeaderText="CORPORATE OFFICE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblAR3" runat="server" Text='<%#Eval("AR-3") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="DECORATIVE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblAR4" runat="server" Text='<%#Eval("AR-4") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="INDUSTRIAL UNIT" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblco1" runat="server" Text='<%#Eval("CO-1") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="AUTOMOTIVE REFINISH" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblco2" runat="server" Text='<%#Eval("CO-2") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="CORPORATE OFFICE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblco3" runat="server" Text='<%#Eval("co-3") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="DECORATIVE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblco4" runat="server" Text='<%#Eval("co-4") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>


                                                  <asp:TemplateField HeaderText="INDUSTRIAL UNIT" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDECO1" runat="server" Text='<%#Eval("DECO-1") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="AUTOMOTIVE REFINISH" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDECO2" runat="server" Text='<%#Eval("DECO-2") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="CORPORATE OFFICE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDECO3" runat="server" Text='<%#Eval("DECO-3") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="DECORATIVE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDECO4" runat="server" Text='<%#Eval("DECO-4") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                   <asp:TemplateField HeaderText="INDUSTRIAL UNIT" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIU1" runat="server" Text='<%#Eval("IU-1") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="AUTOMOTIVE REFINISH" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIU2" runat="server" Text='<%#Eval("IU-2") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="CORPORATE OFFICE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIU3" runat="server" Text='<%#Eval("IU-3") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="DECORATIVE" ItemStyle-HorizontalAlign="Center">
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblIU4" runat="server" Text='<%#Eval("IU-4") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>--%>
                                                </Columns>
                                                <FooterStyle BackColor="White" ForeColor="#000066" />
                                                <HeaderStyle BackColor="#284177" Font-Bold="True" ForeColor="White" />
                                                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Font-Bold="true" Font-Size="12" />
                                                <RowStyle ForeColor="#000066" />
                                                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                <SortedDescendingHeaderStyle BackColor="#00547E" />
                                                <%--                                      <PagerSettings Mode="Numeric" />--%>
                                            </asp:GridView>

                                                </div>

                                            </div>
                                          
                                        </div><!-- row end-->
                                    </div><!-- direction tabs end-->
                                </div>
                                <div role="tabpanel" class="tab-pane fade" id="references">
                                    <div class="direction-tabs-content">
                                        <h3>Brighton Waterfront Hotel, Brighton, London</h3>
                                        <p class="derecttion-vanue">
                                            1Hd- 50, 010 Avenue, NY 90001<br />
                                            United States
                                        </p>
                                        <div class="row">
                                            <div class="col-md-6">
                                                <div class="contact-info-box">
                                                    <h3>Tickets info </h3>
                                                    <p><strong>Name:</strong> Ronaldo König</p>
                                                    <p><strong>Phone:</strong> 009-215-5595</p>
                                                    <p><strong>Email: </strong> info@example.com</p>
                                                </div>

                                            </div>
                                            <div class="col-md-6">
                                                <div class="contact-info-box">
                                                    <h3>Programme Details </h3>
                                                    <p><strong>Name:</strong> Ronaldo König</p>
                                                    <p><strong>Phone:</strong> 009-215-5595</p>
                                                    <p><strong>Email: </strong> info@example.com</p>
                                                </div>
                                            </div>
                                        </div><!-- row end-->
                                    </div><!-- direction tabs end-->
                                </div>
                            </div>

                        </div><!-- map tabs end-->

                    </div><!-- col end-->
                
                </div><!-- col end-->
            </div><!-- container end-->
            <%--<div class="speaker-shap">
                <img class="shap1" src="images/shap/Direction_memphis3.png" alt="">
                <img class="shap2" src="images/shap/Direction_memphis2.png" alt="">
                <img class="shap3" src="images/shap/Direction_memphis4.png" alt="">
                <img class="shap4" src="images/shap/Direction_memphis1.png" alt="">
            </div>--%>
        </section>
        <!-- ts map direction end-->
        <!-- ts footer area start-->
        <div class="footer-area">

            <!-- ts-book-seat start-->
          
            <!-- book seat  end-->
            <!-- footer start-->
            <footer class="ts-footer">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">
                            
                        
                            <div class="copyright-text text-center">
                                <p>Copyright © 2019 NipponPaint. All Rights Reserved.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
            <!-- footer end-->
            <div class="BackTo">
                <a href="#" class="fa fa-angle-up" aria-hidden="true"></a>
            </div>
        </div>
        <!-- ts footer area end-->
        <!-- Javascript Files
          ================================================== -->
        <!-- initialize jQuery Library -->
        <script src="js/jquery.js"></script>

        <script src="js/popper.min.js"></script>
        <!-- Bootstrap jQuery -->
        <script src="js/bootstrap.min.js"></script>
        <!-- Counter -->
        <script src="js/jquery.appear.min.js"></script>
        <!-- Countdown -->
        <script src="js/jquery.jCounter.js"></script>
        <!-- magnific-popup -->
        <script src="js/jquery.magnific-popup.min.js"></script>
        <!-- carousel -->
        <script src="js/owl.carousel.min.js"></script>
        <!-- Waypoints -->
        <script src="js/wow.min.js"></script>
        <!-- isotop -->
        <script src="js/isotope.pkgd.min.js"></script>

        <!-- Template custom -->
        <script src="js/main.js"></script>

    </div>
    </form>
</body>
</html>
