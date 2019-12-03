<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="employeevote.assets.Index" %>

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

   <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <style>
        .ts-footer {
            background: #1a1831;
            padding: 25px 0 25px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">


                                    <ContentTemplate>
       <div class="body-inner">

      <!-- Header start -->
      <header id="header" class="header header-transparent">
         <div class="container">
            <nav class="navbar navbar-expand-lg navbar-light">
               <!-- logo-->
               <a class="navbar-brand" >
                  <img src="https://nipponpaint.co.in/wp-content/uploads/2018/04/Nippon-Logo.png" style="height: 80px;" alt="">
               </a>
               &nbsp;<!--<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown"
                  aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                  <span class="navbar-toggler-icon"><i class="icon icon-menu"></i></span>
               </button>--><!--<div class="collapse navbar-collapse" id="navbarNavDropdown">
                  <ul class="navbar-nav ml-auto">
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
                     <li class="nav-item">
                        <a href="contact.html">Contact</a>
                     </li>
                     <li class="header-ticket nav-item">
                        <a class="ticket-btn btn" href="pricing.html"> Buy  Ticket
                        </a>
                     </li>
                  </ul>
               </div>--></nav>
         </div><!-- container end-->
      </header>
      <!--/ Header end -->

      <!-- banner start-->
      <section class="hero-area hero-speakers">
         <div class="banner-item overlay" style="background-image:url(images/banner_image_vote.jpg)">
            <div class="container">
               <div class="row">
                  <div class="col-lg-7">
                      <div class="banner-content-wrap">

                          <p class="banner-info wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="500ms">
                              Welcome to the Staff Appreciation Award Competition 2019!
                          </p>
                          <h1 class="banner-title wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="700ms">
                              Nippon Paint Stars
                          </h1>
                      


                          <!--<div class="banner-btn wow fadeInUp" data-wow-duration="1.5s" data-wow-delay="800ms">
                              <a href="#" class="btn">Buy Ticket</a>
                              <a href="#" class="btn fill">Add to Calendar</a>
                          </div>-->

                      </div>
                     <!-- Banner content wrap end -->
                  </div><!-- col end-->
                  <div class="col-lg-4 offset-lg-1">
                     <div class="hero-form-content">
                         <h2>We Love to Hear From You</h2>
                         <p style="font-size: smaller;margin-bottom: 10px;">
                             Please Login with your HRMS credentials.
                         </p>
                        <div class="hero-form">
                         <%--  <input  name="name" id="f-name"
                              type="text" >--%>
                            <asp:TextBox required="" ID="txtempid" class="form-control form-control-name" placeholder="Employee ID" runat="server"></asp:TextBox>
                         
                            <asp:TextBox ID="txtpwd" class="form-control form-control-phone"  required="" placeholder="Password" TextMode="Password"  runat="server"></asp:TextBox>

                           <!--<input class="form-control form-control-email" placeholder="Email" name="email" id="f-email"
                              type="email" required="">

                           <select name="ticket" id="ticket">
                              <option value="ticket">Ticket Type</option>
                              <option value="ticket">Ticket 1</option>
                              <option value="ticket">Ticket 2</option>
                              <option value="ticket">Ticket 3</option>
                           </select>-->
                            <asp:Button ID="btnlogin" class="btn"  runat="server" Text="Login" OnClick="btnlogin_Click" />
                          

                        </div><!-- form end-->
                     </div><!-- hero content end-->
                  </div><!-- col end-->
               </div><!-- row end-->
            </div>
            <!-- Container end -->
         </div>
      </section>
      <!-- banner end-->

      <!-- ts intro start -->
      <!--<section class="ts-event-outcome event-intro">
         <div class="container">
            <div class="row">
               <div class="col-lg-4">
                  <div class="">
                     <div class="outcome-content ts-exp-content">
                        <h2 class="column-title">
                           <span>Event Outcomes</span>
                           Learn new things and
                           connect people
                        </h2>
                        <p>
                           How you transform your business technology consumer, habits industry dynamic change the Find
                           out from those leading
                        </p>
                        <a href="#" class="btn">Leanr More</a>
                     </div>
                  </div>
               </div>
               <div class="col-lg-4">
                  <div class="outcome-content">
                     <div class="outcome-img overlay">
                        <img class="" src="images/about/learn_img.jpg" alt="">
                     </div>
                     <h3 class="img-title text-white"><a href="#" class="text-white">Learn Things</a></h3>
                  </div>
               </div>
               <div class="col-lg-4">
                  <div class="outcome-content">
                     <div class="outcome-img overlay">
                        <img class="" src="images/about/connect_img.jpg" alt="">
                     </div>
                     <h3 class="img-title"><a href="#" class="text-white">connect People</a></h3>
                  </div>
               </div>

            </div>
         </div>
      </section>-->
      <!-- ts intro end-->
      <!-- ts funfact start-->
      
      <!-- ts funfact end-->
      <!-- ts speaker start-->
      
      <!-- ts speaker end-->

      <!-- ts experience start-->
      
      <!-- ts experience end-->

      <!-- ts experience start-->
      
      <!-- ts experience end-->

      <!-- ts pricing start-->
      
      <!-- ts pricing end-->
      <!-- ts blog start-->
      
      <!-- ts blog end-->

      <!-- ts sponsors start-->
      
      <!-- ts sponsors end-->

      <!-- ts map direction start-->
      
      <!-- ts map direction end-->

      <!-- ts footer area start-->
      <div class="footer-area">

         <!-- ts-book-seat start-->
         
         <!-- book seat  end-->

         <!-- footer start-->
         <footer class="ts-footer">
            <div class="container">
               <div class="row">
                  <div class="col-lg-8 mx-auto">
                   
                   
                     <div class="copyright-text text-center">
                        <p>Copyright © 2019 Nippon Paint. All Rights Reserved.</p>
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

                                        </ContentTemplate>
                </asp:UpdatePanel>
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
            background-color: orange;
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
            // toastr['success'](msg, title);
            var d = Date();
            toastr.error(msg, title);
            return false;
        }
    </script>
</body>
</html>
