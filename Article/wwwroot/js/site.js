// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const currentUrl = window.location.pathname
console.log(currentUrl)


if (currentUrl === '/User/Index' || currentUrl === '/User') {
    document.querySelector('#register-btn').addEventListener('click', () => window.location.href = '/User/Register')

    document.querySelector('#login-btn').addEventListener('click', () => window.location.href = '/User/Login')
}