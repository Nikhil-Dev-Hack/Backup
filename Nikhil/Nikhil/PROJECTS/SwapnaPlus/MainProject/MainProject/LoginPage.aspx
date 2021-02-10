﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MainProject.LoginPage" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <link href="LoginPage.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="LoginPage.js"></script>
    <title></title>
</head>
<body>
    <div class="container" id="container">
        <div class="form-container log-in-container">
            <form action="#">
                <h1>Login</h1>
                <div class="social-container">
                    <a href="https://www.facebook.com/login/" class="social"><i class="fa fa-facebook fa-2x"></i></a>
                    <a href="https://twitter.com/login?lang=en" class="social"><i class="fab fa fa-twitter fa-2x"></i></a>
                </div>
                <span>or use your account</span>
                <input type="email" placeholder="Email" />
                <input type="password" placeholder="Password" />
                <label>New to SwapnaPlus<a href="SignUp.html">Register Here</a></label>
                <button>Log In</button>
            </form>
        </div>
        <div class="overlay-container">
            <img src="Images/Logo.png"  style="margin-top:100px" />
            <div class="overlay">
                
            </div>
        </div>
    </div>
</body>
</html>