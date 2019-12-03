<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vote.aspx.cs" Inherits="employeevote.assets.vote" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

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



    <style>
        .header.h-transparent2 {
            padding: 0px 0;
        }
        .Para1{
      height: 200px;
    overflow-y: scroll;
        }
         .ts-speaker-popup .ts-speaker-popup-content {
    padding: 32px 40px;
}
       
        @media (min-width: 650px) {
            .row {
                width: 118%;
            }
           
            .col-lg-6 {
                -ms-flex: 0 0 50%;
                flex: 0 0 50%;
                max-width: 45% !important;
            }

            .ts-speaker .speaker-img {
                width: 200px !important;
                height: 200px !important;
                position: relative;
                border-radius: 50%;
                -webkit-border-radius: 50%;
                -ms-border-radius: 50%;
                overflow: hidden;
                margin: auto auto 20px;
            }

            .ts-speakers {
                padding-top: 0px;
                padding-bottom: 0px;
                position: relative;
                overflow: hidden;
                /* margin-top: -24px; */
                padding-top: 0px;
            }

            .ts-speaker-info {
                margin-left: 49px;
            }

            .mx-auto {
                /* margin-left: auto!important; */
                margin-left: -80px !important;
            }

            .imgsec1 {
                margin-top: 60px;
            }

            .logout1 {
                color: white;
                font-size: smaller;
                padding-left: 10px;
            }
              .Para1{
      height: 200px;
    overflow-y: scroll;
        }
         .ts-speaker-popup .ts-speaker-popup-content {
    padding: 32px 40px;
}
        }

        @media (max-width: 649px) {
            .banner-6-alt .banner-item .banner-content-wrap {
                padding: 190px 0 0px !important;
            }

            .profile {
                /*margin-left: -139px;
                margin-top: -16px;*/ /*minnapan code*/
                margin-top: -16px;
                padding-right: 198px;
            }


            .status {
                display: inline;
                float: right;
                margin-top: -39px;  /*venkat line*/
                padding-right: 5px;
                line-height: 20px;  /*venkat line*/
            }

            .statuscol {
                padding-top: 0px;
                margin-top: -30px;
            }

            .voted {
                margin-left: 22px;
            }

            .votedlabel {
            }

            .pendinglable {
            }

            .pending {
                margin-left: -2px;
            }

            .badge1 {
                background: white;
                border-radius: 11px;
                color: #ff2d55;
                height: -3px;
                padding-left: 6px;
                padding-right: 6px;
                font-size: 11px;
            }

            .badge2 {
                background: white;
                border-radius: 7px;
                color: #ff2d55;
                height: -3px;
                padding-left: 5px;
                padding-right: 5px;
                font-size: 10px;
            }

            .logout {
                margin-left: 17px;
                padding-right: 0px;
            }

            .welcome1 {
                /*margin-right: 90px;*/
                /*margin-right: -51px;*/
                margin-right: 0px;
                line-height: 1.2;
                margin-top: 5px;
            }
        }


        @media (max-width: 767px) {
            .navbar-brand img {
                width: auto;
                max-width: 180px;
                height: 50px !important;
                margin-bottom: 5px;
            }

            .profile {
                margin-top: -16px;
                padding-right: 196px;
                font-size: 13px;
            }
        }
        @media (max-width: 736px) {
            .profile {
                padding-right: 234px !important;

            }

        }
    </style>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <%--<script type="text/javascript">

        $(document).ready(function () {
            // Handler for .ready() called.
            $('html, body').animate({
                scrollTop: $('#ts-speakersdeco').offset().top
            }, 'slow');
        });

    </script>--%>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>



        <div class="body-inner">
            <!-- Header start -->
            <header id="header" class="header header header-transparent h-transparent2" style="background-color: #2c0f8b;">
                <div class="container">
                    <div class="row justify-content-between align-items-center">
                        <div class="col-lg-2 col-6">
                            <!-- logo-->
                            <a class="navbar-brand logo" href="vote">
                                <img src="https://nipponpaint.co.in/wp-content/uploads/2018/04/Nippon-Logo.png" style="height: 80px;" alt="">
                            </a>
                        </div>
                        <div class="col-md-4 profile welcome">
                            <span style="float: right; color: #f4f4f4;" class="welcome1">Welcome
                                <br />
                                <%-- <span id="lblempname"">--%>
                                <asp:Label ID="lblempname" Style="color: #f4f4f4; float: right; font-weight: 600;" runat="server" Text="Label"></asp:Label>
                                <%-- Mr. ANANTH  A</span>--%>

                            </span>

                        </div>

                        <div class="col-md-3 statuscol">
                            <div class="row status">
                                <ul class="nav nav-stacked" style="pointer-events: none;">
                                    <li class="voted"><a href="#" style="color: white; font-size: smaller;">Voted 
                                        <span class="votedlabel" style="color: white;">
                                            <%--   <span id="lblvoted">1</span>--%>
                                            <asp:Label ID="lblvoted" runat="server" class="badge2"> </asp:Label>
                                        </span></a></li>


                                </ul>
                                <ul class="nav nav-stacked " style="pointer-events: none;">
                                    <li class="pending"><a href="#" style="color: white; font-size: smaller; padding-left: 10px;">Pending <span class="pendiinglabel" style="color: white;">
                                        <%-- <span id="" >3</span>--%>
                                        <asp:Label ID="lblpending" class="badge1" runat="server"></asp:Label>
                                    </span></a></li>
                                </ul>
                                <ul class="nav nav-stacked">
                                    <li class="logout">

                                        <a href="logout.aspx" class="logout1" style="color: white; font-size: smaller; padding-right: 5px;"><i class="fa fa-sign-out "></i>Logout <span class="" style="color: white;"></span></a>

                                    </li>
                                </ul>
                            </div>
                            <!-- end col -->
                            <!--<div class="col-lg-8">
                    <nav class="navbar navbar-expand-lg text-lg-center justify-content-end">

                        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
                                aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                            <span class="navbar-toggler-icon"><i class="icon icon-menu"></i></span>
                        </button>
                        <div class="collapse navbar-collapse justify-content-end" id="navbarNavDropdown">
                            <ul class="navbar-nav">
                                <li class="dropdown nav-item active">
                                    <a href="#" class="" data-toggle="dropdown">Home <i class="fa fa-angle-down"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="index.html">Home One</a></li>
                                        <li><a href="index-2.html">Home Two</a></li>
                                        <li><a href="index-3.html">Home Three</a></li>
                                        <li><a href="index-4.html">Home Four</a></li>
                                        <li><a href="index-5.html">Home Five</a></li>
                                        <li><a href="index-6.html">Home Six</a></li>
                                        <li><a href="index-7.html">Home Seven</a></li>
                                    </ul>
                                </li>
                                <li class="dropdown nav-item">
                                    <a href="#" class="" data-toggle="dropdown">About <i class="fa fa-angle-down"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="about-us.html">About Us</a></li>
                                        <li><a href="gallery.html">Gallery</a></li>
                                        <li><a href="faq.html">FAQ</a></li>
                                        <li><a href="pricing.html">Pricing Table</a></li>
                                        <li><a href="sponsors-1.html">Sponsors</a></li>
                                        <li><a href="venue.html">Venue</a></li>
                                        <li><a href="404.html">Erro Page</a></li>
                                    </ul>
                                </li>
                                <li class="nav-item dropdown">
                                    <a href="#" class="" data-toggle="dropdown">Speakers <i class="fa fa-angle-down"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="speakers-1.html">Speakers-1</a></li>
                                        <li><a href="speakers-2.html">Speakers-2</a></li>
                                    </ul>

                                </li>
                                <li class="nav-item dropdown">
                                    <a href="#" class="" data-toggle="dropdown">Schedule <i class="fa fa-angle-down"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="schedule-list.html">Schedule List</a></li>
                                        <li><a href="schedule-tab-1.html">Schedule Tab 1</a></li>
                                        <li><a href="schedule-tab-2.html">Schedule Tab 2</a></li>
                                    </ul>
                                </li>
                                <li class="nav-item dropdown">
                                    <a href="#"> Blog <i class="fa fa-angle-down"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="blog.html">Blog</a></li>
                                        <li><a href="news-single.html">Blog Details</a></li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </nav>
                </div>-->
                            <!-- end col -->
                        </div>

                    </div>
                    </div>
                    <!-- container end-->
            </header>
            <!--/ Header end -->
            <!-- banner start-->
            <section class="hero-area banner-6 banner-6-alt" style="background-image: url(images/bg/top_right_bg.png); margin-bottom: -110px;">
                <div class="banner-item">
                    <div class="container">
                        <div class="row">
                            <div class="col-lg-6">
                                <div class="banner-content-wrap">
                                    <!--<div class="date-item wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="900ms">
                                  <span class="event-day">09</span>
                                  <span class="event-month">June</span>
                                  <span class="event-year">2020</span>
                            </div>-->

                                    <h2 class="banner-title wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="700ms">Nippon Paint Stars
                                    <!--<br> Relationships-->
                                    </h2>
                                    <h2 class="sub-title color-primary wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="800ms">NIPPON PAINT (INDIA) PRIVATE LIMITED
                                    </h2>
                                    <h2 class="sub-title color-primary wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="800ms">Welcome to the Staff Appreciation Award Competition 2019!
                                    </h2>
                                    <div class="banner-info wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="500ms">
                                        <!--<div class="icon">
                                    <img src="images/shap/Shape-1.png" alt="">
                                </div>-->
                                        <h3>Below is a collection of each Division’s top nominations of employees who have exemplified our LFG values (V.I.T.A.L.S) at work.</h3>
                                    </div>
                                </div>
                                <!-- Banner content wrap end -->
                            </div>
                            <!-- col end-->
                            <div class="col-md-6">
                                <div class="banner-image">
                                    <img src="images/hero_area/header_vector.png" alt="">
                                </div>
                            </div>
                        </div>
                        <!-- row end-->


                    </div>
                    <!-- Container end -->
                </div>
            </section>
            <!-- banner end-->
            <!-- ts experience start-->
            <section id="ts-experiences" class="ts-experiences">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-6 no-padding">
                            <div class="exp-img" style="background-image: url(images/blobby_meeting.jpg); height: 497px;">
                            </div>
                        </div>
                        <!-- col end-->
                        <div class="col-lg-6 no-padding align-self-center">
                            <div class="ts-exp-wrap">
                                <div class="ts-exp-content">
                                    <h2 class="column-title">
                                        <!--<span>INSTRUCTIONS:</span>-->
                                        INSTRUCTIONS:
                                    </h2>
                                    <p>
                                        We need YOU to select the top 5 winners from Nippon Paint India from the nominees below.
                                    </p>
                                    <p>Click on the photo of each nominee below to read about the reasons for their nomination</p>
                                    <p>
                                        You will have five votes in total (minimum one vote for each Division, and one extra vote for any Division).
                                    You can only submit your vote once.
                                    </p>
                                    <p>Show your support to your fellow employees and cast your votes now!</p>
                                    <p>Voting opens on 26 October 2019 and ends on 4 November 2019</p>
                                </div>
                            </div>

                        </div>
                        <!-- col end-->
                    </div>
                    <!-- row end-->
                </div>
                <!-- container fluid end-->
            </section>
            <!-- ts experience end-->
            <!-- ts speaker start-->
            <!-- ts speaker start-->
            <section id="ts-speakersdeco" class="ts-speakers imgsec1" style="background-image: url(images/speakers/speaker_bg.png)">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">
                            <h2 class="section-title text-center">
                                <span>Vote to the</span>
                                DECORATIVE
                            </h2>
                        </div>
                        <!-- col end-->
                    </div>
                    <!-- row end-->

                    <div class="row">
                  
                        <asp:Repeater runat="server" ID="rpt_deco" OnItemCommand="rpt_deco_ItemCommand">
                            <ItemTemplate>

                                <div class="col-md-2">
                                    <div class="col-lg-2 col-md-6 wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="400ms">
                                        <div class="ts-speaker">
                                            <div class="speaker-img">
                                                <asp:Label ID="lblcode" runat="server" Visible="false" Text='<%# Eval("voteid") %>'></asp:Label>
                                                <img class="img-fluid" src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                <a href='<%# Eval("showpopup")%>' class="view-speaker ts-image-popup" data-effect="mfp-zoom-in">
                                                    <i class="icon icon-plus"></i>
                                                </a>
                                            </div>
                                            <div class="ts-speaker-info">
                                                <h3 class="ts-title" ><a href="#">
                                                    <asp:Label ID="lblvotename" runat="server" Text='<%# Eval("Name") %>'></asp:Label></a></h3>
                                                   <p><asp:Button ID="btnvote" CommandName="Vote" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" />
                                                      <asp:Button ID="btnvoteagain" CommandName="VoteAgain" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" /> 


                                                   </p>  
                                            </div>
                                        </div>
                                           
                                        <!-- popup start-->
                                        <div id="<%# Eval("popupid")%>" class="container ts-speaker-popup mfp-hide">
                                            <div class="row">
                                                <div class="col-lg-6" style="max-width: 40%;">
                                                    <div class="ts-speaker-popup-img">
                                                        <img src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                    </div>
                                                </div>
                                                <!-- col end-->
                                                <div class="col-lg-6">
                                                    <div class="ts-speaker-popup-content">
                                                        <h3 class="ts-title"><%# Eval("Name") %></h3>
                                                        <span class="speakder-designation">
                                                            <asp:Label ID="lbldesignation" runat="server" Text='<%#Eval("Department")%>'></asp:Label>,
                                                            <asp:Label ID="lblDivision" runat="server" Text='<%#Eval("Division")%>'></asp:Label>
                                                        </span>
                                                        <%--<img class="company-logo" src="images/sponsors/sponsor-6.png" alt="">--%>
                                                        <h4 class="session-name">About Me
                                                        </h4>
                                                        <div class="Para1">
                                                        <p>
                                                           <%# Eval("Description") %>
                                                        </p>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-lg-6">
                                                                <div class="speaker-session-info">
                                                                    <%-- <h4>Day 1</h4>--%>
                                                                    <span>
                                                                        <%--  <asp:Button ID="btnVote" PostBackUrl="vote.aspx?voteto=<%#Eval("voteid")%>&name=<%#Eval("Name")%>&division=<%#Eval("Division")%>"  class="btn" runat="server" Text="Vote Me" />--%>
                                                                        <%--   <a href="vote.aspx?voteto=<%# Eval("voteid") %>&name=<%# Eval("Name") %>&division=<%#Eval("Division")%>&#ts-speakersdeco">click me</a>--%>
                                                                      
                                                                   
                                                                        </span>
                                                            
                                                            
                                                                </div>
                                                            </div>
                                                      
                                                        </div>
                                                    
                                                    </div>
                                                    <!-- ts-speaker-popup-content end-->
                                                </div>
                                                <!-- col end-->
                                            </div>
                                            <!-- row end-->
                                        </div>
                                        <!-- popup end-->
                                    </div>
                                    <!-- col end-->

                                </div>
                                

                                 
                            </ItemTemplate>
                        </asp:Repeater>



                        
                    </div>
                    <!-- row end-->
                </div>
                <!-- container end-->
                <!-- shap img-->
                <div class="speaker-shap">
                    <img class="shap1" src="images/shap/home_speaker_memphis1.png" alt="">
                    <img class="shap2" src="images/shap/home_speaker_memphis2.png" alt="">
                    <img class="shap3" src="images/shap/home_speaker_memphis3.png" alt="">
                </div>
                <!-- shap img end-->
            </section>
            <!-- ts speaker end-->
            <!-- ts speaker start-->
            <section id="ts-speakers" class="ts-speakers" style="background-image: url(images/speakers/speaker_bg.png)">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">
                            <h2 class="section-title text-center">
                                <span>Vote to the</span>
                                INDUSTRIAL UNIT
                            </h2>
                        </div>
                        <!-- col end-->
                    </div>
                    <!-- row end-->

                    <div class="row">
                        <asp:Repeater runat="server" ID="RP_IU" OnItemCommand="RP_IU_ItemCommand">
                            <ItemTemplate>

                                <div class="col-md-2">
                                    <div class="col-lg-2 col-md-6 wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="400ms">
                                        <div class="ts-speaker">
                                            <div class="speaker-img">
                                                <asp:Label ID="lblcode" runat="server" Visible="false" Text='<%# Eval("voteid") %>'></asp:Label>
                                                <img class="img-fluid" src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                <a href='<%# Eval("showpopup")%>' class="view-speaker ts-image-popup" data-effect="mfp-zoom-in">
                                                    <i class="icon icon-plus"></i>
                                                </a>
                                            </div>
                                            <div class="ts-speaker-info">
                                                <h3 class="ts-title" ><a href="#">
                                                    <asp:Label ID="lblvotename" runat="server" Text='<%# Eval("Name") %>'></asp:Label></a></h3>
                                                   <p><asp:Button ID="btnvote" CommandName="Vote" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" />
                                                      <asp:Button ID="btnvoteagain" CommandName="VoteAgain" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" /> 


                                                   </p>  
                                            </div>
                                        </div>
                                           
                                        <!-- popup start-->
                                        <div id="<%# Eval("popupid")%>" class="container ts-speaker-popup mfp-hide">
                                            <div class="row">
                                                <div class="col-lg-6" style="max-width: 40%;">
                                                    <div class="ts-speaker-popup-img">
                                                        <img src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                    </div>
                                                </div>
                                                <!-- col end-->
                                                <div class="col-lg-6">
                                                    <div class="ts-speaker-popup-content">
                                                        <h3 class="ts-title"><%# Eval("Name") %></h3>
                                                        <span class="speakder-designation">
                                                            <asp:Label ID="lbldesignation" runat="server" Text='<%#Eval("Department")%>'></asp:Label>,
                                                            <asp:Label ID="lblDivision" runat="server" Text='<%#Eval("Division")%>'></asp:Label>
                                                        </span>
                                                        <%--<img class="company-logo" src="images/sponsors/sponsor-6.png" alt="">--%>
                                                        <h4 class="session-name">About Me
                                                        </h4>
                                                            <div class="Para1">
                                                        <p>
                                                            <%# Eval("Description") %>
                                                        </p>
                                                                </div>

                                                        <div class="row">
                                                            <div class="col-lg-6">
                                                                <div class="speaker-session-info">
                                                                    <%-- <h4>Day 1</h4>--%>
                                                                    <span>
                                                                        <%--  <asp:Button ID="btnVote" PostBackUrl="vote.aspx?voteto=<%#Eval("voteid")%>&name=<%#Eval("Name")%>&division=<%#Eval("Division")%>"  class="btn" runat="server" Text="Vote Me" />--%>
                                                                        <%--   <a href="vote.aspx?voteto=<%# Eval("voteid") %>&name=<%# Eval("Name") %>&division=<%#Eval("Division")%>&#ts-speakersdeco">click me</a>--%>
                                                                      
                                                                   
                                                                        </span>
                                                            
                                                            
                                                                </div>
                                                            </div>
                                                      
                                                        </div>
                                                    
                                                    </div>
                                                    <!-- ts-speaker-popup-content end-->
                                                </div>
                                                <!-- col end-->
                                            </div>
                                            <!-- row end-->
                                        </div>
                                        <!-- popup end-->
                                    </div>
                                    <!-- col end-->

                                </div>

                            </ItemTemplate>
                        </asp:Repeater>






                    </div>
                    <!-- row end-->
                </div>
                <!-- container end-->
                <!-- shap img-->
                <div class="speaker-shap">
                    <img class="shap1" src="images/shap/home_speaker_memphis1.png" alt="">
                    <img class="shap2" src="images/shap/home_speaker_memphis2.png" alt="">
                    <img class="shap3" src="images/shap/home_speaker_memphis3.png" alt="">
                </div>
                <!-- shap img end-->
            </section>
            <!-- ts speaker end-->
            <!-- ts speaker start-->
            <section id="ts-speakers" class="ts-speakers" style="background-image: url(images/speakers/speaker_bg.png)">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">
                            <h2 class="section-title text-center">
                                <span>Vote to the</span>
                                AUTOMOTIVE REFINISH
                            </h2>
                        </div>
                        <!-- col end-->
                    </div>
                    <!-- row end-->

                    <div class="row">
                   <asp:Repeater runat="server" ID="RP_AR" OnItemCommand="RP_AR_ItemCommand">
                            <ItemTemplate>

                                <div class="col-md-2">
                                    <div class="col-lg-2 col-md-6 wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="400ms">
                                        <div class="ts-speaker">
                                            <div class="speaker-img">
                                                <asp:Label ID="lblcode" runat="server" Visible="false" Text='<%# Eval("voteid") %>'></asp:Label>
                                                <img class="img-fluid" src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                <a href='<%# Eval("showpopup")%>' class="view-speaker ts-image-popup" data-effect="mfp-zoom-in">
                                                    <i class="icon icon-plus"></i>
                                                </a>
                                            </div>
                                            <div class="ts-speaker-info">
                                                <h3 class="ts-title" ><a href="#">
                                                    <asp:Label ID="lblvotename" runat="server" Text='<%# Eval("Name") %>'></asp:Label></a></h3>
                                                   <p><asp:Button ID="btnvote" CommandName="Vote" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" />
                                                       <asp:Button ID="btnvoteagain" CommandName="VoteAgain" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" /> 


                                                   </p>  
                                            </div>
                                        </div>
                                           
                                        <!-- popup start-->
                                        <div id="<%# Eval("popupid")%>" class="container ts-speaker-popup mfp-hide">
                                            <div class="row">
                                                <div class="col-lg-6" style="max-width: 40%;">
                                                    <div class="ts-speaker-popup-img">
                                                        <img src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                    </div>
                                                </div>
                                                <!-- col end-->
                                                <div class="col-lg-6">
                                                    <div class="ts-speaker-popup-content">
                                                        <h3 class="ts-title"><%# Eval("Name") %></h3>
                                                        <span class="speakder-designation">
                                                            <asp:Label ID="lbldesignation" runat="server" Text='<%#Eval("Department")%>'></asp:Label>,
                                                            <asp:Label ID="lblDivision" runat="server" Text='<%#Eval("Division")%>'></asp:Label>
                                                        </span>
                                                        <%--<img class="company-logo" src="images/sponsors/sponsor-6.png" alt="">--%>
                                                        <h4 class="session-name">About Me
                                                        </h4>
                                                            <div class="Para1">
                                                        <p>
                                                              <%# Eval("Description") %>
                                                        </p>
                                                                </div>

                                                        <div class="row">
                                                            <div class="col-lg-6">
                                                                <div class="speaker-session-info">
                                                                    <%-- <h4>Day 1</h4>--%>
                                                                    <span>
                                                                        <%--  <asp:Button ID="btnVote" PostBackUrl="vote.aspx?voteto=<%#Eval("voteid")%>&name=<%#Eval("Name")%>&division=<%#Eval("Division")%>"  class="btn" runat="server" Text="Vote Me" />--%>
                                                                        <%--   <a href="vote.aspx?voteto=<%# Eval("voteid") %>&name=<%# Eval("Name") %>&division=<%#Eval("Division")%>&#ts-speakersdeco">click me</a>--%>
                                                                      
                                                                   
                                                                        </span>
                                                            
                                                            
                                                                </div>
                                                            </div>
                                                      
                                                        </div>
                                                    
                                                    </div>
                                                    <!-- ts-speaker-popup-content end-->
                                                </div>
                                                <!-- col end-->
                                            </div>
                                            <!-- row end-->
                                        </div>
                                        <!-- popup end-->
                                    </div>
                                    <!-- col end-->

                                </div>

                            </ItemTemplate>
                        </asp:Repeater>




                    </div>
                    <!-- row end-->
                </div>
                <!-- container end-->
                <!-- shap img-->
                <div class="speaker-shap">
                    <img class="shap1" src="images/shap/home_speaker_memphis1.png" alt="">
                    <img class="shap2" src="images/shap/home_speaker_memphis2.png" alt="">
                    <img class="shap3" src="images/shap/home_speaker_memphis3.png" alt="">
                </div>
                <!-- shap img end-->
            </section>
            <!-- ts speaker end-->
            <!-- ts speaker start-->
            <section id="ts-speakers" class="ts-speakers" style="background-image: url(images/speakers/speaker_bg.png)">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">
                            <h2 class="section-title text-center">
                                <span>Vote to the</span>
                                CORPORATE OFFICE
                            </h2>
                        </div>
                        <!-- col end-->
                    </div>
                    <!-- row end-->

                    <div class="row">
                    <asp:Repeater runat="server" ID="RP_CO" OnItemCommand="RP_CO_ItemCommand" >
                            <ItemTemplate>

                                <div class="col-md-2">
                                    <div class="col-lg-2 col-md-6 wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="400ms">
                                        <div class="ts-speaker">
                                            <div class="speaker-img">
                                                <asp:Label ID="lblcode" runat="server" Visible="false" Text='<%# Eval("voteid") %>'></asp:Label>
                                                <img class="img-fluid" src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                <a href='<%# Eval("showpopup")%>' class="view-speaker ts-image-popup" data-effect="mfp-zoom-in">
                                                    <i class="icon icon-plus"></i>
                                                </a>
                                            </div>
                                            <div class="ts-speaker-info">
                                                <h3 class="ts-title" ><a href="#">
                                                    <asp:Label ID="lblvotename" runat="server" Text='<%# Eval("Name") %>'></asp:Label></a></h3>
                                                   <p>
                                                       <asp:Button ID="btnvote" CommandName="Vote" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" /> 
                                                      <asp:Button ID="btnvoteagain" CommandName="VoteAgain" class="btn"  style="margin-top: 0;height: 35px;line-height: 10px;padding-left: 10px;padding-right: 10px;" runat="server" Text="Vote Me" /> 

                                                   </p>  
                                            </div>
                                        </div>
                                           
                                        <!-- popup start-->
                                        <div id="<%# Eval("popupid")%>" class="container ts-speaker-popup mfp-hide">
                                            <div class="row">
                                                <div class="col-lg-6" style="max-width: 40%;">
                                                    <div class="ts-speaker-popup-img">
                                                        <img src='<%#Eval("ImageUrl","images/employeephotos/{0}")%>' alt="">
                                                    </div>
                                                </div>
                                                <!-- col end-->
                                                <div class="col-lg-6">
                                                    <div class="ts-speaker-popup-content">
                                                        <h3 class="ts-title"><%# Eval("Name") %></h3>
                                                        <span class="speakder-designation">
                                                            <asp:Label ID="lbldesignation" runat="server" Text='<%#Eval("Department")%>'></asp:Label>,
                                                            <asp:Label ID="lblDivision" runat="server" Text='<%#Eval("Division")%>'></asp:Label>
                                                        </span>
                                                        <%--<img class="company-logo" src="images/sponsors/sponsor-6.png" alt="">--%>
                                                        <h4 class="session-name">About Me
                                                        </h4>
                                                            <div class="Para1">
                                                        <p>
                                                             <%# Eval("Description") %>
                                                        </p>
                                                                </div>

                                                        <div class="row">
                                                            <div class="col-lg-6">
                                                                <div class="speaker-session-info">
                                                                    <%-- <h4>Day 1</h4>--%>
                                                                    <span>
                                                                        <%--  <asp:Button ID="btnVote" PostBackUrl="vote.aspx?voteto=<%#Eval("voteid")%>&name=<%#Eval("Name")%>&division=<%#Eval("Division")%>"  class="btn" runat="server" Text="Vote Me" />--%>
                                                                        <%--   <a href="vote.aspx?voteto=<%# Eval("voteid") %>&name=<%# Eval("Name") %>&division=<%#Eval("Division")%>&#ts-speakersdeco">click me</a>--%>
                                                                      
                                                                   
                                                                        </span>
                                                            
                                                            
                                                                </div>
                                                            </div>
                                                      
                                                        </div>
                                                    
                                                    </div>
                                                    <!-- ts-speaker-popup-content end-->
                                                </div>
                                                <!-- col end-->
                                            </div>
                                            <!-- row end-->
                                        </div>
                                        <!-- popup end-->
                                    </div>
                                    <!-- col end-->

                                </div>

                            </ItemTemplate>
                        </asp:Repeater>





                    </div>
                    <!-- row end-->
                </div>
                <!-- container end-->
                <!-- shap img-->
                <div class="speaker-shap">
                    <img class="shap1" src="images/shap/home_speaker_memphis1.png" alt=""/>
                    <img class="shap2" src="images/shap/home_speaker_memphis2.png" alt=""/>
                    <img class="shap3" src="images/shap/home_speaker_memphis3.png" alt=""/>
                </div>
                <!-- shap img end-->
            </section>
            <!-- ts speaker end-->
            <!-- footer start-->
            <footer class="ts-footer">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12 mx-auto">


                            <div class="copyright-text text-center">
                                <p>Copyright © 2019 Nippon Paint. All Rights Reserved.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
            <!-- footer end-->
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
            <!-- scrollme -->
            <script src="js/jquery.scrollme.js"></script>

            <!-- Template custom -->
            <script src="js/main.js"></script>

        </div>

                



              

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <%--<script type="text/javascript">

        $(document).ready(function () {
            // Handler for .ready() called.
            $('html, body').animate({
                scrollTop: $('#ts-speakersdeco').offset().top
            }, 'slow');
        });

    </script>--%>
            </ContentTemplate>

        </asp:UpdatePanel>
        <!-- Body inner end -->
    </form>
       <script src="toast/jquery.min.js"></script>
    <link href="toast/toastr.css" rel="stylesheet" />
    <script src="toast/toastr.js"></script>
    <style>
        .toast-top-center {
            margin: 0 auto;
            left: 50%;
            color: white;
        }

        .tost-class {
             /*background-color: #ff2d55;*/
            background-color: #e7015e;
            width: 500px !important;
        }
    </style>
    <script type="text/javascript">
        function showpop5(msg, title) {
            toastr.options = {
                "toastClass": "tost-class",
                "closeButton": false,
                "debug": false,
                "newestOnTop": false,
                "progressBar": true,
                "positionClass": "toast-top-right",
                "preventDuplicates": true,
                "onclick": null,
                "showDuration": "300",
                "hideDuration": "1000",
                "timeOut": "4000",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            }
             setTimeout(function(){
      location.reload();
     },3000);
            // toastr['success'](msg, title);
            var d = Date();
            toastr.error(msg, title);
            return false;


        }
    </script>
</body>
</html>
