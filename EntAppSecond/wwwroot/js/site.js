// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

//THIS WAS AN ATTEMPT AT VALIDATION BUT ITS NOT WORKING PROPERLY

jQuery.Validation.addMethod("StartDate"),
    function (value, element, param) {

        return (value > Date.now);

    }};

jQuery.Validation.unobtrusive.adaptors.addBool("StartDate")
