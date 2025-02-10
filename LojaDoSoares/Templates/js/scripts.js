/*!
* Start Bootstrap - Shop Homepage v5.0.6 (https://startbootstrap.com/template/shop-homepage)
* Copyright 2013-2023 Start Bootstrap
* Licensed under MIT (https://github.com/StartBootstrap/startbootstrap-shop-homepage/blob/master/LICENSE)
*/
// This file is intentionally blank
// Use this file to add JavaScript to your project

 // JavaScript to handle cart functionality
 let cart = [];

 // Function to update the cart count
 function updateCartCount() {
     document.getElementById('cartCount').textContent = cart.length;
 }

 // Add to cart event listener
